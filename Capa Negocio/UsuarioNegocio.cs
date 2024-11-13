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

        public List<Usuario> ListarUsuarios()
        {
            AccesoDatos Datos = new AccesoDatos();
            List<Usuario> Lista = new List<Usuario>();
            try
            {
                Datos.SetConsulta("select Id_Usuario, Apellido, Nombre, Usuario, Clave from USUARIO");
                Datos.EjecutarLectura();

                while (Datos.Reader.Read())
                {
                    Usuario Aux = new Usuario();
                    Aux.IdUsuario = (int)Datos.Reader["Id_Usuario"];
                    Aux.Apellido = (string)Datos.Reader["Apellido"];
                    Aux.Nombre = (string)Datos.Reader["Nombre"];
                    Aux.User = (string)Datos.Reader["Usuario"];
                    Aux.Clave = (string)Datos.Reader["Clave"];

                    Lista.Add(Aux);
                }

                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Datos.CerrarConexion();
            }



        }
    }
}
