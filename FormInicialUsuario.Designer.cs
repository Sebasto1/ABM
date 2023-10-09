namespace ABM
{
    partial class FormInicialUsuario
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
            btnBuscar = new Button();
            btnCrear = new Button();
            btnRecargarBD = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(492, 313);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(176, 34);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar y/o Eliminar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(35, 313);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(169, 34);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear Nuevo";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnRecargarBD
            // 
            btnRecargarBD.Location = new Point(674, 163);
            btnRecargarBD.Name = "btnRecargarBD";
            btnRecargarBD.Size = new Size(112, 34);
            btnRecargarBD.TabIndex = 7;
            btnRecargarBD.Text = "Recargar";
            btnRecargarBD.UseVisualStyleBackColor = true;
            btnRecargarBD.Click += btnRecargarBD_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(633, 225);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormInicialUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(btnCrear);
            Controls.Add(btnRecargarBD);
            Controls.Add(dataGridView1);
            Name = "FormInicialUsuario";
            Text = "FormInicialUsuario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscar;
        private Button btnCrear;
        private Button btnRecargarBD;
        private DataGridView dataGridView1;
    }
}