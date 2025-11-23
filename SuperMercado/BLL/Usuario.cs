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
    }
}
