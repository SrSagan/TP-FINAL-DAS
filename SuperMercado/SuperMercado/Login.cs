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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mail = mailInput1.Validar();
                string password = passwordInput1.Validar();
                if(new BLL.Usuario().Validar(mail,password))
                { 
                    ((Form1)this.MdiParent).UserId = new BLL.Usuario().GetByMail(mail).Id;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El usuario o contraseña son incorrectos");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string mail = mailInput1.Validar();
                string password = passwordInput1.Validar();
                if (new BLL.Usuario().Validar(mail, password))
                {
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
