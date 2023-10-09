namespace ABM
{
    partial class FormModificarUsuario
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
            txtNombre = new TextBox();
            txtMail = new TextBox();
            txtNombreUsuario = new TextBox();
            txtContraseña = new TextBox();
            lblNombre = new Label();
            lblContraseña = new Label();
            lblNombreUsuario = new Label();
            lblMail = new Label();
            lblApellido = new Label();
            txtApellido = new TextBox();
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
            // txtNombre
            // 
            txtNombre.Location = new Point(334, 121);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 30;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(334, 329);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(150, 31);
            txtMail.TabIndex = 29;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(66, 226);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(150, 31);
            txtNombreUsuario.TabIndex = 28;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(66, 338);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = 'x';
            txtContraseña.Size = new Size(150, 31);
            txtContraseña.TabIndex = 27;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.Control;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(378, 81);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 26;
            lblNombre.Text = "Nombre";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = SystemColors.Control;
            lblContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblContraseña.Location = new Point(89, 284);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(108, 25);
            lblContraseña.TabIndex = 24;
            lblContraseña.Text = "Contraseña";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = SystemColors.Control;
            lblNombreUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreUsuario.Location = new Point(65, 182);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(151, 25);
            lblNombreUsuario.TabIndex = 23;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.BackColor = SystemColors.Control;
            lblMail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMail.ForeColor = SystemColors.ActiveCaptionText;
            lblMail.Location = new Point(357, 284);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(66, 25);
            lblMail.TabIndex = 22;
            lblMail.Text = "E-Mail";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(378, 182);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(83, 25);
            lblApellido.TabIndex = 33;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(334, 226);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 34;
            // 
            // FormModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(btnSave);
            Controls.Add(txtNombre);
            Controls.Add(txtMail);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(lblNombre);
            Controls.Add(lblContraseña);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblMail);
            Name = "FormModificarUsuario";
            Text = "FormModificarUsuario";
            Load += FormModificarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtNombre;
        private TextBox txtMail;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseña;
        private Label lblNombre;
        private Label lblContraseña;
        private Label lblNombreUsuario;
        private Label lblMail;
        private Label lblApellido;
        private TextBox txtApellido;
    }
}