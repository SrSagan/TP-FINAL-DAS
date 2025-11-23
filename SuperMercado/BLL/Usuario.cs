using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario
    {
        public int Create(BE.Usuario usr)
        {
            return new DAL.MapperUsuario().Create(usr);
        }
        public BE.Usuario Get(String mail)
        {
            return new DAL.MapperUsuario().GetByMail(mail);
        }

        public bool Validar(string username, string password)
        {
            if (username != null && password != null)
            {
                BE.Usuario user = Get(username);
                return user.Password == password;
            }
            return false;
        }
    }
}
