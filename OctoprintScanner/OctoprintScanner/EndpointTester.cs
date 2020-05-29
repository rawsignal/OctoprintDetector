using OctoprintScanner.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OctoprintScanner
{
    public class EndpointTester
    {
        public void TestEndpointAsync(Endpoint endpoint)
        {
            var request = (HttpWebRequest)WebRequest.Create(endpoint.BaseAddress + endpoint.Uri);
            request.Method = "HEAD";

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == endpoint.ExpectedStatusCode)
                {
                    if (response.ContentLength == endpoint.ExpectedContentLength) endpoint.Matched = true;
                }
                else endpoint.Matched = false;
                endpoint.ActualStatusCode = response.StatusCode;
            }
            catch (Exception ex)
            {
                endpoint.ActualStatusCode = HttpStatusCode.InternalServerError;
            }
        }
    }
}
