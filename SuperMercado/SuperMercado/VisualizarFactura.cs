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

            DataSet ds = new DataSet("FacturasDataSet");

            DataTable dtFactura = new DataTable("Factura");
            dtFactura.Columns.Add("Id", typeof(int));
            dtFactura.Columns.Add("UsuarioNombre", typeof(string));
            dtFactura.Columns.Add("Mail", typeof(string));
            dtFactura.Columns.Add("DNI", typeof(int));
            dtFactura.Columns.Add("PrecioTotal", typeof(float));

            DataTable dtPedidos = new DataTable("Pedido");
            dtPedidos.Columns.Add("FacturaId", typeof(int));
            dtPedidos.Columns.Add("ProductoNombre", typeof(string));
            dtPedidos.Columns.Add("Cantidad", typeof(int));
            dtPedidos.Columns.Add("Precio", typeof(float));

            foreach (var fac in facturas)
            {
                DataRow rowF = dtFactura.NewRow();
                rowF["Id"] = fac.Id;
                rowF["UsuarioNombre"] = fac.Cliente.Nombre + " " + fac.Cliente.Apellido;
                rowF["Mail"] = fac.Cliente.Mail;
                rowF["DNI"] = (int)fac.Cliente.Dni;
                rowF["PrecioTotal"] = fac.PrecioTotal;
                dtFactura.Rows.Add(rowF);
                List<BE.Pedido> pedidos = new BLL.Pedido().GetPedidosByFacId(fac.Id);

                foreach (var pedido in pedidos)
                {
                    DataRow rowP = dtPedidos.NewRow();
                    rowP["FacturaId"] = fac.Id;
                    rowP["ProductoNombre"] = pedido.Producto.Nombre;
                    rowP["Cantidad"] = pedido.Cantidad;
                    rowP["Precio"] = pedido.Precio;
                    dtPedidos.Rows.Add(rowP);
                }
            }

            ds.Tables.Add(dtFactura);
            ds.Tables.Add(dtPedidos);

            string path = @"D:\Facturas.xml";
            ds.WriteXml(path);

            MessageBox.Show($"XML generado en {path}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("D:\\Facturas.xml");

            DataTable facturas = ds.Tables["Factura"];
            DataTable pedidos = ds.Tables["Pedido"];

            // Tabla combinada final
            DataTable dtFinal = new DataTable();
            dtFinal.Columns.Add("FacturaId", typeof(int));
            dtFinal.Columns.Add("Cliente", typeof(string));
            dtFinal.Columns.Add("Mail",typeof(string));
            dtFinal.Columns.Add("DNI",typeof(string));
            dtFinal.Columns.Add("Producto", typeof(string));
            dtFinal.Columns.Add("Cantidad", typeof(int));
            dtFinal.Columns.Add("Precio", typeof(float));
            dtFinal.Columns.Add("TotalFactura", typeof(float));
            foreach (DataRow fac in facturas.Rows)
            {
                int id = Convert.ToInt32(fac["Id"]);
                string cliente = fac["UsuarioNombre"].ToString();
                float total = Convert.ToSingle(fac["PrecioTotal"]);

                // Filtrar pedidos correspondientes a esta factura
                DataRow[] pedidosFiltrados = pedidos.Select($"FacturaId = {id}");

                foreach (DataRow ped in pedidosFiltrados)
                {
                    DataRow row = dtFinal.NewRow();
                    row["FacturaId"] = id;
                    row["Mail"] = fac["Mail"];
                    row["DNI"] = fac["DNI"];
                    row["Cliente"] = cliente;
                    row["Producto"] = ped["ProductoNombre"];
                    row["Cantidad"] = ped["Cantidad"];
                    row["Precio"] = ped["Precio"];
                    row["TotalFactura"] = total;
                    dtFinal.Rows.Add(row);
                }
            }

            dataGridView1.DataSource = dtFinal;
        }

    }
}
