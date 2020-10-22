using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Clip_Money.Models
{
    public class Operacion
    {
        public int id_Operacion { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }
}

/*
 * Falta poner atributo id_Cuenta (FK)
*/