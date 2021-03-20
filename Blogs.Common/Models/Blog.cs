using System;

namespace Blogs.Common.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Heading { get; set; }
        public string Body { get; set; }
        public DateTimeOffset LastModifiedDate { get; set; }
    }
}
