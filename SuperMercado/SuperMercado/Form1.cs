using BE;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }

        private void seleccionarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarProductos ingresar = new IngresarProductos();
            ingresar.MdiParent = this;
            ingresar.Show();
        }

        private void verFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarFactura form = new VisualizarFactura();
            form.MdiParent = this;
            form.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarProductos administrar = new AdministrarProductos();
            administrar.MdiParent = this;
            administrar.Show();
        }

        private void crearCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.MdiParent = this;
            signup.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BLL.Usuario().LogOut();
            Login sign = new Login();
            sign.Show();
            this.Close();
        }
    }
}
