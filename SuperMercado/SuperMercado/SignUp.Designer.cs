namespace SuperMercado
{
    partial class SignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.mailInput1 = new CustomControls.MailInput();
            this.numberInput1 = new CustomControls.NumberInput();
            this.label2 = new System.Windows.Forms.Label();
            this.textInput1 = new CustomControls.TextInput();
            this.textInput2 = new CustomControls.TextInput();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordInput1
            // 
            this.passwordInput1.ErrorColor = System.Drawing.Color.Red;
            this.passwordInput1.LabelText = "Contraseña";
            this.passwordInput1.Location = new System.Drawing.Point(30, 134);
            this.passwordInput1.Name = "passwordInput1";
            this.passwordInput1.PasswordChar = '*';
            this.passwordInput1.Size = new System.Drawing.Size(328, 30);
            this.passwordInput1.TabIndex = 1;
            this.passwordInput1.TextBoxWidth = 236;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(159, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "BIENVENIDO";
            // 
            // mailInput1
            // 
            this.mailInput1.ErrorColor = System.Drawing.Color.Red;
            this.mailInput1.LabelText = "Email";
            this.mailInput1.Location = new System.Drawing.Point(68, 87);
            this.mailInput1.Name = "mailInput1";
            this.mailInput1.Size = new System.Drawing.Size(290, 30);
            this.mailInput1.TabIndex = 0;
            this.mailInput1.TextBoxWidth = 237;
            // 
            // numberInput1
            // 
            this.numberInput1.ErrorColor = System.Drawing.Color.Red;
            this.numberInput1.Label1 = this.label2;
            this.numberInput1.Location = new System.Drawing.Point(112, 181);
            this.numberInput1.Name = "numberInput1";
            this.numberInput1.Size = new System.Drawing.Size(218, 26);
            this.numberInput1.TabIndex = 2;
            this.numberInput1.TextBoxWidth = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(64, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "DNI";
            // 
            // textInput1
            // 
            this.textInput1.ErrorColor = System.Drawing.Color.Red;
            this.textInput1.LabelText = "Nombre";
            this.textInput1.Location = new System.Drawing.Point(53, 231);
            this.textInput1.Name = "textInput1";
            this.textInput1.Size = new System.Drawing.Size(305, 30);
            this.textInput1.TabIndex = 3;
            this.textInput1.TextBoxWidth = 236;
            // 
            // textInput2
            // 
            this.textInput2.ErrorColor = System.Drawing.Color.Red;
            this.textInput2.LabelText = "Apellido";
            this.textInput2.Location = new System.Drawing.Point(53, 279);
            this.textInput2.Name = "textInput2";
            this.textInput2.Size = new System.Drawing.Size(305, 30);
            this.textInput2.TabIndex = 4;
            this.textInput2.TextBoxWidth = 236;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(128, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ya tengo una cuenta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 433);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textInput2);
            this.Controls.Add(this.textInput1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberInput1);
            this.Controls.Add(this.passwordInput1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mailInput1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.PasswordInput passwordInput1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private CustomControls.MailInput mailInput1;
        private CustomControls.NumberInput numberInput1;
        private System.Windows.Forms.Label label2;
        private CustomControls.TextInput textInput1;
        private CustomControls.TextInput textInput2;
        private System.Windows.Forms.Button button2;
    }
}