using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Clip_Back.DAL.Entities
{
    public class Inversion
    {
        /// <summary>
        /// Constructor vacio
        /// </summary>
        /// 
        public Inversion () 
        {

        }

        /// <summary>
        /// Constructor de mapeo con entidad modelo
        /// </summary>
        /// <param name="inversion"></param>
        public Inversion (Models.Inversion inversion)
        {
            fecha = Convert.ToDateTime(inversion.fecha);
            monto_capital = inversion.monto_capital;
            monto_ganancia = inversion.monto_ganancia;
            id_operacion = inversion.id_operacion;
        }

        /// <summary>
        /// Identificador en la base de datos
        /// </summary>
        [Key]
        public int id_inversion { get; set; }

        /// <summary>
        /// fecha en que se inicie la inversion, se genera automaticamente
        /// </summary>
        public DateTime fecha { get; set; }

        /// <summary>
        /// monto con el que se inicia la inversion
        /// </summary> 
        public int monto_capital { get; set; }

        /// <summary>
        /// monto resultante
        /// </summary> 
        public int monto_ganancia { get; set; }

        public int id_operacion { get; set; }

        public Operacion Operacion { get; set; }
    }
}