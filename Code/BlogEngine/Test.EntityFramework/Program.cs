using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogEngine.DataAccess;

namespace Test.EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BlogEngineContext())
            {
                var listaBlogs = db.Blogs.ToList();
            }
        }
    }
}
