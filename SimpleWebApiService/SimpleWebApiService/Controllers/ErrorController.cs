using System;
using System.Collections.Generic;
using System.Web.Http;

namespace SimpleWebApiService.Controllers
{
    public class ErrorController  : ApiController
    {
        /// <summary>
        /// Call this action in order to force an exception being thrown.
        /// </summary>
        /// <returns>Throws an ApplicationException</returns>
        public IEnumerable<string> Get()
        {
            throw new ApplicationException("This is an intended exception in order to verify that all exception logging works as intended.");
        }
    }
}