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
        public VisualizarFactura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarXML();
        }
        private void GenerarXML()
        {
            List<BE.Factura> facturas = new BLL.Factura().getFacturas();

            DataTable dt = new DataTable("Factura");

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("UsuarioId", typeof(int));
            dt.Columns.Add("PrecioTotal", typeof(decimal));

            foreach (var fac in facturas)
            {
                DataRow row = dt.NewRow();
                row["Id"] = fac.Id;
                row["UsuarioId"] = fac.Cliente.Id;
                row["PrecioTotal"] = fac.PrecioTotal;
                dt.Rows.Add(row);
            }

            DataSet ds = new DataSet("FacturasDataSet");
            ds.Tables.Add(dt);

            string path = @"D:\Facturas.xml";
            ds.WriteXml(path);

            MessageBox.Show($"XML generado en {path}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("D:\\Facturas.xml");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Factura";
        }
    }
}
