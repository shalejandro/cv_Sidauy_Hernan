using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Insumos
    {
        public int Id { get; set; }
        public String Descripcion { get; set; }
        public decimal Pu { get; set; }
        public int Disponibles { get; set; }
        public DateTime fecha { get; set; }

        public override string ToString()
        {
            return Descripcion.ToString();
        }
    }
}
