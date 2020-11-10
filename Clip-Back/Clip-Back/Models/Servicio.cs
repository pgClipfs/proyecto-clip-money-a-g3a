using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clip_Back.Models
{
    public class Servicio
    {
        /// <summary>
        /// Representa un servicio
        /// </summary>
        public Servicio()
        {

        }

        /// <summary>
        /// Identificador en la base de datos
        /// </summary>
        public int id_servicio { get; set; }

        /// <summary>
        /// Nombre del servicio
        /// </summary>
        [Required(ErrorMessage = "Debes escribir el nombre")]
        public string nombre { get; set; }

        /// <summary>
        /// Cvu del servicio
        /// </summary>
        [Required(ErrorMessage = "Ingresa el cvu del servicio")]
        public string cvu_servicio { get; set; }

        // Constructor para que funciones la linea de codigo donde trae el listado de servicios de la db y se pone en una lista para la vista.
        public Servicio(DAL.Entities.Servicio servicio)
        {
            id_servicio = servicio.id_servicio;
            nombre = servicio.nombre;
            cvu_servicio = servicio.cvu_servicio;
        }
        // FALTA PONER FK NRO_FACTURA
    }
}

 