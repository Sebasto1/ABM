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
    public partial class FormInicialProductoVendido : Form
    {

        private ProductoVendidoData productoVendidoData;
        public FormInicialProductoVendido()
        {
            InitializeComponent();

        }

        private void MostrarListaProductosVendidos()
        {
            List<ProductoVendido> productosVendidos = ProductoVendidoData.ListarProductosVendidos();

            // Asigna la lista de productos al DataGridView
            dataGridView1.DataSource = productosVendidos;

            // Opcional: Configura las columnas si es necesario
            dataGridView1.Columns["Id"].Visible = true; // Puedes ocultar columnas si es necesario
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajusta automáticamente el tamaño de las columnas
        }


        public void FormInicialProductoVendido_Load(object sender, EventArgs e)
        {
            MostrarListaProductosVendidos();
        }



        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormCrearProductoVendido formCrearProductoVendido = new FormCrearProductoVendido();
            formCrearProductoVendido.Show();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            FormBuscarProductoVendido formBuscarProductoVendido = new FormBuscarProductoVendido();
            formBuscarProductoVendido.Show();
        }

        private void btnRecargarBD_Click(object sender, EventArgs e)
        {
            MostrarListaProductosVendidos();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Obtén el producto seleccionado
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                ProductoVendido productoVendidoSeleccionado = (ProductoVendido)selectedRow.DataBoundItem;

                // Abre el formulario para modificar el producto
                FormModificarProductoVendido formModificarProductoVendido = new FormModificarProductoVendido(productoVendidoSeleccionado);
                formModificarProductoVendido.ShowDialog();

                // Actualiza la lista de productos después de modificar
                MostrarListaProductosVendidos();
            }
        }
    }
}
