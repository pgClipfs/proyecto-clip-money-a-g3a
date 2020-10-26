using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clip_Money.Models
{
    public class Transferencia
    {
        public int id_Transferencia { get; set; }
        public DateTime Fecha { get; set; }
        public string Cvu_Origen { get; set; }
        public string Cvu_Destino { get; set; }
        public string Cbu_Destino { get; set; }
        public int Monto { get; set; }
    }
}

/*
 * Falta poner el atributo id_operacion (FK)
 */ 

