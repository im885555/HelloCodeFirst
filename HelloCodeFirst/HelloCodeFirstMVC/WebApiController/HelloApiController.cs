using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloCodeFirstMVC.WebApiController
{
    public class HelloApiController : ApiController
    {
        
        public HelloApiController() 
        {
           
            if (!User.Identity.IsAuthenticated) 
            {
                throw new Exception("You are not authorized to use this page!");
            }
        }

 
        // GET api/helloapi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
            //if (User.Identity.IsAuthenticated)
            //{
            //    return new string[] { "value1", "value2" };
            //}
            //else
            //{
            //    throw new Exception("You are not authorized to use this page!");
            //}
        }

        // GET api/helloapi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/helloapi
        public void Post([FromBody]string value)
        {
        }

        // PUT api/helloapi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/helloapi/5
        public void Delete(int id)
        {
        }
    }
}
