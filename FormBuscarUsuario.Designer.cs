namespace ABM
{
    partial class FormBuscarUsuario
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
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtID = new TextBox();
            txtNombre = new TextBox();
            txtMail = new TextBox();
            txtNombreUsuario = new TextBox();
            txtContraseña = new TextBox();
            lblNombre = new Label();
            lblID = new Label();
            lblContraseña = new Label();
            lblNombreUsuario = new Label();
            lblMail = new Label();
            btnEliminar = new Button();
            btnBuscar = new Button();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            SuspendLayout();
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(308, 204);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 46;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(352, 160);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(83, 25);
            lblApellido.TabIndex = 45;
            lblApellido.Text = "Apellido";
            // 
            // txtID
            // 
            txtID.Location = new Point(40, 99);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 44;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(308, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 43;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(308, 307);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(150, 31);
            txtMail.TabIndex = 42;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(40, 204);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(150, 31);
            txtNombreUsuario.TabIndex = 41;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(40, 316);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = 'x';
            txtContraseña.Size = new Size(150, 31);
            txtContraseña.TabIndex = 40;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.Control;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(352, 59);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 39;
            lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = SystemColors.Control;
            lblID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblID.Location = new Point(79, 59);
            lblID.Name = "lblID";
            lblID.Size = new Size(31, 25);
            lblID.TabIndex = 38;
            lblID.Text = "ID";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = SystemColors.Control;
            lblContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblContraseña.Location = new Point(63, 262);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(108, 25);
            lblContraseña.TabIndex = 37;
            lblContraseña.Text = "Contraseña";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = SystemColors.Control;
            lblNombreUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreUsuario.Location = new Point(39, 160);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(151, 25);
            lblNombreUsuario.TabIndex = 36;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.BackColor = SystemColors.Control;
            lblMail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMail.ForeColor = SystemColors.ActiveCaptionText;
            lblMail.Location = new Point(331, 262);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(66, 25);
            lblMail.TabIndex = 35;
            lblMail.Text = "E-Mail";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(583, 295);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 50;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Location = new Point(583, 213);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 49;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBuscar.Location = new Point(589, 116);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(106, 25);
            lblBuscar.TabIndex = 48;
            lblBuscar.Text = "Ingresar ID";
            lblBuscar.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(486, 157);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(302, 31);
            txtBuscar.TabIndex = 47;
            // 
            // FormBuscarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtID);
            Controls.Add(txtNombre);
            Controls.Add(txtMail);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(lblNombre);
            Controls.Add(lblID);
            Controls.Add(lblContraseña);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblMail);
            Name = "FormBuscarUsuario";
            Text = "FormBuscarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtID;
        private TextBox txtNombre;
        private TextBox txtMail;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseña;
        private Label lblNombre;
        private Label lblID;
        private Label lblContraseña;
        private Label lblNombreUsuario;
        private Label lblMail;
        private Button btnEliminar;
        private Button btnBuscar;
        private Label lblBuscar;
        private TextBox txtBuscar;
    }
}