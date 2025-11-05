using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace CustomControls
{
    public partial class TextInput: UserControl
    {
        public TextInput()
        {
            InitializeComponent();
            width = this.Width;
        }
        private int width;
        protected TextBox TxtInput
        {
            get { return txtInput; }
        }
        
        protected Label Label
        {
            get { return label1; }
        }

        public string LabelText
        {
            get { return label1.Text; }
            set
            {
                int oldSize = label1.Width;
                label1.Text = value;
                int offset = label1.Width - oldSize;
                //acomodamos todo basado al tamaño del label
                Width = Width + offset; //expandimos el cuadro
                txtInput.Location = new Point(txtInput.Location.X + offset, txtInput.Location.Y); //alejamos al textbox
                txtInput.Width = txtInput.Width - offset;
            }
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

        public string Validar()
        {
            return ValidarTexto();
        }

        protected string ValidarTexto()
        {
            if (string.IsNullOrEmpty(txtInput.Text))
            {
                setColorError();
                throw new Exception("Ingresar datos en " + label1.Text);
            }
            else
            {
                setColorValido();
            }
            return txtInput.Text;
        }

        protected void setColorError()
        {
            label1.ForeColor = errorColor;
        }

        protected void setColorValido()
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
