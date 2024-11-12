using System;
using Capa_Dominio;
using Capa_Negocio;
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
    public partial class FrmCarreras : Form
    {
        public FrmCarreras()
        {
            InitializeComponent();
        }

        private void FrmCarreras_Load(object sender, EventArgs e)
        {
            CarreraNegocio Negocio = new CarreraNegocio();
            dgvCarreras.DataSource = Negocio.ListaCarreras();
        }
        
        private void btnNueva_Click(object sender, EventArgs e)
        {
            FrmNuevaCarrera Nuevo = new FrmNuevaCarrera();
            Nuevo.ShowDialog();
        }
    }
}
