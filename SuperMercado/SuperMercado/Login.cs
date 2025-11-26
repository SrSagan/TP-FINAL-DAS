using BLL;
using CustomControls;
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
                    int id = new BLL.Usuario().GetByMail(mail).Id;
                    Form1 form1 = new Form1(id);
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario o contraseña son incorrectos");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp signUp= new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OlvideMiContraseña olvideMiContraseña = new OlvideMiContraseña();
            olvideMiContraseña.Show();
            this.Hide();
        }
    }
}
