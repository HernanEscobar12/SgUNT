using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Dominio
{
    public class Alumno
    {
        public int Id { get; set; }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        public DateTime FechaIngreso { get; set; }


        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
    }




}
