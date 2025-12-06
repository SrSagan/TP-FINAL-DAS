using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMercado
{
    public partial class VisualizarFactura : Form
    {
        private readonly BE.Usuario _usuario;
        private readonly BLL.Usuario _userBLL;
        public VisualizarFactura()
        {
            _userBLL = new BLL.Usuario();
            _usuario = _userBLL.GetInstanceUser();
            InitializeComponent();
            List<BE.Factura> facturas = new BLL.Factura().getFacturasByID(_usuario.Id);
            comboBox1.DataSource = null;
            comboBox1.DataSource = facturas;
            comboBox1.DisplayMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarXML();
        }
        private void GenerarXML()
        {
            new BLL.Factura().GenerarXml();
            MessageBox.Show("XML generado");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BE.Factura factura = (BE.Factura)comboBox1.SelectedItem;
            actualizarDisplay(factura);
        }

        private void actualizarDisplay(BE.Factura factura)
        {
            dataGridView1.Rows.Clear();
            //mercadoGrid.DataSource = productos;
            foreach (BE.Pedido p in factura.Compra.Pedidos)
            {
                dataGridView1.Rows.Add(p.Id, p.Producto.Nombre, p.Cantidad, p.Producto.Precio, p.Precio);
            }

            txtNum.Text = factura.Id.ToString();
            txtNombre.Text = factura.Cliente.Nombre;
            txtApellido.Text = factura.Cliente.Apellido;
            txtMail.Text = factura.Cliente.Mail;
            txtTotal.Text = "$" + factura.PrecioTotal.ToString();
        }
    }
}
