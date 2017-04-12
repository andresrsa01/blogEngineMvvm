using System;
using BlogEngine.DataAccess.Source;
using BlogEngine.Model;

namespace BlogEngine.BusinessLogic
{
    public class BLUser : IDisposable
    {
        private readonly DAUser _da = new DAUser();

        private bool Login(User user)
        {
            try
            {
                return _da.Login(user);
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
