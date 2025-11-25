using BE;
using BLL;
using CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMercado
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contraseña = Cripto.ComputeSha256Hash(passwordInput1.Validar());
            Console.WriteLine(contraseña);
            BE.Usuario usuario = new BE.Usuario(textInput1.Validar(), textInput2.Validar(), numberInput1.Validar(), mailInput1.Validar(), contraseña,0);
            int valor = new BLL.Usuario().Create(usuario);
            if(valor != 0 )
            {
                MessageBox.Show("USUARIO CREADO");
                this.Close();
            }
        }
    }
}
