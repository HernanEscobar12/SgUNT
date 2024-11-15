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
    public partial class FrmProfesores : Form
    {
        private Profesor seleccionado;
        public FrmProfesores()
        {
            InitializeComponent();
            Cargar();
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            seleccionado = (Profesor)dgvProfes.CurrentRow.DataBoundItem;
            FrmProfeDetalle frmProfeDetalle = new FrmProfeDetalle(seleccionado);
            frmProfeDetalle.Show();
            frmProfeDetalle.FormClosed += (s, args) => Cargar();

            // Muestra el formulario detalle
            frmProfeDetalle.Show();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmProfeDetalle Nuevo = new FrmProfeDetalle();
            Nuevo.Show();
            
            Nuevo.FormClosed += (s, args) => Cargar();
            // Muestra el formulario para crear un nuevo profesor
            Nuevo.Show();


        }

        private void Cargar()
        {
            dgvProfes.DataSource = null;
            ProfesorNegocio negocio = new ProfesorNegocio();
            dgvProfes.DataSource = negocio.ListarProfes(); ;
            dgvProfes.Columns["Id"].Visible = false;
            dgvProfes.Columns["Email"].Visible = false;
            dgvProfes.Columns["Telefono"].Visible = false;
        }
    }
}
