using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private string apellido;
        private int dni;
        private string mail;
        private string password;

        public int Id
        {
            get { return id; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        public string Password
        {
            get { return password; }
        }

    }
}
