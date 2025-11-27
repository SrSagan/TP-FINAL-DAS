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
using System.Threading;
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
            try
            {
                string contraseña = Cripto.ComputeSha256Hash(passwordInput1.Validar());
                BE.Usuario usuario = new BE.Usuario(textInput1.Validar(), textInput2.Validar(), numberInput1.Validar(), mailInput1.Validar(), contraseña,0);                    
                if(numberInput1.Validar().ToString().Length != 8)
                {
                    MessageBox.Show("La longitud del DNI es invalida");
                }
                else
                {
                    if (!new BLL.Usuario().ExistsByMail(mailInput1.Validar()) && !new BLL.Usuario().ExistsByDNI(numberInput1.Validar()))
                    {

                        int valor = new BLL.Usuario().Create(usuario);

                        if (valor != 0)
                        {
                            MessageBox.Show("USUARIO CREADO");
                            int id = new BLL.Usuario().GetByMail(mailInput1.Validar()).Id;
                            Form1 form = new Form1(id);
                            form.Show();
                            this.Hide();
                        }

                    }
                    else
                    {
                        if (new BLL.Usuario().ExistsByMail(mailInput1.Validar()))
                        {
                            MessageBox.Show("Ya existe un usuario con ese mail");
                        }
                        else
                        {
                            MessageBox.Show("Ya existe un usuario con ese DNI");
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
