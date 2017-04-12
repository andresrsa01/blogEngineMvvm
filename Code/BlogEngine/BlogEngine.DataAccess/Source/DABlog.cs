using System.Collections.Generic;
using System.Linq;
using BlogEngine.DataAccess.Repository;
using BlogEngine.Model;

namespace BlogEngine.DataAccess.Source
{
    public class DABlog:IDABlog
    {
        private readonly  BlogEngineContext _db= new BlogEngineContext();
        public void Dispose()
        {
            _db.Dispose();
        }

        public void CreateBlog(Blog blog)
        {
            _db.Blogs.Add(blog);
            _db.SaveChanges();
        }

        public IList<Blog> ListBlogs()
        {
            IList<Blog> list = _db.Blogs.ToList();
            return list;
        }
    }
}
