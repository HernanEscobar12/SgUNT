using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Dominio
{
    public class Curso
    {
        public int IdCurso {  get; set; }   

        public Alumno Alumno { get; set; }

        public Materia Materia { get; set; }

    }
}
