using Capa_Datos;
using Capa_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class ProfesorNegocio
    {
        public List<Profesor> ListarProfes()
        {
            AccesoDatos Datos = new AccesoDatos();
            List<Profesor> ListaDeProfes = new List<Profesor>();

            try
            {
                Datos.SetConsulta("select Id_Profesor, Nombre, Apellido, Email, Telefono from PROFESOR");
                Datos.EjecutarLectura();

                while (Datos.Reader.Read())
                {
                    Profesor aux = new Profesor();
                    aux.Id = (int)Datos.Reader["Id_Profesor"];
                    aux.Nombre = (string)Datos.Reader["Nombre"];
                    aux.Apellido = (string)Datos.Reader["Apellido"];
                    aux.Email = (string)Datos.Reader["Email"];

                    ListaDeProfes.Add(aux);
                }

                return ListaDeProfes;
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

        public void Agregar(Profesor profe)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetConsulta("insert into PROFESOR  (Nombre , Apellido, Email) VALUES (@nombre, @apellido, @email)");
                Datos.SetearParametros("@nombre", profe.Nombre);
                Datos.SetearParametros("@apellido", profe.Apellido);
                Datos.SetearParametros("@email", profe.Email);
                Datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { Datos.CerrarConexion(); }
        }


        public void Modificar(Profesor profesor)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetConsulta("Update PROFESOR set  Nombre = @nombre , Apellido = @apellido, Email = @email where Id_Profesor = @id");
                Datos.SetearParametros("@nombre", profesor.Nombre);
                Datos.SetearParametros("@apellido", profesor.Apellido);
                Datos.SetearParametros("@email", profesor.Email);
                Datos.SetearParametros("@id", profesor.Id);
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
                Datos.SetConsulta("Delete from PROFESOR where Id_Profesor = @id");
                Datos.SetearParametros("@id" , id);
                Datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
