using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace SuperMercado
{
    public partial class IngresarProductos : Form
    {
        private BE.Factura factura = new BE.Factura(new BE.Usuario(), new BE.OrdenDeCompra());
        public IngresarProductos()
        {
            InitializeComponent();
            numberInput1.Label1 = label1;
            actualizarStock();
        }

        private void actualizarStock()
        {
            List<BE.Producto> productos =  new Producto().getProductos();
            //mercadoGrid.DataSource = productos;
            foreach(BE.Producto p in productos)
            {
                mercadoGrid.Rows.Add(p.Id, p.Nombre, p.Stock, p.Precio);
            }
        }

        private void actualizarCarrito()
        {
            carritoGrid.Rows.Clear();
            foreach(BE.Pedido p in factura.Compra.Pedidos)
            {
                carritoGrid.Rows.Add(p.Id, p.Producto.Nombre, p.Cantidad, p.Precio);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadComprar = numberInput1.Validar(); //validamos que la cantidad sea menor a la cantidad
                int stock = int.Parse(mercadoGrid.SelectedRows[0].Cells[2].Value.ToString());

                if (stock < cantidadComprar) throw new Exception("La cantidad supera el stock disponible");

                int id = int.Parse(mercadoGrid.SelectedRows[0].Cells[0].Value.ToString());

                BE.Producto producto = new BLL.Producto().GetById(id);
                BE.Pedido pedido = new BE.Pedido(producto, cantidadComprar);
                factura.Compra.Pedidos.Add(pedido);
                actualizarCarrito();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void mercadoGrid_SelectionChanged(object sender, EventArgs e)
        {
            int rowSelected = mercadoGrid.SelectedCells[0].RowIndex;
            mercadoGrid.Rows[rowSelected].Selected = true;
        }
    }
}
