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
        public IngresarProductos()
        {
            InitializeComponent();
            numberInput1.Label1 = label1;
            actualizarStock();
        }

        private void actualizarStock()
        {
            List<BE.Producto> productos =  new Producto().getProductos();
            foreach(BE.Producto p in productos)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells[0].Value = p.Id;
                row.Cells[1].Value = p.Nombre;
                row.Cells[2].Value = p.Precio;
                row.Cells[3].Value = p.Stock;

                mercadoGrid.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadComprar = numberInput1.Validar(); //validamos que la cantidad sea menor a la cantidad
                int stock = int.Parse(mercadoGrid.SelectedRows[0].Cells[0].Value.ToString());

                if (stock > cantidadComprar) throw new Exception("La cantidad supera el stock disponible");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
