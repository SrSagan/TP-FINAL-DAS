using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
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
        public BE.Usuario GetInstanceUser() => UsuarioActual.Instance.Data;

        public BE.Usuario GetByMail(String mail)
        {
            return new DAL.MapperUsuario().GetByMail(mail);
        }
        public bool ExistsByMail(string mail)
        {
            var user = new DAL.MapperUsuario().GetByMail(mail);
            return user != null;
        }
        public bool ExistsByDNI(int DNI)
        {
            var user = new DAL.MapperUsuario().GetByDNI(DNI);
            return user != null;
        }
        public BE.Usuario GetById(int id)
        {
            return new DAL.MapperUsuario().GetById(id);
        }

        public bool Validar(string username, string password)
        {
            if (username != null && password != null)
            {
                BE.Usuario user = GetByMail(username);
                return user.Password == Cripto.ComputeSha256Hash(password);
            }
            return false;
        }
        public BE.Usuario Login(BE.Usuario user)
        {
            UsuarioActual.Instance.SetUser(user);
            return UsuarioActual.Instance.Data;
        }
        public void LogOut()
        {
            UsuarioActual.Instance.Clear();
        }
        public int UpdatePassword (BE.Usuario usr, string password)
        {
            return new DAL.MapperUsuario().UpdatePassword(usr, password);
        }

    }
}
