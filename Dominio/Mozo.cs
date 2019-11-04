using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Mozo : Interno
    {
        public int NumeroPedido { get; set; }
        public int NumeroMesa { get; set; }

        public override string ToString()
        {
            return Apellido+" "+Nombre;
        }

    }
}
