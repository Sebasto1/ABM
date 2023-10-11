namespace ABM
{
    partial class FormABM
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
            btnProductosVendidos = new Button();
            btnVentas = new Button();
            btnUsuarios = new Button();
            btnProductos = new Button();
            SuspendLayout();
            // 
            // btnProductosVendidos
            // 
            btnProductosVendidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductosVendidos.Location = new Point(599, 229);
            btnProductosVendidos.Name = "btnProductosVendidos";
            btnProductosVendidos.Size = new Size(334, 161);
            btnProductosVendidos.TabIndex = 0;
            btnProductosVendidos.Text = "ABM PRODUCTOS VENDIDOS";
            btnProductosVendidos.UseVisualStyleBackColor = true;
            btnProductosVendidos.Click += btnProductosVendidos_Click;
            // 
            // btnVentas
            // 
            btnVentas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentas.Location = new Point(127, 229);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(331, 161);
            btnVentas.TabIndex = 1;
            btnVentas.Text = "ABM VENTAS";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsuarios.Location = new Point(127, 67);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(331, 156);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "ABM USUARIOS";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnProductos.Location = new Point(599, 67);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(334, 156);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "ABM PRODUCTOS";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // FormABM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 450);
            Controls.Add(btnProductos);
            Controls.Add(btnUsuarios);
            Controls.Add(btnVentas);
            Controls.Add(btnProductosVendidos);
            Name = "FormABM";
            Text = "FormABM";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductosVendidos;
        private Button btnVentas;
        private Button btnUsuarios;
        private Button btnProductos;
    }
}