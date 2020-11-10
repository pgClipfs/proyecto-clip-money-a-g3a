using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clip_Back.Models
{
    public class Inversion
    {
        public Inversion() 
        {

        }

        /// <summary>
        /// Identificador en la base de datos
        /// </summary>
        public int id_inversion { get; set; }

        /// <summary>
        /// fecha en que se inicie la inversion, se genera automaticamente
        /// </summary>
        public DateTime fecha = System.DateTime.Now;

        /// <summary>
        /// monto con el que se inicia la inversion
        /// </summary> 
        public int monto_capital { get; set; }

        /// <summary>
        /// monto resultante
        /// </summary> 
        public int monto_ganancia { get; set; }

        public Inversion(DAL.Entities.Inversion inversion)
        {
            id_inversion = inversion.id_inversion;
            fecha = inversion.fecha;
            monto_capital = inversion.monto_capital;
            monto_ganancia = inversion.monto_ganancia;
        }

    }
}