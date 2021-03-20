using Microsoft.EntityFrameworkCore;

namespace Blogs.Common.Models
{
    public class BlogsContext : DbContext
    {
        public BlogsContext(DbContextOptions<BlogsContext> options) : base(options)
        {

        }

        public DbSet<Blog> Blog { get; set; }
    }
}
