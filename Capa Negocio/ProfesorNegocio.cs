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


    }
}
