using Capa_Datos;
using Capa_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class AlumnoNegocio
    {

        public List<Alumno> ListarAlumnos()
        {
            AccesoDatos Datos = new AccesoDatos();  
            List<Alumno> alumnos = new List<Alumno>();

            try
            {
                Datos.SetConsulta("select Id_Alumno , Nombre from ALUMNO");
                Datos.EjecutarLectura();

                while (Datos.Reader.Read())
                {
                    Alumno Aux = new Alumno();
                    Aux.Id = (int)Datos.Reader["Id_Alumno"];
                    Aux.Nombre = (string)Datos.Reader["Nombre"];

                    alumnos.Add(Aux);   
                }
                return alumnos; 
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}
