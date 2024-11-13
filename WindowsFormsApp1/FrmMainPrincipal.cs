using Capa_Dominio;
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
    public partial class FrmMainPrincipal : Form
    {
        private Usuario Usuario;
        public FrmMainPrincipal()
        {
            InitializeComponent();
        }

        public FrmMainPrincipal(Usuario user)
        {
            InitializeComponent();
            this.Usuario = user;

        }

        private void FrmMainPrincipal_Load(object sender, EventArgs e)
        {
          
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            FrmMaterias materias = new FrmMaterias();
            materias.ShowDialog();
        }

        private void BtnCurso_Click(object sender, EventArgs e)
        {
            FrmCursos Cursos = new FrmCursos();
            Cursos.Show();
        }

        private void btnCarreras_Click(object sender, EventArgs e)
        {
            FrmCarreras Carreras = new FrmCarreras();
            Carreras.ShowDialog();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            FrmProfesor frmProfesor = new FrmProfesor();
            frmProfesor.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.ShowDialog();
        }
    }
}
