using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proveedor
    {
        public int id { get; set; }
        public string cuit { get; set; }
        public int numeroProveedor { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int cp { get; set; }
        public CodigoPostal codigoPostal;
        public Int64 telefono { get; set; }
        public string mail { get; set; }
        public DateTime inicioActividad { get; set; }
        public int estado { get; set; }

    }
}
