using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clip_Back.DAL.Entities
{
    public class Servicio
    {
        /// <summary>
        /// Constructor vacio
        /// </summary>

        public Servicio()
        {

        }

        /// <summary>
        /// Constructor de mapeo con entidad modelo
        /// </summary>
        /// <param name="servicio"></param>
        public Servicio(Models.Servicio servicio)
        {
            nombre = servicio.nombre;
            cvu_servicio = servicio.cvu_servicio;
        }


        /// <summary>
        /// Representa la columna Id en la tabla servicio
        /// </summary>
        [Key]
        public int id_servicio { get; set; }

        /// <summary>
        /// Representa la columna Nombre en la tabla servicio
        /// </summary>
        public string nombre { get; set; }

        /// <summary>
        /// Representa la columna cvu_servicio en la tabla servicio
        /// </summary>
        public string cvu_servicio { get; set; }
    }
}