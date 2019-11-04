using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pais
    {
        public int idPais { get; set; }
        public string nombre { get; set; }

        public override string ToString()
        {
            return nombre.ToString();
        }
    }
}
