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
    public partial class FormBuscarProducto : Form
    {
        public FormBuscarProducto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscar.Text, out int id))
            {
                Producto producto = ProductoData.ObtenerProducto(id);

                if (producto != null)
                {
                    MostrarProducto(producto);
                }
                else
                {
                    MessageBox.Show("Producto no encontrado con esa ID");
                }

            }
            else
            {
                MessageBox.Show("ID invalida, ingrese un numero correcto");
            }
        }

        private void MostrarProducto(Producto producto)
        {
            txtDescripcion.Text = producto.Descripciones;
            txtCosto.Text = producto.Costo.ToString();
            txtPrecioVenta.Text = producto.PrecioVenta.ToString();
            txtStock.Text = producto.Stock.ToString();
            txtIDUsuario.Text = producto.IdUsuario.ToString();
            txtBuscar.Text = producto.Id.ToString();
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscar.Text, out int id))
            {
                Producto producto = ProductoData.ObtenerProducto(id);

                if (producto != null)
                {
                    DialogResult result = MessageBox.Show("¿Estas seguro/a de eliminar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            ProductoData.EliminarProducto(producto);
                            MessageBox.Show("Producto eliminado");

                            LimpiarCajas();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar el producto: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("ID invalida, ingrese un numero correcto");
            }
        }

        private void LimpiarCajas()
        {
            txtCosto.Clear();
            txtDescripcion.Clear();
            txtIDUsuario.Clear();
            txtPrecioVenta.Clear();
            txtStock.Clear();

        }
    }


}
