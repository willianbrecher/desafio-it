using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DesafioItAutomatedTests.StepDefinitions
{
    public class BaseSteps
    {
        protected HttpClient _httpClient { get; set; }
        public HttpStatusCode StatusCode { get; set; }

        protected const string HOST_API_FOR_TESTS = "http://localhost:5093";
        public BaseSteps()
        {
            _httpClient = new HttpClient();
        }
    }
}
