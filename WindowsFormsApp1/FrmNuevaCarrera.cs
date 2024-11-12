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
    public partial class FrmNuevaCarrera : Form
    {
        public FrmNuevaCarrera()
        {
            InitializeComponent();
        }

        private void FrmNuevaCarrera_Load(object sender, EventArgs e)
        {
            CargarCbo();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Carrera Carrera = new Carrera();

            Carrera.Nombre = txtCarrera.Text;
            Carrera.Sede = (string)cboSede.SelectedItem;
        }
    }
}
