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
    public partial class AdministrarUsuarios : Form
    {
        private readonly BE.Usuario _usuario;
        private readonly BLL.Usuario _userBLL;
        public AdministrarUsuarios()
        {
            _userBLL = new BLL.Usuario();
            _usuario = _userBLL.GetInstanceUser();
            InitializeComponent();            
            comboBox1.Items.Add(new { Texto = "Comprador"});
            comboBox1.Items.Add(new { Texto = "Administrador"});
            comboBox1.Items.Add(new { Texto = "SuperAdministrador"});

            comboBox1.DisplayMember = "Texto";
            actualizarDataGrid();
        }
        private void actualizarDataGrid()
        {
            List<BE.Usuario> usuarios = new List<BE.Usuario>();
            usuarios = new BLL.Usuario().GetUsuarios();
            dataGridView1.DataSource = usuarios;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("No hay usuario seleccionado.");
                return;
            }
            BE.Usuario usuarioSeleccionado = (BE.Usuario)dataGridView1.CurrentRow.DataBoundItem;
            if(usuarioSeleccionado.Id == _usuario.Id)
            {
                MessageBox.Show("No puede actualizar su propio usuario");
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un rol");
                return;
            }
            usuarioSeleccionado.Familia = comboBox1.SelectedIndex;
            int valor = new BLL.Usuario().UpdateUser(usuarioSeleccionado);
            if(valor != 0)
            {
                MessageBox.Show($"El usuario {usuarioSeleccionado.Nombre} fue actualizado");
            }
            actualizarDataGrid();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            BE.Usuario u = (BE.Usuario)dataGridView1.CurrentRow.DataBoundItem;
            comboBox1.SelectedIndex = u.Familia;
        }
    }
}
