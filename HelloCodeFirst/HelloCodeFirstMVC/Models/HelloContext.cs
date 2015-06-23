using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HelloCodeFirstMVC.Models
{
    public class HelloContext : DbContext 
    {
       
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public HelloContext()
            : base("name=DefaultConnection") 
        { 

        }

    }
}