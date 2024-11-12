using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Dominio
{
    public class Carrera
    {

        public int Id { get; set; } 

        public string Nombre { get; set; }

        public string Sede { get; set; }


        public override string ToString()
        {
            return Nombre;
        }
    }
}
