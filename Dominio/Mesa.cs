using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Mesa 
    {
        public int numeroPedido { get; set; }
        public int numeroMesa { get; set; }
        public int cantidadComenzales { get; set; }
        public int Estado { get; set; }
        public string mozoAsignado { get; set; }
       /* public int idEntrada { get; set; }
        public int idComida { get; set; }
        public int idBebida { get; set; }
        public int idPostre { get; set; }
        public int idOtro { get; set; }
        public Entrada entrada { get; set; }
        public Comida comida { get; set; }
        public Bebida bebida { get; set; }
        public Postre postre { get; set; }
        public Otro otro { get; set; }*/
        public DateTime fechaHoraApertura { get; set; }
        public DateTime fechaHoraCierre { get; set; }
        public decimal TotalEntrada { get; set; }
        public decimal TotalComida { get; set; }
        public decimal TotalBebida { get; set; }
        public decimal TotalPostre { get; set; }
        public decimal TotalOtro { get; set; }
        public decimal Total { get; set; }



        public override string ToString()
        {
            return numeroMesa.ToString();
        }
    }
}
