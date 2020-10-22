using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clip_Money.Models
{
    public class Factura
    {
        public int Nro_factura { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
        public int Monto { get; set; }
    }
}

/*
 * Hacer cambios en el diagrama de clases en los atributos de las clases Factura y Servicio.
*/