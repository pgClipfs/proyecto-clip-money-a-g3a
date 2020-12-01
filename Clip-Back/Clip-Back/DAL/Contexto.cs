using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Clip_Back.DAL.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Clip_Back.DAL
{

    /// <summary>
    /// Representa el contexto de la base de datos
    /// </summary>
    public class Contexto : DbContext
    {
        /// <summary>
        /// Constructor con parametros para constructor de clase madre
        /// </summary>
        public Contexto() : base("Contexto")
        {

        }

        /// <summary>
        /// DbSet Usuario
        /// </summary>
        public DbSet<Usuario> Usuarios { get; set; }

        /// <summary>
        /// DbSet Moneda
        /// </summary>
        public DbSet<Moneda> Monedas { get; set; }

        /// <summary>
        /// DbSet Operacion
        /// </summary>
        public DbSet<Operacion> Operaciones { get; set; }

        /// <summary>
        /// DbSet Servicio
        /// </summary>
        public DbSet<Servicio> Servicios { get; set; }

        /// <summary>
        /// DbSet Transferencia
        /// </summary>
        public DbSet<Transferencia> Transferencias { get; set; }

        /// <summary>
        /// DbSet Cuenta
        /// </summary>
        public DbSet<Cuenta> Cuentas { get; set; }


        /// <summary>
        /// DbSet Pago
        /// </summary>
        public DbSet<Pago> Pagos { get; set; }

        /// <summary>
        /// DbSet Cuenta
        /// </summary>
        public DbSet<Factura> Facturas { get; set; }

        /// <summary>
        /// DbSet Inversion
        /// </summary>
        public DbSet<Inversion> Inversiones { get; set; }

        public DbSet<Login> Login { get; set; }

        /// <summary>
        /// Sobreescritura del metodo "En creacion del modelo"
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Quitamos la convencion de pluralización de nombres de tablas (sin esto, EF pasaria las tablas a plural)
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        
    }
}