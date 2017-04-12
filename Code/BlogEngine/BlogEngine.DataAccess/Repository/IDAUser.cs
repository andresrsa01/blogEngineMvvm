using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogEngine.Model;

namespace BlogEngine.DataAccess.Repository
{
    public interface IDAUser : IDisposable
    {
        bool Login(User user);
    }
}
