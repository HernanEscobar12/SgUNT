using Capa_Dominio;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmCursos : Form
    {
        private List<Curso> ListaCursos;
        public FrmCursos()
        {
            InitializeComponent();
        }

        private void FrmCursos_Load(object sender, EventArgs e)
        {
          Cargar();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            CursoNegocio cursoNegocio = new CursoNegocio();
            curso.Alumno = new Alumno();
            curso.Alumno = (Alumno)cboAlumnos.SelectedItem;
            curso.Materia = new Materia();
            curso.Materia = (Materia)cboMaterias.SelectedItem;

            cursoNegocio.Agregar(curso);

            Cargar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Curso> ListaFiltrada = new List<Curso>();
            string filtro = textBox1.Text;

            if (filtro.Length >= 3)
            {
                if (rbAlumno.Checked)
                {
                    ListaFiltrada = ListaCursos.FindAll(x => x.Alumno.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Alumno.Apellido.ToUpper().Contains(filtro.ToUpper()));
                    dgvMaterias.DataSource = null;
                    dgvMaterias.DataSource = ListaFiltrada;
                }

                if (rbMateria.Checked)
                {
                    ListaFiltrada = ListaCursos.FindAll(x => x.Materia.Nombre.ToUpper().Contains(filtro.ToUpper()));
                    dgvMaterias.DataSource = null;
                    dgvMaterias.DataSource = ListaFiltrada;
                }

            }
            else
            {
                dgvMaterias.DataSource = ListaCursos;
            }

        }

        private void Cargar()
        {
            CursoNegocio Negocio = new CursoNegocio();
            AlumnoNegocio alumnoNegocio = new AlumnoNegocio();
            MateriaNegocio MateriaNegocio = new MateriaNegocio();
            dgvMaterias.DataSource = null;
            ListaCursos = Negocio.ListarCurso();
            dgvMaterias.DataSource = ListaCursos;
            cboAlumnos.DataSource = alumnoNegocio.ListarAlumnos();
            cboAlumnos.ValueMember = "Id";
            cboAlumnos.DisplayMember = "Nombre";
            cboMaterias.DataSource = MateriaNegocio.ListaMaterias();
            cboMaterias.ValueMember = "Id";
            cboMaterias.DisplayMember = "Nombre";
            dgvMaterias.Columns["IdCurso"].Visible = false;

        }


    }
}

