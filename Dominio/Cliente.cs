using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente 
    {
        public int idCliente { get; set; }
        public Int64 Dni { get; set; }
        public int NroCliente { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Cp { get; set; }
        public Int64 Telefono { get; set; }
        public string Mail { get; set; }
        public int estado { get; set; }

        public override string ToString()
        {
            return Apellido.ToString() + ", " + Nombre.ToString();
        }
    }
}
