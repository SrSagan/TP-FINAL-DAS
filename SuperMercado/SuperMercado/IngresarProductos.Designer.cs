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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carritoGrid = new System.Windows.Forms.DataGridView();
            this.idCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberInput1 = new CustomControls.NumberInput();
            this.comprarButton = new System.Windows.Forms.Button();
            this.delbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.mercadoGrid.Location = new System.Drawing.Point(12, 26);
            this.mercadoGrid.MultiSelect = false;
            this.mercadoGrid.Name = "mercadoGrid";
            this.mercadoGrid.Size = new System.Drawing.Size(355, 412);
            this.mercadoGrid.TabIndex = 0;
            this.mercadoGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mercadoGrid_CellClick);
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
            // carritoGrid
            // 
            this.carritoGrid.AllowUserToAddRows = false;
            this.carritoGrid.AllowUserToDeleteRows = false;
            this.carritoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carritoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCarrito,
            this.ProductoCarrito,
            this.StockCarrito,
            this.PrecioCarrito,
            this.Total});
            this.carritoGrid.Location = new System.Drawing.Point(484, 26);
            this.carritoGrid.Name = "carritoGrid";
            this.carritoGrid.Size = new System.Drawing.Size(457, 412);
            this.carritoGrid.TabIndex = 1;
            this.carritoGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carritoGrid_CellClick);
            this.carritoGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.carritoGrid_CellEndEdit);
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
            this.PrecioCarrito.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // buyButton
            // 
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.Location = new System.Drawing.Point(376, 236);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(102, 35);
            this.buyButton.TabIndex = 2;
            this.buyButton.Text = "Sumar";
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
            // numberInput1
            // 
            this.numberInput1.ErrorColor = System.Drawing.Color.Red;
            this.numberInput1.Label1 = this.label1;
            this.numberInput1.Location = new System.Drawing.Point(373, 204);
            this.numberInput1.Name = "numberInput1";
            this.numberInput1.Size = new System.Drawing.Size(105, 26);
            this.numberInput1.TabIndex = 3;
            this.numberInput1.TextBoxWidth = 100;
            // 
            // comprarButton
            // 
            this.comprarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprarButton.Location = new System.Drawing.Point(376, 12);
            this.comprarButton.Name = "comprarButton";
            this.comprarButton.Size = new System.Drawing.Size(102, 35);
            this.comprarButton.TabIndex = 5;
            this.comprarButton.Text = "Comprar";
            this.comprarButton.UseVisualStyleBackColor = true;
            this.comprarButton.Click += new System.EventHandler(this.comprarButton_Click);
            // 
            // delbutton
            // 
            this.delbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbutton.Location = new System.Drawing.Point(376, 403);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(102, 35);
            this.delbutton.TabIndex = 6;
            this.delbutton.Text = "Eliminar";
            this.delbutton.UseVisualStyleBackColor = true;
            this.delbutton.Click += new System.EventHandler(this.delbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mercado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(687, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Carrito";
            // 
            // IngresarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 449);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delbutton);
            this.Controls.Add(this.comprarButton);
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
        private System.Windows.Forms.Button comprarButton;
        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}