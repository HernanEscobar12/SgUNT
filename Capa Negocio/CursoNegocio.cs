using Capa_Datos;
using Capa_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CursoNegocio
    {

        public List<Curso> ListarCurso()
        {
            AccesoDatos Datos = new AccesoDatos();
            List<Curso> cursos = new List<Curso>();

            try
            {
                Datos.SetConsulta("select Am.Id_Registro as IdRegistro, Am.Id_Alumno as IdAlumno , Am.Id_Materia as IdMateria ,A.Apellido as Apellido , A.Nombre as Nombre ,M.Nombre as Materia from  ALUMNO_MATERIA Am inner join ALUMNO A on A.Id_Alumno  = Am.Id_Alumno inner join MATERIA M on M.Id_Materia = Am.Id_Materia");
                Datos.EjecutarLectura();

                while (Datos.Reader.Read())
                {
                    Curso curso = new Curso();
                    curso.IdCurso = (int)Datos.Reader["IdRegistro"];
                    curso.Alumno = new Alumno();
                    curso.Alumno.Id = (int)Datos.Reader["IdAlumno"];
                    curso.Alumno.Nombre = (string)Datos.Reader["Nombre"];
                    curso.Alumno.Apellido = (string)Datos.Reader["Apellido"];
                    curso.Materia = new Materia();
                    curso.Materia.Id = (int)Datos.Reader["IdMateria"];
                    curso.Materia.Nombre = (string)Datos.Reader["Materia"];

                    cursos.Add(curso);

                }
                return cursos;  
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void Agregar(Curso Curso)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetConsulta("insert into ALUMNO_MATERIA (Id_Alumno , Id_Materia) values (@IdAlumno , @IdMateria)");
                Datos.SetearParametros("@IdAlumno", Curso.Alumno.Id);
                Datos.SetearParametros("@IdMateria", Curso.Materia.Id);
                Datos.EjecutarAccion();

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
