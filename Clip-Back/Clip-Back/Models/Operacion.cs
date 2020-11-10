using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clip_Back.Models
{
    public class Operacion
    {
        /// <summary>
        /// Representa una operacion
        /// </summary>
        public Operacion()
        {

        }

        /// <summary>
        /// Identificador en la base de datos
        /// </summary>
        public int id_operacion { get; set; }

        /// <summary>
        /// Tipo de operacion
        /// </summary>
        [Required(ErrorMessage = "Debes escribir el tipo")]
        public string tipo { get; set; }

        /// <summary>
        /// Estado de la operacion
        /// </summary>
        [Required(ErrorMessage = "Ingresa el estado")]
        public string estado { get; set; }

        /// <summary>
        /// Fecha de la operacion
        /// </summary>
        [Required(ErrorMessage = "")]
        public DateTime fecha = System.DateTime.Now;

        /// <summary>
        /// Descripcion de la operacion, resumen con los datos de la misma
        /// </summary>
        [Required(ErrorMessage = "resumen de la operacion")]
        public string descripcion { get; set; }

        // Constructor para que funciones la linea de codigo donde trae el listado de operaciones de la db y se pone en una lista para la vista.
        public Operacion(DAL.Entities.Operacion operacion)
        {
            tipo = operacion.tipo;
            estado = operacion.estado;
            fecha = operacion.fecha;
            descripcion = operacion.descripcion;
        }
    }
}