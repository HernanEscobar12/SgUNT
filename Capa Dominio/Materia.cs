using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Dominio
{
    public class Materia
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public Profesor Profesor { get; set; }

        public Carrera Carrera { get; set; }

        public Turno Turno { get; set; }



        public override string ToString()
        {
            return Nombre;
        }


    }
}
