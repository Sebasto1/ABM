namespace ABM
{
    partial class FormCrearProductoVendido
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
            btnSave = new Button();
            txtIdProducto = new TextBox();
            txtStock = new TextBox();
            lblStock = new Label();
            lblIdProducto = new Label();
            txtIdVenta = new TextBox();
            lblIdVenta = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(623, 205);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 41;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(60, 121);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(150, 31);
            txtIdProducto.TabIndex = 38;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(60, 233);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 31);
            txtStock.TabIndex = 37;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = SystemColors.Control;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.Location = new Point(99, 179);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(59, 25);
            lblStock.TabIndex = 34;
            lblStock.Text = "Stock";
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.BackColor = SystemColors.Control;
            lblIdProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdProducto.Location = new Point(75, 71);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(114, 25);
            lblIdProducto.TabIndex = 33;
            lblIdProducto.Text = "ID Producto";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(325, 230);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(150, 31);
            txtIdVenta.TabIndex = 43;
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.BackColor = SystemColors.Control;
            lblIdVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdVenta.Location = new Point(325, 190);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(85, 25);
            lblIdVenta.TabIndex = 42;
            lblIdVenta.Text = "ID Venta";
            // 
            // FormCrearProductoVendido
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIdVenta);
            Controls.Add(lblIdVenta);
            Controls.Add(btnSave);
            Controls.Add(txtIdProducto);
            Controls.Add(txtStock);
            Controls.Add(lblStock);
            Controls.Add(lblIdProducto);
            Name = "FormCrearProductoVendido";
            Text = "FormCrearProductoVendido";
            Load += FormCrearProductoVendido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtIdProducto;
        private TextBox txtStock;
        private Label lblStock;
        private Label lblIdProducto;
        private TextBox txtIdVenta;
        private Label lblIdVenta;
    }
}