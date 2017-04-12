using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogEngine.Model;

namespace BlogEngine.DataAccess
{
    public class BlogEngineContext : DbContext
    {
        public BlogEngineContext() : base("name=BlogEngineContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Publication> Publications { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
