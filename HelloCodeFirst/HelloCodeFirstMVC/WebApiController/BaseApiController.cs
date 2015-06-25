using HelloCodeFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloCodeFirstMVC.WebApiController
{
    public class BaseApiController : ApiController
    {
        protected HelloContext db;
        public BaseApiController() 
        {
            if (!User.Identity.IsAuthenticated)
            {
                throw new Exception("You are not authorized to use this page!");
            }

            db = new HelloContext();
        }
    }
}
