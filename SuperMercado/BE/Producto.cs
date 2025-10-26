using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto
    {
        private int id;
        private string nombre;
        private float precio;

        public int Id
        {
            get { return id; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
