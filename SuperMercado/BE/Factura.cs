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
            set { id = value; }
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
                return precioTotal;
            }
            set { precioTotal = value; }
        }

        public Factura(Usuario cliente, OrdenDeCompra compra)
        {
            this.cliente = cliente;
            this.compra = compra;
        }
        public Factura()
        {

        }
        public string ClienteNombreCompleto
        {
            get
            {
                if (cliente == null) return "";
                return $"{cliente.Nombre} {cliente.Apellido}";
            }
        }
        public string ClienteDni
        {
            get
            {
                if (cliente == null) return "";
                return cliente.Dni.ToString();
            }
        }
        public string ClienteMail
        {
            get
            {
                if (cliente == null) return "";
                return cliente.Mail;
            }
        }
    }
}
