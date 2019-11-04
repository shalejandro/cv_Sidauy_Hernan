using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class HorariosLab
    {
        public int id { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Tipo;
        }
        public HorariosLab horariosLab;

        public HorariosLab() { }
    }
}
