namespace ABM
{
    partial class FormModificarProductoVendido
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
            // btnSave
            // 
            btnSave.Location = new Point(623, 205);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 32;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(66, 121);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 31;
            txtId.TextChanged += txtDescripcion_TextChanged;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(334, 121);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(150, 31);
            txtIdVenta.TabIndex = 30;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(66, 226);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(150, 31);
            txtIdProducto.TabIndex = 28;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(66, 338);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 31);
            txtStock.TabIndex = 27;
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.BackColor = SystemColors.Control;
            lblIdVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdVenta.Location = new Point(334, 81);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(85, 25);
            lblIdVenta.TabIndex = 26;
            lblIdVenta.Text = "ID Venta";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = SystemColors.Control;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(90, 81);
            lblId.Name = "lblId";
            lblId.Size = new Size(31, 25);
            lblId.TabIndex = 25;
            lblId.Text = "ID";
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
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.BackColor = SystemColors.Control;
            lblIdProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdProducto.Location = new Point(105, 182);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(114, 25);
            lblIdProducto.TabIndex = 23;
            lblIdProducto.Text = "ID Producto";
            // 
            // FormModificarProductoVendido
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtId);
            Controls.Add(txtIdVenta);
            Controls.Add(txtIdProducto);
            Controls.Add(txtStock);
            Controls.Add(lblIdVenta);
            Controls.Add(lblId);
            Controls.Add(lblStock);
            Controls.Add(lblIdProducto);
            Name = "FormModificarProductoVendido";
            Text = "FormModificarProductoVendido";
            Load += FormModificarProductoVendido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
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