using HelloCodeFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloCodeFirstMVC.Controllers
{
    public class DBCodeFirstController : Controller
    {
        //
        // GET: /DBCodeFirst/

        public ActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        public ActionResult Hello(String name)
        {
            if (name != null) {
                var blog = new Blog { Name = name };
                AddBlog(blog);
            }

            return View(GetBlogs());
        }
        //[HttpPost]
        //public ActionResult Hello(String name)
        //{
       
        //    var blog = new Blog { Name = name };
        //    AddBlog(blog);
         
        //    return View(GetBlogs());
        //}
        private void AddBlog(Blog blog)
        {
            using (var db = new BloggingContext())
            {
                db.Blogs.Add(blog);
                db.SaveChanges();
            }
        }

        private List<Blog> GetBlogs()
        {
            List<Blog> blogs = new List<Blog>();
            using (var db = new BloggingContext())
            {
                var query = from b in db.Blogs
                            select b;

                blogs = query.ToList();
            }
            return blogs;
        }
    }
}
