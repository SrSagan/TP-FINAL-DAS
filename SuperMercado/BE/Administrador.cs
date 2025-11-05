using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Administrador : Usuario
    {
        private readonly int poderAdministrativo;

        public int PoderAdministrativo
        {
            get { return poderAdministrativo; }
        }
        public Administrador(int id, string nombre, string apellido, int dni, string mail, string password, int poderAdministrativo) : base(id, nombre, apellido, dni, mail, password)
        {
            this.poderAdministrativo = poderAdministrativo;
        }
    }
}
