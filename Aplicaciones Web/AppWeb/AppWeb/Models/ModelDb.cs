using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace AppWeb.Models
{
    public class ModelDb : DbContext
    {
        public ModelDb()
            : base("name=CadenaConexion")
        {

        }

        public DbSet<ProductoEntity> Productos { get; set; }
        public DbSet<CategoriaEntity> Categorias { get; set; }
        public DbSet<ClienteEntity> Clientes { get; set; }
        public DbSet<UsuarioEntity> Usuarios { get; set; }
        public DbSet<VentaEntity> Ventas { get; set; }
        public DbSet<VentaDetalleEntity> VentasDetalles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Conventions
                .Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(
                new ProductoEntityMapping()
            );

            modelBuilder.Configurations.Add(
                new CategoriaEntityMapping()
            );

            modelBuilder.Configurations.Add(
                new ClienteEntityMapping()
            );
            modelBuilder.Configurations.Add(
                new UsuarioEntityMapping()
            );
            modelBuilder.Configurations.Add(
                new VentaDetalleEntityMapping()
            );
            modelBuilder.Configurations.Add(
                new VentaDetalleEntityMapping()
            );

            base.OnModelCreating(modelBuilder);
        }

    }
}