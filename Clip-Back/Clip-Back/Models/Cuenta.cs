using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clip_Back.Models
{
    public class Cuenta
    {

        /// <summary>
        /// Representa una cuenta
        /// </summary>
        public Cuenta()
        {

        }

        /// <summary>
        /// Identificador en la base de datos
        /// </summary>
        public int id_cuenta { get; set; }

        /// <summary>
        /// Cvu_usuario de la cuenta
        /// </summary>
        [Required(ErrorMessage = "Debes escribir el usuario_cvu de la cuenta")]
        public string usuario_cvu { get; set; }

        /// <summary>
        /// Saldo de la cuenta
        /// </summary>
        [Required(ErrorMessage = "Ingresa el saldo de la cuenta")]
        public int saldo { get; set; }

        /// <summary>
        /// Tipo de cuenta
        /// </summary>
        [Required(ErrorMessage = "Debes completar con el tipo de cuenta")]
        public string tipo { get; set; }

        /// <summary>
        /// Numero de la cuenta
        /// </summary>
        [Required(ErrorMessage = "Debes completar el numero de cuenta")]
        public int nro_cuenta { get; set; }

        public int id_Usuario { get; set; }

        public Usuario Usuario { get; set; }

        // Constructor para que funciones la linea de codigo donde trae el listado de cuentas de la db y se pone en una lista para la vista.
        public Cuenta(DAL.Entities.Cuenta cuenta)
        {
            id_cuenta = cuenta.id_cuenta;
            usuario_cvu = cuenta.usuario_cvu;
            saldo = cuenta.saldo;
            tipo = cuenta.tipo;
            nro_cuenta = cuenta.nro_cuenta;
            id_Usuario = cuenta.id_Usuario;
        }


    }
}