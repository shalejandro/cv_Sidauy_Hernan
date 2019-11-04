using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Reserva
    {
        public int idreserva { get; set; }
        public string cliente { get; set; }
        public DateTime fechahora { get; set; }
        public int numeromesa { get; set; }
        public string mozoasignado { get; set; }
        public int hora { get; set; }
        public int minutos { get; set; }
public int estado { get; set; }
        public override string ToString()
        {
            return cliente.ToString();
        }
    }


}
