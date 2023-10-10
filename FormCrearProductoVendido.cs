using Microsoft.Identity.Client;
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
    public partial class FormCrearProductoVendido : Form
    {
        public FormCrearProductoVendido()
        {
            InitializeComponent();
        }

        private void FormCrearProductoVendido_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int idProducto;
            int stock;
            int idVenta;

            if (int.TryParse(txtIdProducto.Text, out idProducto) && int.TryParse(txtStock.Text, out stock) && int.TryParse(txtIdVenta.Text, out idVenta))
            {
                ProductoVendido nuevoProductoVendido = new ProductoVendido
                {
                    IdProducto = idProducto,
                    Stock = stock,
                    IdVenta = idVenta
                };
                try
                {
                    ProductoVendidoData.CrearProductoVendido(nuevoProductoVendido);
                    MessageBox.Show("Producto vendido satisfactoriamente");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el producto vendido{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores validos");
            }
        }
    }
}
