﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class MailInput : TextInput
    {
        public MailInput()
        {
            InitializeComponent();
        }

        public new string Validar()
        {
            string email = ValidarTexto();
            if (!email.Contains("@"))
            {
                setColorError();
                throw new Exception("El email es invalido");
            }
            setColorValido();
            return email;
        }
    }
}
