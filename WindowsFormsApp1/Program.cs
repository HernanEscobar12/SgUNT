using Capa_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin LoginForm = new FrmLogin();
            if (LoginForm.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = new Usuario();

                usuario = LoginForm.Tag as Usuario;
                Application.Run(new FrmMainPrincipal(usuario));

            }
        }
    }
}
