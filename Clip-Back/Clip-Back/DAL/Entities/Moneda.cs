using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clip_Back.DAL.Entities
{
    public class Moneda
    {
        /// <summary>
        /// Constructor vacio
        /// </summary>

        public Moneda()
        {

        }

        /// <summary>
        /// Constructor de mapeo con entidad modelo
        /// </summary>
        /// <param name="moneda"></param>
        public Moneda(Models.Moneda moneda)
        {
            tipo = moneda.tipo;
            valoractual = moneda.valoractual;
            id_inversion = moneda.id_inversion;
 
        }


        /// <summary>
        /// Representa la columna Id en la tabla moneda
        /// </summary>
        [Key]
        public int id_moneda { get; set; }

        /// <summary>
        /// Representa la columna tipo en la tabla moneda
        /// </summary>
        public string tipo { get; set; }

        /// <summary>
        /// Representa la columna valoractual en la tabla moneda
        /// </summary>
        public int valoractual { get; set; }

        public int id_inversion { get; set; }

        public Inversion Inversion { get; set; }

    }
}