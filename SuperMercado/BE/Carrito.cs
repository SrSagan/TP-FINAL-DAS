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
        //private Usuario cliente;
        private List<Producto> productos;

        public int Id
        {
            get { return id; }
        }
        /*public Usuario Cliente
        { 
            get { return cliente; }
            set { cliente = value; }
        }*/
        public List<Producto> Productos
        {
            get { return productos; }
            set { productos = value; }
        }

        public Carrito(int id, List<Producto> productos)
        {
            this.id = id;
            Productos = productos;
        }
    }
}
