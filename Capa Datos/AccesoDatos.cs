using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class AccesoDatos
    {

        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataReader reader;

        public SqlDataReader Reader
        {
            get { return reader; }
        }

        public AccesoDatos()
        {
            connection = new SqlConnection("server=.\\SQLEXPRESS; Database=BD_BaseDatos1; integrated security=true");
            command = new SqlCommand();
        }


        // Set Query Consulta en SQL
        public void SetConsulta(string consulta)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = consulta;
        }


        // Ejecutar Query 
        public void EjecutarLectura()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // Set NoQuety
        public void SetearParametros(string nombre, object valor)
        {
            command.Parameters.AddWithValue(nombre, valor);
        }

        //  Ejecutar No Query

       public void EjecutarAccion()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CerrarConexion()
        {
            if (reader != null)
            {
                reader.Close();
                connection.Close();
            }

        }
    }
}
