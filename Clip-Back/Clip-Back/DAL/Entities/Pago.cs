using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clip_Back.DAL.Entities
{
    public class Pago
    {

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Pago()
        {

        }


        /// <summary>
        /// Constructor de mapeo con entidad modelo
        /// </summary>
        /// <param name="pago"></param>
        public Pago(Models.Pago pago)
        {
            Monto = pago.Monto;
            Fecha = Convert.ToDateTime(pago.Fecha);
            Tipo = pago.Tipo;
            Estado = pago.Estado;
            Alias = pago.Alias;
            Titular = pago.Titular;
            Cvu = pago.Cvu;
        }

        /// <summary>
        /// Representa la columna Id en la tabla pago
        /// </summary>
        [Key]
        public int id_Pago { get; set; }

        /// <summary>
        /// Representa la columna Monto en la tabla pago
        /// </summary>
        public int Monto { get; set; }

        /// <summary>
        /// Representa la columna Fecha en la tabla pago
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Representa la columna Tipo en la tabla pago
        /// </summary>
        public string Tipo { get; set; }

        /// <summary>
        /// Representa la columna Estado en la tabla pago
        /// </summary>
        public string Estado { get; set; }

        /// <summary>
        /// Representa la columna Alias en la tabla pago
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// Representa la columna Titular en la tabla pago
        /// </summary>
        public string Titular { get; set; }

        /// <summary>
        /// Representa la columna Cvu en la tabla pago
        /// </summary>
        public string Cvu { get; set; }


    }
}