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
    public partial class FormModificarProducto : Form
    {
        private Producto producto;
        private ProductoData productoData;

        public FormModificarProducto(Producto producto, ProductoData productoData)
        {
            InitializeComponent();

            this.producto = producto;
            this.productoData = productoData;

            // Mostrar los detalles del producto en los TextBox
            txtDescripcion.Text = producto.Descripciones;
            txtPrecioVenta.Text = producto.PrecioVenta.ToString();
            txtStock.Text = producto.Stock.ToString();
            txtCosto.Text = producto.Costo.ToString();
            txtIDUsuario.Text = producto.IdUsuario.ToString();
        }

        private void FormModificarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                // Capturar los cambios realizados por el usuario
                producto.Descripciones = txtDescripcion.Text;
                producto.PrecioVenta = double.Parse(txtPrecioVenta.Text);
                producto.Stock = int.Parse(txtStock.Text);
                producto.Costo = double.Parse(txtCosto.Text);
                producto.IdUsuario = int.Parse(txtIDUsuario.Text);

                try
                {
                    // Llamar al método para modificar el producto
                    ProductoData.ModificarProducto(producto);

                    // Mostrar un mensaje indicando el éxito de la operación
                    MessageBox.Show("Producto modificado correctamente.");

                    // Cerrar el formulario después de guardar los cambios
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar el producto: {ex.Message}");
                }

            }

        }
    }
}
