using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogEngine.DataAccess.Repository;
using BlogEngine.Model;

namespace BlogEngine.DataAccess.Source
{
    public class DAPublication : IDAPublication
    {
        private readonly BlogEngineContext _db = new BlogEngineContext();
        public void Dispose()
        {
            _db.Dispose();
        }

        public void CreatePublication(Publication publication)
        {
            _db.Publications.Add(publication);
            _db.SaveChanges();
        }

        public IList<Publication> ListPublications(Blog blog)
        {
            var query = _db.Publications.Where(publication => publication.Blog.BlogId == blog.BlogId);
            IList<Publication> list = query.ToList();
            return list;
        }
    }
}
