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
        private List<BE.Producto> productos = new BLL.Producto().getProductos();
        public IngresarProductos(int userId)
        {
            InitializeComponent();
            numberInput1.Label1 = label1;
            factura.Cliente = new BLL.Usuario().GetById(userId);
            actualizarStock();
        }

        private void actualizarStock()
        {
            mercadoGrid.Rows.Clear();
            //mercadoGrid.DataSource = productos;
            foreach(BE.Producto p in productos)
            {
                mercadoGrid.Rows.Add(p.Id, p.Nombre, p.Stock, p.Precio);
            }
            mercadoGrid.Rows[0].Selected = true;
        }

        private void actualizarCarrito()
        {
            carritoGrid.Rows.Clear();
            float total = 0;
            foreach(BE.Pedido p in factura.Compra.Pedidos)
            {
                carritoGrid.Rows.Add(p.Id, p.Producto.Nombre, p.Cantidad, p.Precio);
                total += p.Precio;
            }
            carritoGrid.Rows.Add("-", "-", "-", "-",  total); //row de total
            carritoGrid.Rows[0].Selected = true; //selecciono la primera
            carritoGrid.Rows[carritoGrid.Rows.Count - 1].ReadOnly = true; //el row de total tiene que ser readonly
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadComprar = numberInput1.Validar(); //validamos que la cantidad sea menor a la cantidad
                int stock = int.Parse(mercadoGrid.SelectedRows[0].Cells[2].Value.ToString());

                if (stock < cantidadComprar) throw new Exception("La cantidad supera el stock disponible");

                int id = int.Parse(mercadoGrid.SelectedRows[0].Cells[0].Value.ToString());
                BE.Producto producto = productos.Where(p => p.Id == id).First();

                if (factura.Compra.Pedidos.Exists(p=> p.Producto.Id == id))
                {
                    BE.Pedido ped = factura.Compra.Pedidos.Where(p => p.Producto.Id == id).First();
                    ped.Cantidad += cantidadComprar;
                }
                else
                {
                    BE.Pedido pedido = new BE.Pedido(producto, cantidadComprar);
                    factura.Compra.Pedidos.Add(pedido);
                }

                producto.Stock -= cantidadComprar;

                actualizarCarrito();
                actualizarStock();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void mercadoGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelected = mercadoGrid.SelectedCells[0].RowIndex;
            mercadoGrid.Rows[rowSelected].Selected = true;
        }

        private void carritoGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(carritoGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            BE.Pedido ped = factura.Compra.Pedidos.Where(p => p.Id == id).First();
            ped.Cantidad = int.Parse(carritoGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
            actualizarCarrito();
        }

        private void carritoGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelected = carritoGrid.SelectedCells[0].RowIndex;
            if(rowSelected == carritoGrid.Rows.Count-1)
            {
                rowSelected -= 1;
            }
            carritoGrid.SelectedCells[0].Selected = false;
            carritoGrid.Rows[rowSelected].Selected = true;
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(carritoGrid.SelectedRows[0].Cells[0].Value.ToString());
            BE.Pedido ped = factura.Compra.Pedidos.Where(p => p.Id == id).First();
            factura.Compra.Pedidos.Remove(ped);
            actualizarCarrito();
        }

        private void comprarButton_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("¿Esta seguro que quiere terminar la compra?", "Terminar compra", MessageBoxButtons.YesNo);
            if(a == DialogResult.Yes)
            {
                foreach(BE.Pedido pedido in factura.Compra.Pedidos)
                {
                    factura.PrecioTotal += pedido.Precio;
                }
                new BLL.Factura().Create(factura);
                factura.Id = new BLL.Factura().GetLast().Id;

                BLL.Pedido pedidoAdmin = new BLL.Pedido();
                BLL.Producto productoAdmin = new BLL.Producto();
                foreach (BE.Pedido p in factura.Compra.Pedidos)
                {
                    pedidoAdmin.Create(p, factura.Id).ToString();
                }
                foreach (BE.Producto p in productos)
                {
                    productoAdmin.Update(p);
                }
                this.Close();
            }
        }
    }
}
