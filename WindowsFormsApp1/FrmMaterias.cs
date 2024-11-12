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
    public partial class FrmMaterias : Form
    {
        private Materia Seleccionado = null;
        public FrmMaterias()
        {
            InitializeComponent();
        }

        private void FrmMaterias_Load(object sender, EventArgs e)
        {
            CargarDgv();
        }




        #region Cargar Data Grid

        public void CargarDgv()
        {
            MateriaNegocio Negocio = new MateriaNegocio();
            dgvMaterias.DataSource = Negocio.ListaMaterias();
            dgvMaterias.Columns["Id"].Visible = false;
        }

        #endregion

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Seleccionado = (Materia)dgvMaterias.CurrentRow.DataBoundItem;
            FrmDetalleMaterias DetalleMateria = new FrmDetalleMaterias(Seleccionado);
            DetalleMateria.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmDetalleMaterias Nuevo = new FrmDetalleMaterias();
            Nuevo.ShowDialog();
            Close();
        }



    }
}
