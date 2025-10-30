using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class PasswordInput : TextInput
    {
        public PasswordInput()
        {
            InitializeComponent();
        }

        private int specialCharQ = 1; //cantidad de caracteres especiales
        public int SpecialCharQ
        {
            get { return specialCharQ; }
            set { specialCharQ = value; }
        }

        private int numberCharQ = 1; //cantidad de caracteres numericos
        public int NumberCharQ
        {
            get { return numberCharQ; }
            set { numberCharQ = value; }
        }

        private int charQ = 8; //cantidad de caracteres total
        public int CharQ
        {
            get { return charQ; }
            set { charQ = value; }
        }

        public override string Validar()
        {
            string password = ValidarTexto();
            checkLength(password);
            checkSpecial(password);
            checkNumber(password);
            setColorValido();

            return password;
        }

        private void checkLength(string pass)
        {
            if (pass.Length < charQ)
            {
                setColorError();
                throw new Exception("La contaseña es invalida, se necesitan minimo: " + CharQ.ToString() + " caracteres. (" + (charQ - pass.Length).ToString() + " mas)");
            }
        }

        private void checkSpecial(string pass)
        {
            int specialChar = 0;
            foreach (char c in pass)
            {
                if (!char.IsLetterOrDigit(c)) specialChar++;
            }
            if (specialChar < SpecialCharQ)
            {
                setColorError();
                throw new Exception("La contaseña es invalida, se necesitan minimo: " + specialCharQ.ToString() + " caracteres especiales. (" + (specialCharQ - specialChar).ToString() + " mas)");
            }

        }

        private void checkNumber(string pass)
        {
            int numberChar = 0;
            foreach (char c in pass)
            {
                if (char.IsDigit(c)) numberChar++;
            }
            if(numberChar < numberCharQ)
            {
                setColorError();
                throw new Exception("La contaseña es invalida, se necesitan minimo: " + numberCharQ.ToString() + " numeros. (" + (numberCharQ - numberChar).ToString() + " mas)");
            }
        }
    }
}
