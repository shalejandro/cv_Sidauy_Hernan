using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CodigoPostal
    {
        public int cp { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public int idProvincia { get; set; }
        public string Pais { get; set; }
        public int idPais { get; set; }

        public CodigoPostal codigoPostal;

        public CodigoPostal() { }

        public CodigoPostal(int codigoPos, string localidad,string provincia,string pais)
        {
                {
                cp = codigoPos;
                Localidad = localidad;
                Provincia = provincia;
                Pais = pais;
                }
        }

        public override string ToString()
        {
            return cp.ToString();
        }
    }
}
