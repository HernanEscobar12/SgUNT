using Capa_Datos;
using Capa_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class TurnoNegocio
    {
        public List<Turno> ListarTurnos()
        {
            AccesoDatos Datos = new AccesoDatos();
            List<Turno> Turnos = new List<Turno>();

            try
            {
                Datos.SetConsulta("select IdTurno, Descripcion from Estado_Turno");
                Datos.EjecutarLectura();

                while (Datos.Reader.Read())
                {
                  Turno aux = new Turno();
                  aux.Id = (int)Datos.Reader["IdTurno"];
                  aux.Descripcion = (string)Datos.Reader["Descripcion"];

                   Turnos.Add(aux);

                }

                return Turnos;
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
