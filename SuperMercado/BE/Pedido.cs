using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Pedido
    {
        private int id;
        private Producto producto;
        private int cantidad;
        private float precio;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public float Precio
        {
            get
            {
                precio = producto.Precio * cantidad;
                return precio;
            }
        }

        public Pedido(int id, Producto producto, int cantidad)
        {
            this.id = id;
            this.producto = producto;
            this.cantidad = cantidad;
        }
    }
}
