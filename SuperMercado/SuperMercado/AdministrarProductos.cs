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
    public partial class AdministrarProductos : Form
    {
        public AdministrarProductos()
        {
            InitializeComponent();
            actualizarDataGrid();
        }

        private void actualizarDataGrid()
        {
            List<BE.Producto> productos = new List<BE.Producto>();
            productos = new BLL.Producto().getProductos();
            dataGridView1.DataSource = productos;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BE.Producto p = new BE.Producto(
                    textInput1.Validar(),
                    (float)numberInput2.Validar(),
                    numberInput1.Validar()
                );
                new BLL.Producto().Create(p);
                
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            actualizarDataGrid();
        }
    }
}
