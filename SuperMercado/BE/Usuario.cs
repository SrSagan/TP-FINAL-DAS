using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        private readonly int id;
        private string nombre;
        private string apellido;
        private int dni;
        private string mail;
        private readonly string password; //hash
        private int familia;

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

        public int Familia
        {
            set { familia = value; }
            get { return familia; }
        }

        public Usuario(int id, string nombre, string apellido, int dni, string mail, string password, int familia)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.mail = mail;
            this.password = password;
            this.familia = familia;
        }
    }
}
