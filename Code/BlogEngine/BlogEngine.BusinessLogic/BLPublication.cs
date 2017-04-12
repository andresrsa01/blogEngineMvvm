using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogEngine.DataAccess.Source;
using BlogEngine.Model;

namespace BlogEngine.BusinessLogic
{
    public class BLPublication : IDisposable
    {
        private readonly DAPublication _da = new DAPublication();

        public void CreatePublication(Publication publication)
        {
            try
            {
                _da.CreatePublication(publication);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IList<Publication> ListPublications(Blog blog)
        {
            try
            {
                return _da.ListPublications(blog);
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
