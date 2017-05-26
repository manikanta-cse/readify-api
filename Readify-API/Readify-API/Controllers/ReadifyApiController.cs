using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Readify_API.Services;

namespace Readify_API.Controllers
{
    [RoutePrefix("readify/api")]
    public class ReadifyApiController : ApiController
    {
        [HttpGet]
        [Route("Fibonacci")]
        public HttpResponseMessage GetNthFibonacciNumber([FromUri]string n)
        {
            long parsedQuery;

           var result= Int64.TryParse(n, out parsedQuery);

           if (result)

            {
                var nthNumber = FibonacciService.GetNthFibbinociNumber(parsedQuery);

                return Request.CreateResponse(HttpStatusCode.OK, nthNumber);
            }

            return Request.CreateResponse(HttpStatusCode.BadRequest, "The request is invalid.");
           
        }
        
    }
}
