using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogEngine.DataAccess.Repository;
using BlogEngine.Model;

namespace BlogEngine.DataAccess.Source
{
   public class DAUser:IDAUser
    {

        private readonly BlogEngineContext _db = new BlogEngineContext();

        public void Dispose()
        {
            _db.Dispose();
        }


        public bool Login(User user)
        {
            var query = _db.Users.Where(usuario => usuario.UserId == user.UserId && usuario.Password == user.Password);
            var valido = query.Any();
            return valido;
        }
    }
}
