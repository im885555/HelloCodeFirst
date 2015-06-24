using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloCodeFirstMVC.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
    }
}