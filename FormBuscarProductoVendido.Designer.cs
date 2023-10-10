namespace ABM
{
    partial class FormBuscarProductoVendido
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
            btnEliminar = new Button();
            btnBuscar = new Button();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            txtId = new TextBox();
            txtIdVenta = new TextBox();
            txtIdProducto = new TextBox();
            txtStock = new TextBox();
            lblIdVenta = new Label();
            lblId = new Label();
            lblStock = new Label();
            lblIdProducto = new Label();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(544, 335);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 49;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Location = new Point(544, 253);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 48;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBuscar.Location = new Point(550, 156);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(106, 25);
            lblBuscar.TabIndex = 47;
            lblBuscar.Text = "Ingresar ID";
            lblBuscar.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(447, 197);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(302, 31);
            txtBuscar.TabIndex = 46;
            // 
            // txtId
            // 
            txtId.Location = new Point(53, 95);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 57;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(321, 95);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(150, 31);
            txtIdVenta.TabIndex = 56;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(53, 200);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(150, 31);
            txtIdProducto.TabIndex = 55;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(53, 312);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 31);
            txtStock.TabIndex = 54;
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.BackColor = SystemColors.Control;
            lblIdVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdVenta.Location = new Point(321, 55);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(85, 25);
            lblIdVenta.TabIndex = 53;
            lblIdVenta.Text = "ID Venta";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = SystemColors.Control;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(77, 55);
            lblId.Name = "lblId";
            lblId.Size = new Size(31, 25);
            lblId.TabIndex = 52;
            lblId.Text = "ID";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = SystemColors.Control;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.Location = new Point(92, 258);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(59, 25);
            lblStock.TabIndex = 51;
            lblStock.Text = "Stock";
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.BackColor = SystemColors.Control;
            lblIdProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdProducto.Location = new Point(92, 156);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(114, 25);
            lblIdProducto.TabIndex = 50;
            lblIdProducto.Text = "ID Producto";
            // 
            // FormBuscarProductoVendido
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtId);
            Controls.Add(txtIdVenta);
            Controls.Add(txtIdProducto);
            Controls.Add(txtStock);
            Controls.Add(lblIdVenta);
            Controls.Add(lblId);
            Controls.Add(lblStock);
            Controls.Add(lblIdProducto);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Name = "FormBuscarProductoVendido";
            Text = "FormBuscarProductoVendido";
            Load += FormBuscarProductoVendido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnBuscar;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private TextBox txtId;
        private TextBox txtIdVenta;
        private TextBox txtIdProducto;
        private TextBox txtStock;
        private Label lblIdVenta;
        private Label lblId;
        private Label lblStock;
        private Label lblIdProducto;
    }
}