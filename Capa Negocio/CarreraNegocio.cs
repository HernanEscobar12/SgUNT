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

    }
}
