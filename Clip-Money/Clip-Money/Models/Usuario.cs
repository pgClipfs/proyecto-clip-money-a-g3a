using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Clip_Money.Models
{
    public class Usuario
    {
        public int id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Cuenta { get; set; }
        public string Contraseña { get; set; }
        public int Edad { get; set; }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public DateTime Fecha_Registro { get; set; }
    }
}
