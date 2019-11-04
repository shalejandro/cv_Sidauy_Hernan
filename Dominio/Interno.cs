using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Interno : Personal
    {
        public Interno()
        {
            puesto = new Puesto();
            horario = new HorariosLab();
            codigoPostal= new CodigoPostal();
        }

        public int idinterno { get; set; }
        public int NumeroLegajo { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public Puesto puesto;
        public HorariosLab horario;
        public CodigoPostal codigoPostal;
        public Mozo Mozo;
        public Cajero Cajero;
        public Cocinero Cocinero;
        public Seguridad Seguridad;
        public Limpieza Limpieza;
        public int estado { get; set; }

    }
}
