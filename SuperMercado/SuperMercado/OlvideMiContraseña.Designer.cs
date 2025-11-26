namespace SuperMercado
{
    partial class OlvideMiContraseña
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
            this.passwordInput1 = new CustomControls.PasswordInput();
            this.button1 = new System.Windows.Forms.Button();
            this.mailInput1 = new CustomControls.MailInput();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordInput1
            // 
            this.passwordInput1.ErrorColor = System.Drawing.Color.Red;
            this.passwordInput1.LabelText = "Nueva Contraseña";
            this.passwordInput1.Location = new System.Drawing.Point(125, 154);
            this.passwordInput1.Name = "passwordInput1";
            this.passwordInput1.PasswordChar = '*';
            this.passwordInput1.Size = new System.Drawing.Size(373, 30);
            this.passwordInput1.TabIndex = 7;
            this.passwordInput1.TextBoxWidth = 236;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(293, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cambiar Contraseña";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mailInput1
            // 
            this.mailInput1.ErrorColor = System.Drawing.Color.Red;
            this.mailInput1.LabelText = "Email";
            this.mailInput1.Location = new System.Drawing.Point(208, 103);
            this.mailInput1.Name = "mailInput1";
            this.mailInput1.Size = new System.Drawing.Size(290, 30);
            this.mailInput1.TabIndex = 5;
            this.mailInput1.TextBoxWidth = 237;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(293, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 57);
            this.button2.TabIndex = 8;
            this.button2.Text = "Recorde mi contraseña";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cambio de Contraseña";
            // 
            // OlvideMiContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.passwordInput1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mailInput1);
            this.Name = "OlvideMiContraseña";
            this.Text = "OlvideMiContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.PasswordInput passwordInput1;
        private System.Windows.Forms.Button button1;
        private CustomControls.MailInput mailInput1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}