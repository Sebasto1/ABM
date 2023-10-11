using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABM
{
    public partial class FormCrearVenta : Form
    {
        public FormCrearVenta()
        {
            InitializeComponent();
        }

        private void FormCrearVenta_Load(object sender, EventArgs e)
        {

        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int idUsuario;
            string comentarios = txtComentarios.Text;


            if (int.TryParse(txtIdUsuario.Text, out idUsuario))
            {
                Venta nuevaVenta = new Venta
                {
                    IdUsuario = idUsuario,
                    Comentarios = comentarios,
                };
                try
                {
                    VentaData.CrearVenta(nuevaVenta);
                    MessageBox.Show("Venta creada satisfactoriamente");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear la venta {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores validos");
            }
        }
    }
}
