using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMercado
{
    public partial class OlvideMiContraseña : Form
    {
        public OlvideMiContraseña()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (new BLL.Usuario().ExistsByMail(mailInput1.Validar()))
                {
                    BE.Usuario usuario = new BLL.Usuario().GetByMail(mailInput1.Validar());
                    string contraseña = Cripto.ComputeSha256Hash(passwordInput1.Validar());
                    int valor = new BLL.Usuario().UpdatePassword(usuario,contraseña);
                    if(valor != 0)
                    {
                        MessageBox.Show("La contraseña fue actualizada");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error cambiando la contraseña");
                    }
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No existe ningun usuario con ese Mail");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
