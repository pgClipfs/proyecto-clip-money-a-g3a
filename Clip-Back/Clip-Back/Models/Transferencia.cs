using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clip_Back.Models
{
    public class Transferencia
    {

        /// <summary>
        /// Representa una transferencia
        /// </summary>
        public Transferencia()
        {

        }

        /// <summary>
        /// Identificador en la base de datos
        /// </summary>
        public int id_transferencia { get; set; }

        /// <summary>
        /// Fecha de la transferencia
        /// </summary>
        [Required(ErrorMessage = "Debes escribir la fecha")]
        public DateTime fecha = System.DateTime.Now;

        /// <summary>
        /// Cvu origen de la transferencia
        /// </summary>
        [Required(ErrorMessage = "Ingresa el Cvu de la cuenta origen")]
        public string cvu_origen { get; set; }

        /// <summary>
        /// Cvu destino de la transferencia
        /// </summary>
        [Required(ErrorMessage = "Ingresa el Cvu de la cuenta destino")]
        public string cvu_destino { get; set; }

        /// <summary>
        /// Cbu destino de la transferencia
        /// </summary>
        [Required(ErrorMessage = "Ingresa el Cbu de la cuenta destino")]
        public int cbu_destino { get; set; }

        /// <summary>
        /// Monto de la transferencia
        /// </summary>
        [Required(ErrorMessage = "Debes completar el monto de la transferencia")]
        public int monto { get; set; }

        public int id_operacion { get; set; }

        public Operacion Operacion { get; set; } 


        // Constructor para que funciones la linea de codigo donde trae el listado de transferencias de la db y se pone en una lista para la vista.
        public Transferencia(DAL.Entities.Transferencia transferencia)
        {
            id_transferencia = transferencia.id_transferencia;
            fecha = transferencia.fecha;
            cvu_origen = transferencia.cvu_origen;
            cvu_destino = transferencia.cvu_destino;
            cbu_destino = transferencia.cbu_destino;
            monto = transferencia.monto;
            id_operacion = transferencia.id_operacion;
        }

    }
}
