using OctoprintScanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OctoprintScanner
{
    public class IpRanger
    {
        public List<Endpoint> Endpoints { get; set; }

        //future re-usability dictates this should be in a config file or something. It is not.

        private static int _baseThirdOctetStart = 0;

        private static int _baseThirdOctetEnd = 1;

        private static int _baseFourthOctetStart = 1;

        private static int _baseFourthOctetEnd = 255;

        private static int _expectedContentLength = 51;

        private static string _httpStyle = "http";

        private static string _octoprintEndpoint = "api/currentuser";

        private static HttpStatusCode _expectedStatusCode = HttpStatusCode.OK;

        public void UpdateEndpoints()
        {
            if (Endpoints == null) Endpoints = new List<Endpoint>();

            var baseThirdOctetRange = Enumerable.Range(_baseThirdOctetStart, _baseThirdOctetEnd+1);
            var baseFourthOctetRange = Enumerable.Range(_baseFourthOctetStart, _baseFourthOctetEnd);

            foreach(int thirdOctet in baseThirdOctetRange)
            {
                foreach(int fourthOctet in baseFourthOctetRange)
                {
                    Endpoints.Add(new Endpoint()
                    {
                        BaseAddress = $"{_httpStyle}://192.168.{thirdOctet}.{fourthOctet}/",
                        Uri = _octoprintEndpoint,
                        ExpectedStatusCode = _expectedStatusCode,
                        Status = Constants.Constants.WaitStart,
                        ExpectedContentLength = _expectedContentLength
                    });
                }
            }
        }
    }
}
