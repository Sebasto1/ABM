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
    public partial class FormBuscarVenta : Form
    {
        public FormBuscarVenta()
        {
            InitializeComponent();
        }

        private void FormBuscarVenta_Load(object sender, EventArgs e)
        {

        }


        private void MostrarVenta(Venta venta)
        {
            txtId.Text = venta.Id.ToString();
            txtIdUsuario.Text = venta.IdUsuario.ToString();
            txtComentarios.Text = venta.Comentarios;


        }


        private void LimpiarCajas()
        {
            txtId.Clear();
            txtIdUsuario.Clear();
            txtComentarios.Clear();


        }

        private void FormBuscarProductoVendido_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscar.Text, out int id))
            {
                Venta venta = VentaData.ObtenerVenta(id);

                if (venta != null)
                {
                    MostrarVenta(venta);
                }
                else
                {
                    MessageBox.Show("venta no encontrada con esa ID");
                }

            }
            else
            {
                MessageBox.Show("ID invalida, ingrese un numero correcto");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscar.Text, out int id))
            {
                Venta venta = VentaData.ObtenerVenta(id);

                if (venta != null)
                {
                    DialogResult result = MessageBox.Show("¿Estas seguro/a de eliminar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            VentaData.EliminarVenta(venta);
                            MessageBox.Show("Venta eliminada");

                            LimpiarCajas();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar la venta: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("ID invalida, ingrese un numero correcto");
            }

        }
    }
}
