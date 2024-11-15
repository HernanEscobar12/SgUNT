using Capa_Datos;
using Capa_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CarreraNegocio
    {
        public List<Carrera> ListaCarreras()
        {
            AccesoDatos Datos = new AccesoDatos();
            List<Carrera> ListaDeCarreras = new List<Carrera>();

            try
            {
                Datos.SetConsulta("select Id_Carrera, Nombre, Sede from CARRERA");
                Datos.EjecutarLectura();

                while (Datos.Reader.Read())
                {
                    Carrera aux = new Carrera();
                    aux.Id = (int)Datos.Reader["Id_Carrera"];
                    aux.Nombre = (string)Datos.Reader["Nombre"];
                    aux.Sede = (string)Datos.Reader["Sede"];

                    ListaDeCarreras.Add(aux);
                }

                return ListaDeCarreras;
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

        public void Agregar(Carrera carrera)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetConsulta("insert into CARRERA (Nombre, Sede) values (@Nombre , @Sede)");
                Datos.SetearParametros("@Nombre", carrera.Nombre);
                Datos.SetearParametros("@Sede", carrera.Sede);
                Datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Modificar(Carrera carrera)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetConsulta("update CARRERA set Nombre = @Nombre , Sede = @Sede where Id_Carrera = @Id");
                Datos.SetearParametros("@Nombre", carrera.Nombre);
                Datos.SetearParametros("@Sede", carrera.Sede);
                Datos.SetearParametros("@Id", carrera.Id);
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
                Datos.SetConsulta("delete from CARRERA where Id_Carrera = @id");
                Datos.SetearParametros("@id", id);
                Datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw;
            }
            finally { Datos.CerrarConexion();}
        }
    }
}
