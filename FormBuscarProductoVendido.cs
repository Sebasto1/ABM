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
    public partial class FormBuscarProductoVendido : Form
    {
        public FormBuscarProductoVendido()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscar.Text, out int id))
            {
                ProductoVendido productoVendido = ProductoVendidoData.ObtenerProductoVendido(id);

                if (productoVendido != null)
                {
                    MostrarProductoVendido(productoVendido);
                }
                else
                {
                    MessageBox.Show("producto vendido no encontrado con esa ID");
                }

            }
            else
            {
                MessageBox.Show("ID invalida, ingrese un numero correcto");
            }
        }

        private void MostrarProductoVendido(ProductoVendido productoVendido)
        {
            txtId.Text = productoVendido.Id.ToString();
            txtIdProducto.Text = productoVendido.IdProducto.ToString();
            txtStock.Text = productoVendido.Stock.ToString();
            txtIdVenta.Text = productoVendido.IdVenta.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscar.Text, out int id))
            {
                ProductoVendido productoVendido = ProductoVendidoData.ObtenerProductoVendido(id);

                if (productoVendido != null)
                {
                    DialogResult result = MessageBox.Show("¿Estas seguro/a de eliminar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            ProductoVendidoData.EliminarProductoVendido(productoVendido);
                            MessageBox.Show("Producto vendido eliminado");

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
            txtId.Clear();
            txtIdProducto.Clear();
            txtIdVenta.Clear();
            txtStock.Clear();

        }

        private void FormBuscarProductoVendido_Load(object sender, EventArgs e)
        {

        }
    }
}
