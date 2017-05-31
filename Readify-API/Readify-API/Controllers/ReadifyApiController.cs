using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Readify_API.Filters;
using Readify_API.Services;

namespace Readify_API.Controllers
{
    [RoutePrefix("readify/api")]
    public class ReadifyApiController : ApiController
    {
        [HttpGet]
        [Route("Fibonacci")]
        [RejectRequestsWithNoBody]
        public HttpResponseMessage GetNthFibonacciNumber([FromUri]int n)
        {
            var nthNumber = FibonacciService.GetNthFibbinociNumber(n);

            return Request.CreateResponse(HttpStatusCode.OK, nthNumber);


        }

        [HttpGet]
        [Route("ReverseWords")]
        public HttpResponseMessage GetReverseString([FromUri]string sentence)
        {
            var result = ReverseWordsService.ReverseString(sentence);

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpGet]
        [Route("Token")]
        public HttpResponseMessage GetToken()
        {
            var token = Guid.NewGuid();
            return Request.CreateResponse(HttpStatusCode.OK, token);
        }

        [HttpGet]
        [Route("TriangleType")]
        [RejectRequestsWithNoBody]
        public HttpResponseMessage GetTriangleType([FromUri]int a, int b, int c)
        {

            var result = TriangleTypeService.GetTriangleType(a, b, c);
            return Request.CreateResponse(HttpStatusCode.OK, result.ToString());

        }
    }
}
