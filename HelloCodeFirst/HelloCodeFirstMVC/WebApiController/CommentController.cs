using HelloCodeFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloCodeFirstMVC.WebApiController
{
    public class CommentController : ApiController
    {
        // GET api/comment
        public IEnumerable<Comment> Get()
        {
            List<Comment> comments = new List<Comment>();

            using (var db = new HelloContext())
            {
                var query = from b in db.Comments
                            select b;

                comments = query.ToList();
            }
            return comments;
        }

        // GET api/comment/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/comment
        public void Post([FromBody]string value)
        {
            String a ="";
        }

        // PUT api/comment/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/comment/5
        public void Delete(int id)
        {
        }
    }
}
