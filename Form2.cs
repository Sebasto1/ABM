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
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string descripciones = txtDescripcion.Text;
            double costo;
            double precioVenta;
            int stock;
            int idUsuario;


            if (double.TryParse(txtCosto.Text, out costo) && double.TryParse(txtPrecioVenta.Text, out precioVenta) && int.TryParse(txtStock.Text, out stock) && int.TryParse(txtIDUsuario.Text, out idUsuario))
            {

                Producto nuevoProducto = new Producto
                {
                    Descripciones = descripciones,
                    Costo = costo,
                    PrecioVenta = precioVenta,
                    Stock = stock,
                    IdUsuario = idUsuario,
                };
                try
                {
                    ProductoData.CrearProducto(nuevoProducto);
                    MessageBox.Show("Producto Creado Satisfactoriamente");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el producto: {ex.Message} ");
                }

            }
            else
            {
                MessageBox.Show("Ingrese valores validos");
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
