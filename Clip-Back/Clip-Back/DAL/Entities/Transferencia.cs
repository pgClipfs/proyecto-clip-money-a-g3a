using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Clip_Back.DAL.Entities
{
    public class Transferencia
    {


        /// <summary>
        /// Constructor vacio
        /// </summary>

        public Transferencia()
        {

        }

        /// <summary>
        /// Constructor de mapeo con entidad modelo
        /// </summary>
        /// <param name="transferencia"></param>
        public Transferencia(Models.Transferencia transferencia)
        {
            fecha = Convert.ToDateTime(transferencia.fecha);
            cvu_origen = transferencia.cvu_origen;
            cvu_destino = transferencia.cvu_destino;
            cbu_destino = transferencia.cbu_destino;
            monto = transferencia.monto;
        }


        /// <summary>
        /// Representa la columna Id en la tabla transferencia
        /// </summary>
        [Key]
        public int id_transferencia { get; set; }

        /// <summary>
        /// Representa la columna Fecha en la tabla transferencia
        /// </summary>
        public DateTime fecha { get; set; }

        /// <summary>
        /// Representa la columna cvu_origen en la tabla transferencia
        /// </summary>
        public string cvu_origen { get; set; }

        /// <summary>
        /// Representa la columna cvu_destino en la tabla transferencia
        /// </summary>
        public string cvu_destino { get; set; }

        /// <summary>
        /// Representa la columna cbu_destino en la tabla transferencia
        /// </summary>
        public int cbu_destino { get; set; }

        /// <summary>
        /// Representa la columna monto en la tabla transferencia
        /// </summary>
        public int monto { get; set; }

    }
}