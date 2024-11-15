﻿using Capa_Dominio;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        
        {
            Usuario User = new Usuario();
            User.User = txtUser.Text;
            User.Clave = txtClave.Text;


            // Validación
            if (txtUser.Text != "" && txtClave.Text != "")
            {
                UsuarioNegocio Negocio = new UsuarioNegocio();
                if (Negocio.Login(User))
                {
                    MessageBox.Show($"Hola  {txtUser.Text}");
                    this.DialogResult = DialogResult.OK;
                    this.Tag = User;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Usuario Inexistente!!!");
                }

            }


        }
    }
}
