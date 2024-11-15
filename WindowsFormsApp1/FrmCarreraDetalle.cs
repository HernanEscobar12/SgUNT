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
    public partial class FrmCarreraDetalle : Form
    {
        public Carrera carrera = null;
        public FrmCarreraDetalle()
        {
            InitializeComponent();
        }

        public FrmCarreraDetalle(Carrera carrera)
        {
            InitializeComponent();
            this.carrera = carrera;
        }

        private void FrmNuevaCarrera_Load(object sender, EventArgs e)
        {
            CargarCbo();

            if (carrera != null)
            {
                txtCarrera.Text = carrera.Nombre.ToString();
                cboSede.SelectedItem = carrera.Sede.ToString();
                btnAceptar.Text = "Modificar";
                btnEliminar.Visible = true;
            }
            else
            {
                btnAceptar.Text = "Agregar";
            }
        }


        public void CargarCbo()
        {
            cboSede.Items.Add("Campana");
            cboSede.Items.Add("Baradero");
            cboSede.Items.Add("Escobar");
            cboSede.Items.Add("Esteban Echeverria");
            cboSede.Items.Add("Pacheco");
            cboSede.Items.Add("Pilar");
            cboSede.Items.Add("Zarate");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            CarreraNegocio negocio = new CarreraNegocio();
            if (carrera == null)
                carrera = new Carrera();

            carrera.Nombre = txtCarrera.Text;
            carrera.Sede = (string)cboSede.SelectedItem;

            if (txtCarrera.Text != "" && cboSede.SelectedIndex != 0)
            {
                if (carrera.Id == 0)
                {
                    negocio.Agregar(carrera);
                    MessageBox.Show("Agregado exitosamente!!!");
                }
                else
                {
                    negocio.Modificar(carrera);
                    MessageBox.Show("Modificado Exitosamente");
                }
            }
            else
            {
                MessageBox.Show("Hay campos vacios!!");
            }



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CarreraNegocio Negocio = new CarreraNegocio();
            DialogResult respuesta = MessageBox.Show($"Eliminas {carrera.Nombre}?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Negocio.Eliminar(carrera.Id);
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

