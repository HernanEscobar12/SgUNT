using System;
using Capa_Dominio;
using Capa_Negocio;
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
    public partial class FrmCarreras : Form
    {
        private Carrera carrera = new Carrera();
        public FrmCarreras()
        {
            InitializeComponent();
        }

        private void FrmCarreras_Load(object sender, EventArgs e)
        {
            CargarCbo();
        }
        
        private void btnNueva_Click(object sender, EventArgs e)
        {
            FrmCarreraDetalle Nuevo = new FrmCarreraDetalle();
            Nuevo.FormClosed += (s, args) => CargarCbo();
            Nuevo.ShowDialog();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            carrera = (Carrera)dgvCarreras.CurrentRow.DataBoundItem;
            FrmCarreraDetalle FrmNueva = new FrmCarreraDetalle(carrera);
            FrmNueva.FormClosed += (s, args) => CargarCbo();
            FrmNueva.ShowDialog();
        }


        public void CargarCbo()
        {
            dgvCarreras.DataSource = null;
            CarreraNegocio Negocio = new CarreraNegocio();
            dgvCarreras.DataSource = Negocio.ListaCarreras();
            dgvCarreras.Columns["Id"].Visible = false;
        }
    }
}
