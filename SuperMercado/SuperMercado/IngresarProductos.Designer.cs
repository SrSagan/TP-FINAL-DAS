namespace SuperMercado
{
    partial class IngresarProductos
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
            this.mercadoGrid = new System.Windows.Forms.DataGridView();
            this.carritoGrid = new System.Windows.Forms.DataGridView();
            this.buyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberInput1 = new CustomControls.NumberInput();
            ((System.ComponentModel.ISupportInitialize)(this.mercadoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carritoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mercadoGrid
            // 
            this.mercadoGrid.AllowUserToAddRows = false;
            this.mercadoGrid.AllowUserToDeleteRows = false;
            this.mercadoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mercadoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Producto,
            this.Stock,
            this.Precio});
            this.mercadoGrid.Location = new System.Drawing.Point(12, 12);
            this.mercadoGrid.Name = "mercadoGrid";
            this.mercadoGrid.Size = new System.Drawing.Size(355, 426);
            this.mercadoGrid.TabIndex = 0;
            // 
            // carritoGrid
            // 
            this.carritoGrid.AllowUserToAddRows = false;
            this.carritoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carritoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCarrito,
            this.ProductoCarrito,
            this.StockCarrito,
            this.PrecioCarrito,
            this.Total});
            this.carritoGrid.Location = new System.Drawing.Point(484, 12);
            this.carritoGrid.Name = "carritoGrid";
            this.carritoGrid.Size = new System.Drawing.Size(457, 426);
            this.carritoGrid.TabIndex = 1;
            // 
            // buyButton
            // 
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.Location = new System.Drawing.Point(374, 333);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(102, 35);
            this.buyButton.TabIndex = 2;
            this.buyButton.Text = "Comprar";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // idCarrito
            // 
            this.idCarrito.HeaderText = "id";
            this.idCarrito.Name = "idCarrito";
            this.idCarrito.ReadOnly = true;
            this.idCarrito.Visible = false;
            // 
            // ProductoCarrito
            // 
            this.ProductoCarrito.HeaderText = "Producto";
            this.ProductoCarrito.Name = "ProductoCarrito";
            this.ProductoCarrito.ReadOnly = true;
            // 
            // StockCarrito
            // 
            this.StockCarrito.HeaderText = "Cantidad";
            this.StockCarrito.Name = "StockCarrito";
            // 
            // PrecioCarrito
            // 
            this.PrecioCarrito.HeaderText = "Precio";
            this.PrecioCarrito.Name = "PrecioCarrito";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // numberInput1
            // 
            this.numberInput1.ErrorColor = System.Drawing.Color.Red;
            this.numberInput1.Label1 = null;
            this.numberInput1.Location = new System.Drawing.Point(373, 204);
            this.numberInput1.Name = "numberInput1";
            this.numberInput1.Size = new System.Drawing.Size(105, 26);
            this.numberInput1.TabIndex = 3;
            this.numberInput1.TextBoxWidth = 100;
            // 
            // IngresarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberInput1);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.carritoGrid);
            this.Controls.Add(this.mercadoGrid);
            this.Name = "IngresarProductos";
            this.Text = "IngresarProductos";
            ((System.ComponentModel.ISupportInitialize)(this.mercadoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carritoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mercadoGrid;
        private System.Windows.Forms.DataGridView carritoGrid;
        private System.Windows.Forms.Button buyButton;
        private CustomControls.NumberInput numberInput1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}