namespace ABM
{
    partial class FormBuscarVenta
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
            txtId = new TextBox();
            lblId = new Label();
            btnEliminar = new Button();
            btnBuscar = new Button();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            txtComentarios = new TextBox();
            lblComentarios = new Label();
            txtIdUsuario = new TextBox();
            lblIdUsuario = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(52, 108);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 69;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = SystemColors.Control;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(76, 68);
            lblId.Name = "lblId";
            lblId.Size = new Size(31, 25);
            lblId.TabIndex = 64;
            lblId.Text = "ID";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(543, 348);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 61;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Location = new Point(543, 266);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 60;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBuscar.Location = new Point(549, 169);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(106, 25);
            lblBuscar.TabIndex = 59;
            lblBuscar.Text = "Ingresar ID";
            lblBuscar.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(446, 210);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(302, 31);
            txtBuscar.TabIndex = 58;
            // 
            // txtComentarios
            // 
            txtComentarios.Enabled = false;
            txtComentarios.Location = new Point(52, 251);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(150, 31);
            txtComentarios.TabIndex = 71;
            // 
            // lblComentarios
            // 
            lblComentarios.AutoSize = true;
            lblComentarios.BackColor = SystemColors.Control;
            lblComentarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblComentarios.Location = new Point(76, 211);
            lblComentarios.Name = "lblComentarios";
            lblComentarios.Size = new Size(119, 25);
            lblComentarios.TabIndex = 70;
            lblComentarios.Text = "Comentarios";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Enabled = false;
            txtIdUsuario.Location = new Point(281, 108);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(150, 31);
            txtIdUsuario.TabIndex = 73;
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.BackColor = SystemColors.Control;
            lblIdUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdUsuario.Location = new Point(305, 68);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(101, 25);
            lblIdUsuario.TabIndex = 72;
            lblIdUsuario.Text = "ID Usuario";
            // 
            // FormBuscarVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIdUsuario);
            Controls.Add(lblIdUsuario);
            Controls.Add(txtComentarios);
            Controls.Add(lblComentarios);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Name = "FormBuscarVenta";
            Text = "FormBuscarVenta";
            Load += FormBuscarVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label lblId;
        private Button btnEliminar;
        private Button btnBuscar;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private TextBox txtComentarios;
        private Label lblComentarios;
        private TextBox txtIdUsuario;
        private Label lblIdUsuario;
    }
}