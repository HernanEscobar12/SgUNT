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
    public partial class FrmUsuarios : Form
    {
        private Usuario seleccionado;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Cargar();
        }



        private void btnSelect_Click(object sender, EventArgs e)
        {
            seleccionado = dgvUsuarios.CurrentRow.DataBoundItem as Usuario;
            FrmUsuarioDetalles frmUsuarioDetalles = new FrmUsuarioDetalles(seleccionado);

            frmUsuarioDetalles.FormClosed += (s, args) => Cargar();
            frmUsuarioDetalles.ShowDialog();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmUsuarioDetalles frmUsuarioDetalles = new FrmUsuarioDetalles();
            frmUsuarioDetalles.FormClosed += (s, args) => Cargar();
            frmUsuarioDetalles.ShowDialog();
        }
        private void Cargar()
        {

            UsuarioNegocio negocio = new UsuarioNegocio();
            dgvUsuarios.DataSource = negocio.ListarUsuarios();
            dgvUsuarios.Columns["IdUsuario"].Visible = false;
            dgvUsuarios.Columns["Estado"].Visible = false;
            dgvUsuarios.Columns["Permiso"].Visible = false;
        }
    }
}
