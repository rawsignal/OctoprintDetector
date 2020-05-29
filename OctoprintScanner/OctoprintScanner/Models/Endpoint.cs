using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OctoprintScanner.Models
{
    public class Endpoint
    {
        public string BaseAddress { get; set; }
        public string Uri { get; set; }
        public string Status { get; set; }
        public HttpStatusCode ExpectedStatusCode { get; set; }
        public HttpStatusCode ActualStatusCode { get; set; }
        public bool Matched { get; set; }
        public int ExpectedContentLength { get; set; }
    }
}
