using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class BotonMesa
    {
        public BotonMesa(int boton,String mozo)
        {
            this.numeroBoton = boton;
            this.mozoAsignado=mozo;
        }

        public string mozoAsignado { get; set; }
        public int numeroBoton { get; set; }
    }
}
