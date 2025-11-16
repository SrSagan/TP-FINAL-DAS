using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class NumberInput : UserControl
    {
        public NumberInput()
        {
            InitializeComponent();
            width = this.Width;
        }
        public NumberInput(System.Windows.Forms.Label label)
        {
            this.label1 = label;
        }

        private int width;
        private System.Windows.Forms.Label label1;

        protected TextBox TxtInput
        {
            get { return txtInput; }
        }

        public System.Windows.Forms.Label Label1
        {
            set { label1 = value; }
            get { return label1; }
        }

        public int TextBoxWidth
        {
            get { return txtInput.Width; }
            set
            {//acomodamos tamaños
                int oldSize = txtInput.Width;
                txtInput.Width = value;
                int offset = txtInput.Width - oldSize;
                Width = Width + offset;
            }
        }

        private Color errorColor = Color.Red;
        public Color ErrorColor
        {
            get { return errorColor; }
            set { errorColor = value; }
        }

        public int Validar()
        {
            return ValidarTexto();
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        protected int ValidarTexto()
        {
            int numero=0;
            if (string.IsNullOrEmpty(txtInput.Text))
            {
                setColorError();
                throw new Exception("Ingresar datos en " + label1.Text);
            }
            else if(int.TryParse(txtInput.Text, out numero))
            { 
                setColorValido();
            }
            return numero;
        }

        public void setColorError()
        {
            label1.ForeColor = errorColor;
        }

        public void setColorValido()
        {
            label1.ForeColor = Color.Black;
        }

        private void WidthChanged(object sender, EventArgs e)
        {
            int offset = this.Width - width;
            txtInput.Width = txtInput.Width + offset;
            width = this.Width;
        }
    }
}
