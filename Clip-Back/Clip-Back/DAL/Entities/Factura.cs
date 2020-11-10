using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clip_Back.DAL.Entities
{
    public class Factura
    {

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Factura()
        {

        }

        /// <summary>
        /// Constructor de mapeo con entidad modelo
        /// </summary>
        /// <param name="factura"></param>
        public Factura(Models.Factura factura)
        {
            Fecha = Convert.ToDateTime(factura.Fecha);
            Fecha_Vencimiento = Convert.ToDateTime(factura.Fecha_Vencimiento);
            Monto = factura.Monto;
        }


        /// <summary>
        /// Representa la columna Nro_factura en la tabla factura
        /// </summary>
        [Key]
        public int Nro_factura { get; set; }

        /// <summary>
        /// Representa la columna Fecha en la tabla factura
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Representa la columna Fecha_vencimiento en la tabla factura
        /// </summary>
        public DateTime Fecha_Vencimiento { get; set; }

        /// <summary>
        /// Representa la columna Monto en la tabla factura
        /// </summary>
        public int Monto { get; set; }
    }
}