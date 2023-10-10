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
    public partial class FormInicialVenta : Form
    {
        private VentaData ventaData;
        public FormInicialVenta()
        {
            InitializeComponent();
        }

        private void MostrarListaVentas()
        {
            List<Venta> ventas = VentaData.ListarVentas();

            // Asigna la lista de productos al DataGridView
            dataGridView1.DataSource = ventas;

            // Opcional: Configura las columnas si es necesario
            dataGridView1.Columns["Id"].Visible = true; // Puedes ocultar columnas si es necesario
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajusta automáticamente el tamaño de las columnas
        }

        private void FormInicialVenta_Load(object sender, EventArgs e)
        {
            MostrarListaVentas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Obtén el producto seleccionado
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                Venta ventaSeleccionado = (Venta)selectedRow.DataBoundItem;

                // Abre el formulario para modificar el producto
                FormModificarVenta formModificarVenta = new FormModificarVenta(ventaSeleccionado);
                formModificarVenta.ShowDialog();

                // Actualiza la lista de productos después de modificar
                MostrarListaVentas();
            }
        }

        private void btnRecargarBD_Click(object sender, EventArgs e)
        {
            MostrarListaVentas();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormCrearVenta formCrearVenta = new FormCrearVenta();
            formCrearVenta.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormBuscarVenta formBuscarVenta = new FormBuscarVenta();
            formBuscarVenta.Show();
        }
    }
}
