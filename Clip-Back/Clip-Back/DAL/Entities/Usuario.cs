using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clip_Back.DAL.Entities
{
    public class Usuario
    {

        /// <summary>
        /// Constructor vacio
        /// </summary>

        public Usuario ()
        {

        }

        /// <summary>
        /// Constructor de mapeo con entidad modelo
        /// </summary>
        /// <param name="usuario"></param>
        public Usuario (Models.Usuario usuario)
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
            fecha_registro = Convert.ToDateTime(usuario.fecha_registro);
        }


        /// <summary>
        /// Representa la columna Id en la tabla usuario
        /// </summary>
        [Key]
        public int id_usuario { get; set; }

        /// <summary>
        /// Representa la columna Nombre en la tabla usuario
        /// </summary>
        public string nombre { get; set; }

        /// <summary>
        /// Representa la columna Apellido en la tabla usuario
        /// </summary>
        public string apellido { get; set; }

        /// <summary>
        /// Representa la columna dni en la tabla usuario
        /// </summary>
        public int dni { get; set; }

        /// <summary>
        /// Representa la columna cuenta en la tabla usuario
        /// </summary>
        public string cuenta { get; set; }

        /// <summary>
        /// Representa la columna contraseña en la tabla usuario
        /// </summary>
        public string contraseña { get; set; }

        /// <summary>
        /// Representa la columna edad en la tabla usuario
        /// </summary>
        public DateTime fecha_nacimiento { get; set; }

        /// <summary>
        /// Representa la columna nro_telefono en la tabla usuario
        /// </summary>
        public int nro_telefono { get; set; }

        /// <summary>
        /// Representa la columna domicilio en la tabla usuario
        /// </summary>
        public string domicilio { get; set; }

        /// <summary>
        /// Representa la columna email en la tabla usuario
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// Representa la columna fecha de registro en la tabla usuario
        /// </summary>
        public DateTime fecha_registro { get; set; }

    }
}