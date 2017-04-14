using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogEngine.DataAccess.Source;
using BlogEngine.Model;

namespace BlogEngine.BusinessLogic
{
    public class BLBlog : IDisposable
    {
        private readonly DABlog _da = new DABlog();

        public void CreateBlog(Blog blog)
        {
            try
            {
                _da.CreateBlog(blog);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IList<Blog> ListBlogs()
        {

            try
            {
                return _da.ListBlogs();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            _da.Dispose();
        }
    }
}
