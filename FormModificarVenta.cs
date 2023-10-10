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
    public partial class FormModificarVenta : Form
    {
        private Venta venta;
        public FormModificarVenta(Venta venta)
        {
            InitializeComponent();

            this.venta = venta;


            // Mostrar los detalles del producto en los TextBox

            txtComentarios.Text = venta.Comentarios;
            txtIdUsuario.Text = venta.IdUsuario.ToString();

        }

        private void FormModificarProductoVendido_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                // Capturar los cambios realizados por el usuario

                venta.IdUsuario = int.Parse(txtIdUsuario.Text);
                venta.Comentarios = txtComentarios.Text;


                try
                {
                    // Llamar al método para modificar el producto
                    VentaData.ModificarVenta(venta);

                    // Mostrar un mensaje indicando el éxito de la operación
                    MessageBox.Show("venta modificada correctamente.");

                    // Cerrar el formulario después de guardar los cambios
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar la venta: {ex.Message}");
                }

            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
        private void FormModificarVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
