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
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public string Alias { get; set; }
        public string Titular { get; set; }
        public string Cvu { get; set; }
    }
}

/*
    Falta poner el atributo id_Operacion(FK)
*/
