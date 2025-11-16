using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class OrdenDeCompra
    {
        private List<Pedido> pedidos;
        private float precioTotal;

        public List<Pedido> Pedidos
        {
            set { pedidos = value; }
            get { return pedidos; }
        }
        
        public float PrecioTotal
        {
            get
            {
                precioTotal = 0;
                foreach(Pedido p in pedidos)
                {
                    precioTotal += p.Precio;
                }
                return precioTotal;
            }
        }

        public OrdenDeCompra(List<Pedido> pedidos)
        {
            this.pedidos = pedidos;
        }
    }
}
