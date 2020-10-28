using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clip_Back.Models
{
    public class Usuario
    {

        /// <summary>
        /// Representa un usuario
        /// </summary>
        public Usuario()
        {

        }

        /// <summary>
        /// Identificador en la base de datos
        /// </summary>
        public int id_usuario { get; set; }

        /// <summary>
        /// Nombre de la persona
        /// </summary>
        [Required(ErrorMessage = "Debes escribir el nombre")]
        public string nombre { get; set; }

        /// <summary>
        /// Apellido de la persona
        /// </summary>
        [Required(ErrorMessage = "Ingresa el apellido")]
        public string apellido { get; set; }

        /// <summary>
        /// Dni de la persona
        /// </summary>
        [Required(ErrorMessage = "Debes completar el dni")]
        public int dni { get; set; }

        /// <summary>
        /// Cuenta de la persona
        /// </summary>
        [Required(ErrorMessage = "Debes completar la cuenta")]
        public string cuenta { get; set; }

        /// <summary>
        /// Contraseña de la persona
        /// </summary>
        [Required(ErrorMessage = "Debes completar la contraseña")]
        public string contraseña { get; set; }

        /// <summary>
        /// Edad de la persona
        /// </summary>
        [Required(ErrorMessage = "Debes completar la edad")]
        public DateTime fecha_nacimiento { get; set; }

        /// <summary>
        /// Domicilio de la persona
        /// </summary>
        [Required(ErrorMessage = "Debes completar el domicilio")]
        public int nro_telefono { get; set; }

        [Required(ErrorMessage = "Debes completar el domicilio")]
        public string domicilio { get; set; }


        /// <summary>
        /// Email de la persona
        /// </summary>
        [Required(ErrorMessage = "Debes completar el email")]
        public string email { get; set; }

        /// <summary>
        /// Fecha de registro de la persona
        /// </summary>
        [Required(ErrorMessage = "Debes completar la fecha de registro")]
        public DateTime fecha_registro = System.DateTime.Now;

        // Constructor para que funciones la linea de codigo donde trae el listado de usuarios de la db y se pone en una lista para la vista.
        public Usuario(DAL.Entities.Usuario usuario)
        {
            nombre = usuario.nombre;
            apellido = usuario.apellido;
            dni = usuario.dni;
            cuenta = usuario.cuenta;
            contraseña = usuario.contraseña;
            fecha_nacimiento = usuario.fecha_nacimiento;
            nro_telefono = usuario.nro_telefono;
            domicilio = usuario.domicilio;
            email = usuario.email;
            fecha_registro = usuario.fecha_registro;
            id_usuario = usuario.id_usuario;
        }

        // REVISAR POR IMPLEMENTACION DE UNA IMAGEN DE DNI

        // IMPLEMENTAR CAMPO PARA NRO DE TELEFONO
    }
}