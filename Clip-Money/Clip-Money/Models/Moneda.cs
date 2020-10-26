using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Clip_Money.Models
{
    public class Moneda
    {
        public int id_Moneda { get; set; }
        public string Tipo { get; set; }
        public int ValorActual { get; set; }

    }
}

/*
 * Falta poner el atributo id_Inversion (FK)
*/
