using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Personal
    {
        public Int64 Dni { get; set; }  
        public string Nombre { get; set; } 
        public string Apellido { get; set; } 
        public string Direccion { get; set; }
        public string Sexo { get; set; }
        public DateTime Fnac { get; set; }
        public String mail { get; set; }
    }
}
