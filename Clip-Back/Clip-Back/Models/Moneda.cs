using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clip_Back.Models
{
    public class Moneda
    {

        /// <summary>
        /// Representa una moneda
        /// </summary>
        public Moneda()
        {

        }

        /// <summary>
        /// Identificador en la base de datos
        /// </summary>
        public int id_moneda { get; set; }

        /// <summary>
        /// Tipo de moneda
        /// </summary>
        [Required(ErrorMessage = "Debes escribir el tipo de moneda (dolar, criptomoneda)")]
        public string tipo { get; set; }

        /// <summary>
        /// Representa el valor en pesos de una moneda
        /// </summary>
        [Required(ErrorMessage = "Ingresa el valor en pesos")]
        public int valoractual { get; set; }

        public int id_inversion { get; set; }

        public Inversion Inversion { get; set; }
     
        // Constructor para que funciones la linea de codigo donde trae el listado de moneda de la db y se pone en una lista para la vista.
        public Moneda(DAL.Entities.Moneda moneda)
        {
            tipo = moneda.tipo;
            valoractual = moneda.valoractual;
            id_inversion = moneda.id_inversion;
        }
    }
}