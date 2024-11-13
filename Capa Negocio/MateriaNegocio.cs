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

        // Listar Materias Read
        public List<Materia> ListaMaterias()
        {
            AccesoDatos Datos = new AccesoDatos();
            List<Materia> ListaDeMaterias = new List<Materia>();
            try
            {
                Datos.SetConsulta("select P.Nombre as Profe, P.Id_Profesor ,M.Nombre as Materia, M.Id_Materia , C.Nombre as Carrera, C.Id_Carrera  ,T.Descripcion as Turno, T.IdTurno from MATERIA M inner join PROFESOR P on M.Id_Profesor = P.Id_Profesor inner join CARRERA C on M.Id_Carrera = C.Id_Carrera inner join ESTADO_TURNO T on M.TurnoId = T.IdTurno\r\n");
                Datos.EjecutarLectura();

                while (Datos.Reader.Read())
                {
                    Materia Aux = new Materia();
                    Aux.Id = (int)Datos.Reader["Id_Materia"];
                    Aux.Nombre = (string)Datos.Reader["Materia"];
                    Aux.Profesor = new Profesor();
                    Aux.Profesor.Nombre = (string)Datos.Reader["Profe"];
                    Aux.Profesor.Id = (int)Datos.Reader["Id_Profesor"];
                    Aux.Carrera = new Carrera();
                    Aux.Carrera.Id = (int)Datos.Reader["Id_Carrera"];
                    Aux.Carrera.Nombre = (string)Datos.Reader["Carrera"];
                    Aux.Turno = new Turno();
                    Aux.Turno.Id = (int)Datos.Reader["IdTurno"];
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


        //Insert Materias  // Alta Create

        public void Agregar(Materia Materia)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetConsulta("insert into MATERIA (Id_Profesor, Id_Carrera, Nombre, TurnoId) values (@IdProfe, @IdCarrera, @Nombre, @TurnoID)");
                Datos.SetearParametros("@IdProfe", Materia.Profesor.Id);
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


        // Modificar Update

        public void Modificar(Materia materia)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetConsulta("update MATERIA set Nombre  = @nombre , Id_Profesor = @idProfe , Id_Carrera = @idCarrera, TurnoId = @TurnoId where Id_Materia = @IdMateria");
                datos.SetearParametros("@nombre", materia.Nombre);
                datos.SetearParametros("@idProfe", materia.Profesor.Id);
                datos.SetearParametros("@idCarrera", materia.Carrera.Id);
                datos.SetearParametros("@TurnoId", materia.Turno.Id);
                datos.SetearParametros("@IdMateria", materia.Id);

                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.CerrarConexion(); }

        }



        // Eliminar Delete 

        public void Eliminar(int id)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetConsulta("delete from MATERIA where Id_Materia = @id");
                Datos.SetearParametros("@id", id);
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
