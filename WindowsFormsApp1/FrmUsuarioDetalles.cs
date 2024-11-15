using Capa_Dominio;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmUsuarioDetalles : Form
    {
        private Usuario user;
        public FrmUsuarioDetalles()
        {
            InitializeComponent();
        }

        public FrmUsuarioDetalles(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUsuarioDetalles_Load(object sender, EventArgs e)
        {
            if (user != null)
            {

                BtnAceptar.Text = "Modificar";
                txtName.Text = user.Nombre.ToString();
                txtApellido.Text = user.Apellido.ToString();
                txtUser.Text = user.User.ToString();
                txtClave.Text = user.Clave.ToString();
                btnEliminar.Visible = true;
            }
            else
            {
                BtnAceptar.Text = "Grabar Materia";

            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            UsuarioNegocio Negocio = new UsuarioNegocio();

            if (user == null)
                user = new Usuario();

            user.Nombre = txtName.Text;
            user.Apellido = txtApellido.Text;
            user.Clave = txtClave.Text;
            user.User = txtUser.Text;


            if (txtName.Text != "" && txtApellido.Text !=  "" && txtClave.Text != "" && txtUser.Text != "")
            {

                if (user.IdUsuario == 0)
                {
                    Negocio.Agregar(user);
                    MessageBox.Show("Usuario Agregada Exitosamente!!");
                    Close();
                }
                else
                {
                    Negocio.Modificar(user);
                    MessageBox.Show("Usuario Modificado Exitosamente!!");
                    Close();

                }
            }
            else
            {
                MessageBox.Show("Hay campos vacios!!");
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            UsuarioNegocio Negocio = new UsuarioNegocio();
            DialogResult respuesta = MessageBox.Show($"Eliminas {user.Nombre}?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Negocio.Eliminar(user.IdUsuario);
                Close();
            }
            else
            {
                Close();
            }
        }
    }
}
