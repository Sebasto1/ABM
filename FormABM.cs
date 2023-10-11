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
    public partial class FormABM : Form
    {
        public FormABM()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormInicialProducto formInicialProducto = new FormInicialProducto();
            formInicialProducto.ShowDialog();
        }

        private void btnProductosVendidos_Click(object sender, EventArgs e)
        {
            FormInicialProductoVendido formInicialProductoVendido = new FormInicialProductoVendido();
            formInicialProductoVendido.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormInicialVenta formInicialVenta = new FormInicialVenta();
            formInicialVenta.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormInicialUsuario formInicialUsuarios = new FormInicialUsuario();
            formInicialUsuarios.ShowDialog();
        }
    }
}
