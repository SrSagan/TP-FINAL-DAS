using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente : Usuario
    {
        private Carrito carrito;

        public Cliente(int id, string nombre, string apellido, int dni, string mail, string password, Carrito carrito) : base(id, nombre, apellido, dni, mail, password)
        {
            this.carrito = carrito;
        }

        public Carrito Carrito
        {
            get { return carrito; }
            set { carrito = value; }
        }

    }
}
