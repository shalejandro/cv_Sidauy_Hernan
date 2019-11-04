using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Menu
    {
        public int nroMenu { get; set; }
        public Entrada entrada { get; set; }
        public Comida comida { get; set; }
        public Postre postre { get; set; }
        public Bebida bebida { get; set; }
    }
}
