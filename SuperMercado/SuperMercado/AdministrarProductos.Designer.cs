namespace SuperMercado
{
    partial class AdministrarProductos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textInput1 = new CustomControls.TextInput();
            this.numberInput1 = new CustomControls.NumberInput();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numberInput2 = new CustomControls.NumberInput();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // textInput1
            // 
            this.textInput1.ErrorColor = System.Drawing.Color.Red;
            this.textInput1.LabelText = "Nombre";
            this.textInput1.Location = new System.Drawing.Point(567, 26);
            this.textInput1.Name = "textInput1";
            this.textInput1.Size = new System.Drawing.Size(228, 30);
            this.textInput1.TabIndex = 1;
            this.textInput1.TextBoxWidth = 159;
            // 
            // numberInput1
            // 
            this.numberInput1.ErrorColor = System.Drawing.Color.Red;
            this.numberInput1.Label1 = this.label1;
            this.numberInput1.Location = new System.Drawing.Point(679, 98);
            this.numberInput1.Name = "numberInput1";
            this.numberInput1.Size = new System.Drawing.Size(109, 26);
            this.numberInput1.TabIndex = 3;
            this.numberInput1.TextBoxWidth = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(630, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stock";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numberInput2
            // 
            this.numberInput2.ErrorColor = System.Drawing.Color.Red;
            this.numberInput2.Label1 = this.label2;
            this.numberInput2.Location = new System.Drawing.Point(679, 62);
            this.numberInput2.Name = "numberInput2";
            this.numberInput2.Size = new System.Drawing.Size(105, 26);
            this.numberInput2.TabIndex = 6;
            this.numberInput2.TextBoxWidth = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(630, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precio";
            // 
            // AdministrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberInput2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberInput1);
            this.Controls.Add(this.textInput1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdministrarProductos";
            this.Text = "AdministrarProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControls.TextInput textInput1;
        private CustomControls.NumberInput numberInput1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private CustomControls.NumberInput numberInput2;
        private System.Windows.Forms.Label label2;
    }
}