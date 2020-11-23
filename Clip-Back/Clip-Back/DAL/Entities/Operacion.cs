using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clip_Back.DAL.Entities
{
    public class Operacion
    {
        /// <summary>
        /// Constructor vacio
        /// </summary>

        public Operacion()
        {

        }

        /// <summary>
        /// Constructor de mapeo con entidad modelo
        /// </summary>
        /// <param name="operacion"></param>
        public Operacion(Models.Operacion operacion)
        {
            tipo = operacion.tipo;
            estado = operacion.estado;
            fecha = Convert.ToDateTime(operacion.fecha);
            descripcion = operacion.descripcion;
            id_cuenta = operacion.id_cuenta;
        }

        /// <summary>
        /// Representa la columna Id en la tabla operacion
        /// </summary>
        [Key]
        public int id_operacion { get; set; }

        /// <summary>
        /// Representa la columna tipo en la tabla operacion
        /// </summary>
        public string tipo { get; set; }

        /// <summary>
        /// Representa la columna estado en la tabla operacion
        /// </summary>
        public string estado { get; set; }

        /// <summary>
        /// Representa la columna fecha de la operacion en la tabla operacion
        /// </summary>
        public DateTime fecha { get; set; }

        /// <summary>
        /// Representa la columna descripcion en la tabla operacion
        /// </summary>
        public string descripcion { get; set; }

        public int id_cuenta { get; set; }

        public Cuenta Cuenta { get; set; }

    }
}