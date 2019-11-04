using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Puesto
    {
        public int IdPuesto { set; get; }
        public string Descripcion { set; get; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
