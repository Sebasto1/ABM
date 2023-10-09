namespace ABM
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            btnRecargarBD = new Button();
            btnCrear = new Button();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(633, 225);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnRecargarBD
            // 
            btnRecargarBD.Location = new Point(707, 142);
            btnRecargarBD.Name = "btnRecargarBD";
            btnRecargarBD.Size = new Size(112, 34);
            btnRecargarBD.TabIndex = 2;
            btnRecargarBD.Text = "Recargar";
            btnRecargarBD.UseVisualStyleBackColor = true;
            btnRecargarBD.Click += btnRecargarBD_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(12, 324);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(169, 34);
            btnCrear.TabIndex = 3;
            btnCrear.Text = "Crear Nuevo";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnForm2_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(469, 324);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(176, 34);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar y/o Eliminar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 528);
            Controls.Add(btnBuscar);
            Controls.Add(btnCrear);
            Controls.Add(btnRecargarBD);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "ABM";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnRecargarBD;
        private Button btnCrear;
        private Button btnBuscar;
    }
}