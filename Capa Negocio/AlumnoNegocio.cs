using Capa_Datos;
using Capa_Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
                Datos.SetConsulta("select Id_Alumno ,dni, Nombre, Apellido , Email  from ALUMNO");
                Datos.EjecutarLectura();

                while (Datos.Reader.Read())
                {
                    Alumno Aux = new Alumno();
                    Aux.Id = (int)Datos.Reader["Id_Alumno"];
                    Aux.Dni = (string)Datos.Reader["dni"];
                    Aux.Nombre = (string)Datos.Reader["Nombre"];
                    Aux.Apellido = (string)Datos.Reader["Apellido"];
                    Aux.Email = (string)Datos.Reader["Email"];
                    alumnos.Add(Aux);   
                }
                return alumnos; 
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Agregar(Alumno alumno)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetConsulta("insert into ALUMNO(Dni, Nombre, Apellido, Email) VALUES (@dni, @nombre, @apellido, @email)");
                Datos.SetearParametros("@dni" , alumno.Dni);
                Datos.SetearParametros("@nombre" , alumno.Nombre);
                Datos.SetearParametros("@apellido" , alumno.Apellido);
                Datos.SetearParametros("@email", alumno.Email);
                Datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { Datos.CerrarConexion(); }
        }


        public void Modificar(Alumno alumno)
        {
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.SetConsulta("Update ALUMNO set Dni = @dni, Nombre = @nombre , Apellido = @apellido, Email = @email where Id_Alumno = @id");
                Datos.SetearParametros("@dni", alumno.Dni);
                Datos.SetearParametros("@nombre", alumno.Nombre);
                Datos.SetearParametros("@apellido", alumno.Apellido);
                Datos.SetearParametros("@email", alumno.Email);
                Datos.SetearParametros("@id", alumno.Id);
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
