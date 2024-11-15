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
    public partial class FrmAlumnos : Form
    {
        private Alumno seleccionado;
        public FrmAlumnos()
        {
            InitializeComponent();
        }

        private void btnNue_Click(object sender, EventArgs e)
        {
            FrmAlumnoDetalle Nuevo = new FrmAlumnoDetalle();
            Nuevo.FormClosed += (s, args) => Cargar();
            Nuevo.ShowDialog();
        }



        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private void btnSelec_Click(object sender, EventArgs e)
        {
            seleccionado = (Alumno)dgvAlumnos.CurrentRow.DataBoundItem;
            FrmAlumnoDetalle Detalle = new FrmAlumnoDetalle(seleccionado);
         
            Detalle.FormClosed += (s, args) => Cargar();
            Detalle.ShowDialog();
        }


        public void Cargar()
        {
            AlumnoNegocio Negocio = new AlumnoNegocio();
            dgvAlumnos.DataSource = Negocio.ListarAlumnos();
            dgvAlumnos.Columns["Id"].Visible = false;
            dgvAlumnos.Columns["Telefono"].Visible = false;
            dgvAlumnos.Columns["FechaIngreso"].Visible = false;

        }

    }
}
