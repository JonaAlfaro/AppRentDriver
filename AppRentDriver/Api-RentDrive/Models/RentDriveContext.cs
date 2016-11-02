using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_RentDrive.Models
{
    public class RentDriveContext : DbContext
    {
        public RentDriveContext() : base("RentDriveContext")
        {

        }

        public DbSet<Automovil> Automoviles { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Reserva> Reservaciones { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }

        public override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConventions>();
        }
    }
}