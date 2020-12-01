using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clip_Back.Models
{
    public class Factura
    {

        // <summary>
        /// Representa una Factura
        /// </summary>
        public Factura()
        {

        }


        /// <summary>
        /// Identificador en la base de datos
        /// </summary>
        public int Nro_factura { get; set; }

        /// <summary>
        /// Fecha de la factura
        /// </summary>
        public string Fecha { get; set; }

        /// <summary>
        /// Fecha de vencimiento de la factura
        /// </summary>
        public string Fecha_Vencimiento { get; set; }

        /// <summary>
        /// Monto de la factura
        /// </summary>
        public int Monto { get; set; }

        // Constructor para que funciones la linea de codigo donde trae el listado de facturas de la db y se pone en una lista para la vista.
        public Factura(DAL.Entities.Factura factura)
        {
            Fecha = factura.Fecha.ToString();
            Fecha_Vencimiento = factura.Fecha_Vencimiento.ToString();
            Monto = factura.Monto;

        }
    }
}