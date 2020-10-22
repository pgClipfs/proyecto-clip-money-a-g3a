using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clip_Money.Models
{
    public class Cuenta
    {
        public int id_Cuenta { get; set; }
        public string usuario_Cvu { get; set; }
        public int Saldo { get; set; }
        public string Tipo { get; set; }
        public int Nro_Cuenta { get; set; }
    }
}

/*
 * Falta poner el atributo id_Usuario (FK)
 */

