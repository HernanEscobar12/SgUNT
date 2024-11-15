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
    public partial class FrmAlumnoDetalle : Form
    {
        public Alumno alumno = null;
        public FrmAlumnoDetalle()
        {
            InitializeComponent();
        }

        public FrmAlumnoDetalle(Alumno alumno)
        {
            InitializeComponent();
            this.alumno = alumno;
        }

        private void FrmAlumnoDetalle_Load(object sender, EventArgs e)
        {

            if (alumno != null)
            {
                txtDni.Text = alumno.Dni.ToString();
                txtNombre.Text = alumno.Nombre.ToString();
                TxtApellido.Text = alumno.Apellido.ToString();
                txtEmail.Text = alumno.Email.ToString();

                BtnAceptar.Text = "Modificar";

            }
            else
            {
                BtnAceptar.Text = "Agregar";
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            AlumnoNegocio Negocio = new AlumnoNegocio();

            if (alumno == null)
                alumno = new Alumno();

            alumno.Dni = txtDni.Text;
            alumno.Nombre = txtNombre.Text;
            alumno.Apellido = TxtApellido.Text;
            alumno.Email = txtEmail.Text;

            if (txtDni.Text != "" && txtEmail.Text != "" && txtNombre.Text != "" && TxtApellido.Text != "")
            {
                if (alumno.Id != 0)
                {
                    Negocio.Modificar(alumno);
                    MessageBox.Show("Modificado Exitosamente!!");
                }
                else
                {
                    Negocio.Agregar(alumno);
                    MessageBox.Show("Agregado Exitosamente!!");
                }
            }
            else
            {
                MessageBox.Show("Hay campos vacios!!");
            }

        }


    }
}
