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
            List<Usuario> ListaUsuarios = new List<Usuario>();
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
                    usuario.Clave = (string)Datos.Reader["Clave"];

                    ListaUsuarios.Add(User);
                }

                if (ListaUsuarios.Count >= 1)
                    return true;
                else
                    return false;


            }
            catch (Exception ex)
            {
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


        public void Agregar(Usuario User)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetConsulta("insert into USUARIO (Apellido , Nombre, Usuario, Clave ) VALUES (@apellido , @nombre , @user, @clave)");
                Datos.SetearParametros("@nombre", User.Nombre);
                Datos.SetearParametros("@apellido", User.Apellido);
                Datos.SetearParametros("@user", User.User);
                Datos.SetearParametros("@clave", User.Clave);
                Datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { Datos.CerrarConexion(); }
        }


        public void Modificar(Usuario user)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetConsulta("update USUARIO set Apellido = @apellido , Nombre = @nombre, Usuario = @user , Clave = @clave where Id_Usuario = @id");
                Datos.SetearParametros("@nombre", user.Nombre);
                Datos.SetearParametros("@apellido", user.Apellido);
                Datos.SetearParametros("@user", user.User);
                Datos.SetearParametros("@clave", user.Clave);
                Datos.SetearParametros("@id", user.IdUsuario);
                Datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { Datos.CerrarConexion(); }
        }

        public void Eliminar(int id)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetConsulta("Delete USUARIO from  where Id_Usuario = @id");
                Datos.SetearParametros("@id", id);
                Datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
