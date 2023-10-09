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
    public partial class Form1 : Form
    {
        private ProductoData productoData;
        public Form1()
        {
            InitializeComponent();

        }

        private void MostrarListaProductos()
        {
            List<Producto> productos = ProductoData.ListarProductos();

            // Asigna la lista de productos al DataGridView
            dataGridView1.DataSource = productos;

            // Opcional: Configura las columnas si es necesario
            dataGridView1.Columns["Id"].Visible = true; // Puedes ocultar columnas si es necesario
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajusta automáticamente el tamaño de las columnas
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Obtén el producto seleccionado
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                Producto productoSeleccionado = (Producto)selectedRow.DataBoundItem;

                // Abre el formulario para modificar el producto
                FormModificarProducto formModificarProducto = new FormModificarProducto(productoSeleccionado, productoData);
                formModificarProducto.ShowDialog();

                // Actualiza la lista de productos después de modificar
                MostrarListaProductos();
            }


        }

        public void Form1_Load(object sender, EventArgs e)
        {
            MostrarListaProductos();
        }

        private void btnModificarDatos_Click(object sender, EventArgs e)
        {

        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            FormCrearProducto form2 = new FormCrearProducto();
            form2.Show();
        }



        private void btnRecargarBD_Click(object sender, EventArgs e)
        {
            MostrarListaProductos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormBuscarProducto formBuscarProducto = new FormBuscarProducto();
            formBuscarProducto.Show();
        }
    }
}
