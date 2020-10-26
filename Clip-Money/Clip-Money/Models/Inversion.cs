using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Clip_Money.Models
{
    public class Inversion
    {
        public int id_Inversion { get; set; }
        public DateTime Fecha { get; set; }
        public int Monto_capital { get; set; }
        public int Monto_ganancias { get; set; }

    }
}

/*
 * Falta poner el atributo id_Operacion (FK)
*/
