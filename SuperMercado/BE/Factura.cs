using System.Collections.Generic;

namespace BE
{
    public class Factura
    {
        private int id;
        private Usuario cliente;
        private OrdenDeCompra compra;
        private float precioTotal;

        public int Id
        {
            get { return id; }
        }
        public Usuario Cliente
        { 
            get { return cliente; }
            set { cliente = value; }
        }
        public OrdenDeCompra Compra
        {
            get { return compra; }
            set { compra = value; }
        }

        public float PrecioTotal
        {
            get
            {
                precioTotal = compra.PrecioTotal;
                return precioTotal;
            }
        }

        public Factura(int id, Usuario cliente, OrdenDeCompra compra, float precioTotal)
        {
            this.id = id;
            this.cliente = cliente;
            this.compra = compra;
            this.precioTotal = precioTotal;
        }
    }
}
