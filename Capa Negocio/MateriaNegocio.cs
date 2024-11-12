using Capa_Datos;
using Capa_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class MateriaNegocio
    {

        // Listar Materias
        public List<Materia> ListaMaterias()
        {
            AccesoDatos Datos = new AccesoDatos();
            List<Materia> ListaDeMaterias = new List<Materia>();
            try
            {
                Datos.SetConsulta("SELECT M.Id_Materia, M.Nombre AS Materia, P.Nombre AS Profe, C.Nombre AS Carrera, T.Descripcion as Turno FROM MATERIA M INNER JOIN PROFESOR P ON P.Id_Profesor = M.Id_Profesor INNER JOIN CARRERA C ON C.Id_Carrera = M.Id_Carrera INNER JOIN ESTADO_TURNO T ON T.IdTurno = M.TurnoId");
                Datos.EjecutarLectura();

                while (Datos.Reader.Read())
                {
                    Materia Aux = new Materia();
                    Aux.Id = (int)Datos.Reader["Id_Materia"];
                    Aux.Nombre = (string)Datos.Reader["Materia"];
                    Aux.Profesor = new Profesor();
                    Aux.Profesor.Nombre = (string)Datos.Reader["Profe"];
                    Aux.Carrera = new Carrera();
                    Aux.Carrera.Nombre = (string)Datos.Reader["Carrera"];
                    Aux.Turno = new Turno();
                    Aux.Turno.Descripcion = (string)Datos.Reader["Turno"];

                    ListaDeMaterias.Add(Aux);
                }

                return ListaDeMaterias;
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


        //Insert Materias

        public void CargaMateria (Materia Materia)
        {
            AccesoDatos Datos = new AccesoDatos ();

            try
            {
                Datos.SetConsulta("insert into MATERIA (Id_Profesor, Id_Carrera, Nombre, TurnoId) values (@IdProfe, @IdCarrera, @Nombre, @TurnoID)");
                Datos.SetearParametros("@IdProfe" , Materia.Profesor.Id);
                Datos.SetearParametros("@IdCarrera", Materia.Carrera.Id);
                Datos.SetearParametros("@Nombre", Materia.Nombre);
                Datos.SetearParametros("TurnoID", Materia.Turno.Id);

                Datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { Datos.CerrarConexion(); }


        }


 

    }
}
