namespace ABM
{
    partial class FormModificarProducto
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
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(623, 205);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 21;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(66, 121);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(150, 31);
            txtDescripcion.TabIndex = 20;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(334, 121);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(150, 31);
            txtPrecioVenta.TabIndex = 19;
            // 
            // txtIDUsuario
            // 
            txtIDUsuario.Location = new Point(334, 329);
            txtIDUsuario.Name = "txtIDUsuario";
            txtIDUsuario.Size = new Size(150, 31);
            txtIDUsuario.TabIndex = 18;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(66, 226);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(150, 31);
            txtCosto.TabIndex = 17;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(66, 338);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 31);
            txtStock.TabIndex = 16;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.BackColor = SystemColors.Control;
            lblPrecioVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioVenta.Location = new Point(334, 81);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(145, 25);
            lblPrecioVenta.TabIndex = 15;
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
            lblDescripcion.TabIndex = 14;
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
            lblStock.TabIndex = 13;
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
            lblCosto.TabIndex = 12;
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
            lblIDUsuario.TabIndex = 11;
            lblIDUsuario.Text = "ID Usuario";
            // 
            // FormModificarProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
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
            Name = "FormModificarProducto";
            Text = "FormModificarProducto";
            Load += FormModificarProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
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
    }
}