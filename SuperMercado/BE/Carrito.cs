using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Carrito
    {
        private int id;
        private Cliente cliente;
        private List<Producto> productos;

        public int Id
        {
            get { return id; }
        }
        public Cliente Cliente
        { 
            get { return cliente; }
            set { cliente = value; }
        }
        public List<Producto> Productos
        {
            get { return productos; }
            set { productos = value; }
        }
    }
}
