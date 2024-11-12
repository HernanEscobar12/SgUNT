using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Dominio
{
    public class Usuario
    {
        public int IdUsuario { get; set; } 
        public string Apellido { get; set; } 
        public string Nombre { get; set; } 
        public string User { get; set; } 
        public string Clave { get; set; } 
        public int Estado { get; set; } 
        public int Permiso { get; set; }

    }
}
