using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Clip_Money.Models
{
    public class Pago
    {
        public int id_Pago { get; set; }
        public int Monto { get; set; }
        public DateTime Fecha { get; set; }
        public int Tipo { get; set; }
        public bool Estado { get; set; }
        public string Alias { get; set; }
        public string Titular { get; set; }
        public string CVU { get; set; }
    }
}