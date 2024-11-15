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
    public partial class FrmProfeDetalle : Form
    {
        private Profesor profesor;
        public FrmProfeDetalle()
        {
            InitializeComponent();
        }

        public FrmProfeDetalle(Profesor profe)
        {
            InitializeComponent();
            this.profesor = profe;
        }

        private void FrmProfeDetalle_Load(object sender, EventArgs e)
        {
            if (profesor != null)
            {

                txtNombre.Text = profesor.Nombre.ToString();
                TxtApellido.Text = profesor.Apellido.ToString();
                txtEmail.Text = profesor.Email.ToString();

                BtnAceptar.Text = "Modificar";
                btnEliminar.Visible = true;
            }
            else
            {
                BtnAceptar.Text = "Agregar";
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ProfesorNegocio Negocio = new ProfesorNegocio();

            if (profesor == null)
                profesor = new Profesor();


            profesor.Nombre = txtNombre.Text;
            profesor.Apellido = TxtApellido.Text;
            profesor.Email = txtEmail.Text;

            if (txtEmail.Text != "" && txtNombre.Text != "" && TxtApellido.Text != "")
            {
                if (profesor.Id != 0)
                {
                    Negocio.Modificar(profesor);
                    MessageBox.Show("Modificado Exitosamente!!");


                }
                else
                {
                    Negocio.Agregar(profesor);
                    MessageBox.Show("Agregado Exitosamente!!");
                }
            }
            else
            {
                MessageBox.Show("Hay Campos Vacios");
            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProfesorNegocio Negocio = new ProfesorNegocio();
            DialogResult respuesta = MessageBox.Show($"Eliminas {profesor.Nombre}?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            FrmProfesores frmProfesor = new FrmProfesores();
            if (respuesta == DialogResult.Yes)
            {
                Negocio.Eliminar(profesor.Id);


            }

            Close();
        }
    }
}
