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
    public partial class FormModificarProductoVendido : Form
    {
        private ProductoVendido productoVendido;
        public FormModificarProductoVendido(ProductoVendido productoVendido)
        {
            InitializeComponent();

            this.productoVendido = productoVendido;


            // Mostrar los detalles del producto en los TextBox
            txtId.Text = productoVendido.Id.ToString();
            txtIdProducto.Text = productoVendido.IdProducto.ToString();
            txtStock.Text = productoVendido.Stock.ToString();
            txtIdVenta.Text = productoVendido.IdVenta.ToString();

        }

        private void FormModificarProductoVendido_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                // Capturar los cambios realizados por el usuario

                productoVendido.Stock = int.Parse(txtStock.Text);


                try
                {
                    // Llamar al método para modificar el producto
                    ProductoVendidoData.ModificarProductoVendido(productoVendido);

                    // Mostrar un mensaje indicando el éxito de la operación
                    MessageBox.Show("Producto vendido modificado correctamente.");

                    // Cerrar el formulario después de guardar los cambios
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar el producto vendido: {ex.Message}");
                }

            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
