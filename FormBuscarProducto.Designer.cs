namespace ABM
{
    partial class FormBuscarProducto
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
            txtDescripcion = new TextBox();
            txtPrecioVenta = new TextBox();
            txtIDUsuario = new TextBox();
            txtCosto = new TextBox();
            txtStock = new TextBox();
            lblPrecioVenta = new Label();
            lblDescripcion = new Label();
            lblStock = new Label();
            lblCosto = new Label();
            lblIDUsuario = new Label();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            btnBuscar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(66, 121);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(150, 31);
            txtDescripcion.TabIndex = 31;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Enabled = false;
            txtPrecioVenta.Location = new Point(334, 121);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(150, 31);
            txtPrecioVenta.TabIndex = 30;
            // 
            // txtIDUsuario
            // 
            txtIDUsuario.Enabled = false;
            txtIDUsuario.Location = new Point(334, 329);
            txtIDUsuario.Name = "txtIDUsuario";
            txtIDUsuario.Size = new Size(150, 31);
            txtIDUsuario.TabIndex = 29;
            // 
            // txtCosto
            // 
            txtCosto.Enabled = false;
            txtCosto.Location = new Point(66, 226);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(150, 31);
            txtCosto.TabIndex = 28;
            txtCosto.TextChanged += txtCosto_TextChanged;
            // 
            // txtStock
            // 
            txtStock.Enabled = false;
            txtStock.Location = new Point(66, 338);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 31);
            txtStock.TabIndex = 27;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.BackColor = SystemColors.Control;
            lblPrecioVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioVenta.Location = new Point(334, 81);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(145, 25);
            lblPrecioVenta.TabIndex = 26;
            lblPrecioVenta.Text = "Precio de Venta";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = SystemColors.Control;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(90, 81);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(111, 25);
            lblDescripcion.TabIndex = 25;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = SystemColors.Control;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.Location = new Point(105, 284);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(59, 25);
            lblStock.TabIndex = 24;
            lblStock.Text = "Stock";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.BackColor = SystemColors.Control;
            lblCosto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCosto.Location = new Point(105, 182);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(60, 25);
            lblCosto.TabIndex = 23;
            lblCosto.Text = "Costo";
            // 
            // lblIDUsuario
            // 
            lblIDUsuario.AutoSize = true;
            lblIDUsuario.BackColor = SystemColors.Control;
            lblIDUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIDUsuario.ForeColor = SystemColors.ActiveCaptionText;
            lblIDUsuario.Location = new Point(357, 284);
            lblIDUsuario.Name = "lblIDUsuario";
            lblIDUsuario.Size = new Size(101, 25);
            lblIDUsuario.TabIndex = 22;
            lblIDUsuario.Text = "ID Usuario";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(462, 197);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(302, 31);
            txtBuscar.TabIndex = 32;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBuscar.Location = new Point(565, 156);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(106, 25);
            lblBuscar.TabIndex = 33;
            lblBuscar.Text = "Ingresar ID";
            lblBuscar.TextAlign = ContentAlignment.TopCenter;
            lblBuscar.Click += lblBuscar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Location = new Point(559, 253);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 34;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(559, 335);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 35;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormBuscarProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtIDUsuario);
            Controls.Add(txtCosto);
            Controls.Add(txtStock);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblDescripcion);
            Controls.Add(lblStock);
            Controls.Add(lblCosto);
            Controls.Add(lblIDUsuario);
            Name = "FormBuscarProducto";
            Text = "Buscar Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private TextBox txtPrecioVenta;
        private TextBox txtIDUsuario;
        private TextBox txtCosto;
        private TextBox txtStock;
        private Label lblPrecioVenta;
        private Label lblDescripcion;
        private Label lblStock;
        private Label lblCosto;
        private Label lblIDUsuario;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Button btnBuscar;
        private Button btnEliminar;
    }
}