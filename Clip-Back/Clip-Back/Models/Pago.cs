using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clip_Back.Models
{
    public class Pago
    {
        /// <summary>
        /// Representa un Pago
        /// </summary>
        public Pago()
        {

        }

        /// <summary>
        /// Identificador en la base de datos
        /// </summary>
        public int id_Pago { get; set; }

        /// <summary>
        /// Monto del pago
        /// </summary>
        public int Monto { get; set; }

        /// <summary>
        /// Fecha del pago
        /// </summary>
        public DateTime Fecha = System.DateTime.Now;

        /// <summary>
        /// Tipo de pago
        /// </summary>
        public string Tipo { get; set; }

        /// <summary>
        /// Estado del pago
        /// </summary>
        public string Estado { get; set; }


        /// <summary>
        /// Alias del Servicio al que se efectua el pago
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// Titular del pago
        /// </summary>
        public string Titular { get; set; }


        /// <summary>
        /// Cvu del servicio
        /// </summary>
        public string Cvu { get; set; }

        public int id_Servicio { get; set; }

        public Servicio Servicio { get; set; }


        // Constructor para que funciones la linea de codigo donde trae el listado de pagos de la db y se pone en una lista para la vista.
        public Pago(DAL.Entities.Pago pago)
        {
            Monto = pago.Monto;
            Fecha = pago.Fecha;
            Tipo = pago.Tipo;
            Estado = pago.Estado;
            Alias = pago.Alias;
            Titular = pago.Titular;
            Cvu = pago.Cvu;
            id_Servicio = pago.id_Servicio;
        }

    }
}