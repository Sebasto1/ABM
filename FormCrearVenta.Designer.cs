namespace ABM
{
    partial class FormCrearVenta
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
            txtIdUsuario = new TextBox();
            lblIdUsuario = new Label();
            txtComentarios = new TextBox();
            lblComentarios = new Label();
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
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Enabled = false;
            txtIdUsuario.Location = new Point(290, 114);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(150, 31);
            txtIdUsuario.TabIndex = 79;
            // 
            // lblIdUsuario
            // 
            lblIdUsuario.AutoSize = true;
            lblIdUsuario.BackColor = SystemColors.Control;
            lblIdUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdUsuario.Location = new Point(314, 74);
            lblIdUsuario.Name = "lblIdUsuario";
            lblIdUsuario.Size = new Size(101, 25);
            lblIdUsuario.TabIndex = 78;
            lblIdUsuario.Text = "ID Usuario";
            // 
            // txtComentarios
            // 
            txtComentarios.Enabled = false;
            txtComentarios.Location = new Point(290, 269);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(150, 31);
            txtComentarios.TabIndex = 77;
            // 
            // lblComentarios
            // 
            lblComentarios.AutoSize = true;
            lblComentarios.BackColor = SystemColors.Control;
            lblComentarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblComentarios.Location = new Point(314, 229);
            lblComentarios.Name = "lblComentarios";
            lblComentarios.Size = new Size(119, 25);
            lblComentarios.TabIndex = 76;
            lblComentarios.Text = "Comentarios";
            // 
            // FormCrearVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIdUsuario);
            Controls.Add(lblIdUsuario);
            Controls.Add(txtComentarios);
            Controls.Add(lblComentarios);
            Controls.Add(btnSave);
            Name = "FormCrearVenta";
            Text = "FormCrearVenta";
            Load += FormCrearVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtIdUsuario;
        private Label lblIdUsuario;
        private TextBox txtComentarios;
        private Label lblComentarios;
    }
}