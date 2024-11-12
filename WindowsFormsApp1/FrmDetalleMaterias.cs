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
    public partial class FrmDetalleMaterias : Form
    {
        public Materia Materia = null;
        
        public FrmDetalleMaterias()
        {
            InitializeComponent();
        }

        public FrmDetalleMaterias(Materia materia)
        {
            InitializeComponent();
            this.Materia = materia;

            txtId.Text = materia.Id.ToString();
            txtMateria.Text = materia.Nombre.ToString();
            cboProfe.SelectedValue = materia.Profesor.Id;
            cboCarreras.SelectedValue = materia.Carrera.Id;
            cboTurno.SelectedValue = materia.Turno.Id;
        }
        private void FrmDetalleMaterias_Load(object sender, EventArgs e)
        {
            CargarCbo();


            if (Materia != null)
                btnAceptar.Text = "Modificar";
            else
                btnAceptar.Text = "Grabar Materia";

        }


        #region CargaCbo
        public void CargarCbo()
        {
            CarreraNegocio CarreraNegocio = new CarreraNegocio();
            ProfesorNegocio ProfesorNegocio = new ProfesorNegocio();
            TurnoNegocio turnoNegocio = new TurnoNegocio();

            cboCarreras.DataSource = CarreraNegocio.ListaCarreras();
            cboProfe.DataSource = ProfesorNegocio.ListarProfes();
            cboTurno.DataSource = turnoNegocio.ListarTurnos();

            cboCarreras.ValueMember = "Id";
            cboCarreras.DisplayMember = "Nombre";

            cboProfe.ValueMember = "Id";
            cboProfe.DisplayMember = "NombreCompleto";

            cboTurno.ValueMember = "Id";
            cboTurno.DisplayMember = "Descripcion";
            /// <>

        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MateriaNegocio Negocio = new MateriaNegocio();
            
            if(Materia == null)
            {
                Materia = new Materia();

                Materia.Nombre = txtMateria.Text;
                Materia.Profesor = (Profesor)cboProfe.SelectedItem;
                Materia.Carrera= (Carrera)cboCarreras.SelectedItem;
                Materia.Turno = (Turno)cboTurno.SelectedItem;
   
            }

            if(Materia.Id == 0)
            {
                Negocio.CargaMateria(Materia);
                MessageBox.Show("Materia Agregada Exitosamente!!");
                Close();
            }



        }
    }
}
