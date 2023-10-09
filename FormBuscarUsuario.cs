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
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscar.Text, out int id))
            {
                Usuario usuario = UsuarioData.ObtenerUsuario(id);

                if (usuario != null)
                {
                    MostrarUsuario(usuario);
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado con esa ID");
                }

            }
            else
            {
                MessageBox.Show("ID invalida, ingrese un numero correcto");
            }
        }

        private void MostrarUsuario(Usuario usuario)
        {
            txtID.Text = usuario.Id.ToString();
            txtNombreUsuario.Text = usuario.NombreUsuario.ToString();
            txtNombre.Text = usuario.Nombre.ToString();
            txtApellido.Text = usuario.Apellido.ToString();
            txtContraseña.Text = usuario.Apellido.ToString();
            txtMail.Text = usuario.Mail.ToString();

        }


        private void LimpiarCajas()
        {
            txtID.Clear();
            txtNombreUsuario.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtContraseña.Clear();
            txtMail.Clear();


        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            
            if (int.TryParse(txtBuscar.Text, out int id))
            {
                Usuario usuario = UsuarioData.ObtenerUsuario(id);

                if (usuario != null)
                {
                    DialogResult result = MessageBox.Show("¿Estas seguro/a de eliminar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            UsuarioData.EliminarUsuario(usuario);
                            MessageBox.Show("Usuario eliminado");

                            LimpiarCajas();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar el usuario: {ex.Message}");
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
