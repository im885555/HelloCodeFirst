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
        HelloContext db;

        
        public CommentController()
        {
            db = new HelloContext();
        }

        // GET api/comment
        public IEnumerable<Comment> Get()
        {
            List<Comment> comments = new List<Comment>();      
            comments = db.Comments.ToList();
            return comments;
        }

        // GET api/comment/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/comment
        public IEnumerable<Comment> Post([FromBody]Comment comment)
        {

            db.Comments.Add(comment);
            db.SaveChanges();

            return db.Comments.ToList();
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
