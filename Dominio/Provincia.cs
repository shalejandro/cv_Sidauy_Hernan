using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Provincia
    { 
        public int idProvincia { get; set; }
        public string provincia { get; set; }
        public int idPais { get; set; }
        public string pais { get; set; }

        public override string ToString()
        {
            return provincia.ToString(); 
        }
    }
}
