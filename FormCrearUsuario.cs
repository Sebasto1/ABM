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
    public partial class FormCrearUsuario : Form
    {
        public FormCrearUsuario()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string nombreUsuario = txtNombreUsuario.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string contraseña = txtContraseña.Text;
            string mail = txtMail.Text;



            Usuario nuevoUsuario = new Usuario
            {

                NombreUsuario = nombreUsuario,
                Nombre = nombre,
                Apellido = apellido,
                Contraseña = contraseña,
                Mail = mail
            };
            try
            {
                UsuarioData.CrearUsuario(nuevoUsuario);
                MessageBox.Show("Usuario Creado Satisfactoriamente");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el usuario: {ex.Message} ");
            }

        }

        private void FormCrearUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
