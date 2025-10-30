namespace SuperMercado
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.passwordInput1 = new CustomControls.PasswordInput();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Probar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordInput1
            // 
            this.passwordInput1.CharQ = 8;
            this.passwordInput1.ErrorColor = System.Drawing.Color.Red;
            this.passwordInput1.LabelText = "Contraseña";
            this.passwordInput1.Location = new System.Drawing.Point(12, 31);
            this.passwordInput1.Name = "passwordInput1";
            this.passwordInput1.NumberCharQ = 1;
            this.passwordInput1.Size = new System.Drawing.Size(328, 30);
            this.passwordInput1.SpecialCharQ = 10;
            this.passwordInput1.TabIndex = 2;
            this.passwordInput1.TextBoxWidth = 236;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordInput1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.TextInput textInput1;
        private System.Windows.Forms.Button button1;
        private CustomControls.PasswordInput passwordInput1;
    }
}

