using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clip_Back.DAL.Entities
{
    public class Cuenta
    {


        /// <summary>
        /// Constructor vacio
        /// </summary>

        public Cuenta()
        {

        }

        /// <summary>
        /// Constructor de mapeo con entidad modelo
        /// </summary>
        /// <param name="cuenta"></param>
        public Cuenta(Models.Cuenta cuenta)
        {
            usuario_cvu = cuenta.usuario_cvu;
            saldo = cuenta.saldo;
            tipo = cuenta.tipo;
            nro_cuenta = cuenta.nro_cuenta;
        }


        /// <summary>
        /// Representa la columna Id en la tabla cuenta
        /// </summary>
        [Key]
        public int id_cuenta { get; set; }

        /// <summary>
        /// Representa la columna usuario_cvu en la tabla cuenta
        /// </summary>
        public string usuario_cvu { get; set; }

        /// <summary>
        /// Representa la columna saldo en la tabla cuenta
        /// </summary>
        public int saldo { get; set; }

        /// <summary>
        /// Representa la columna tipo en la tabla cuenta
        /// </summary>
        public string tipo { get; set; }

        /// <summary>
        /// Representa la columna nro_cuenta en la tabla cuenta
        /// </summary>
        public int nro_cuenta { get; set; }

    }
}