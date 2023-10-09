namespace ABM
{
    partial class Form2
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
            lblIDUsuario = new Label();
            lblCosto = new Label();
            lblStock = new Label();
            lblDescripcion = new Label();
            lblPrecioVenta = new Label();
            txtStock = new TextBox();
            txtCosto = new TextBox();
            txtIDUsuario = new TextBox();
            txtPrecioVenta = new TextBox();
            txtDescripcion = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblIDUsuario
            // 
            lblIDUsuario.AutoSize = true;
            lblIDUsuario.BackColor = SystemColors.Control;
            lblIDUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIDUsuario.ForeColor = SystemColors.ActiveCaptionText;
            lblIDUsuario.Location = new Point(326, 261);
            lblIDUsuario.Name = "lblIDUsuario";
            lblIDUsuario.Size = new Size(101, 25);
            lblIDUsuario.TabIndex = 0;
            lblIDUsuario.Text = "ID Usuario";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.BackColor = SystemColors.Control;
            lblCosto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCosto.Location = new Point(74, 159);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(60, 25);
            lblCosto.TabIndex = 1;
            lblCosto.Text = "Costo";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = SystemColors.Control;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.Location = new Point(74, 261);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(59, 25);
            lblStock.TabIndex = 2;
            lblStock.Text = "Stock";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = SystemColors.Control;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(59, 58);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(111, 25);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.BackColor = SystemColors.Control;
            lblPrecioVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioVenta.Location = new Point(303, 58);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(145, 25);
            lblPrecioVenta.TabIndex = 4;
            lblPrecioVenta.Text = "Precio de Venta";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(35, 315);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 31);
            txtStock.TabIndex = 5;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(35, 203);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(150, 31);
            txtCosto.TabIndex = 6;
            // 
            // txtIDUsuario
            // 
            txtIDUsuario.Location = new Point(303, 306);
            txtIDUsuario.Name = "txtIDUsuario";
            txtIDUsuario.Size = new Size(150, 31);
            txtIDUsuario.TabIndex = 7;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(303, 98);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(150, 31);
            txtPrecioVenta.TabIndex = 8;
            txtPrecioVenta.TextChanged += txtPrecioVenta_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(35, 98);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(150, 31);
            txtDescripcion.TabIndex = 9;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(592, 182);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 10;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
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
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIDUsuario;
        private Label lblCosto;
        private Label lblStock;
        private Label lblDescripcion;
        private Label lblPrecioVenta;
        private TextBox txtStock;
        private TextBox txtCosto;
        private TextBox txtIDUsuario;
        private TextBox txtPrecioVenta;
        private TextBox txtDescripcion;
        private Button btnSave;
    }
}