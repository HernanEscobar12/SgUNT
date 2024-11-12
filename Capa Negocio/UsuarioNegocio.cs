using Capa_Datos;
using Capa_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class UsuarioNegocio
    {
        public bool Login(Usuario User)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetConsulta("select USUARIO, Clave, Nombre from USUARIO where Usuario = @user and Clave= @clave");
                Datos.SetearParametros("@user", User.User);
                Datos.SetearParametros("@clave", User.Clave);
                Datos.EjecutarLectura();

                while (Datos.Reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.User = (string)Datos.Reader["Nombre"];
                }
                
                return true;

            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }


        }

    }
}
