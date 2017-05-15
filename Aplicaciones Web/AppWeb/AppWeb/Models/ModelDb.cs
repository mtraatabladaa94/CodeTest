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

            base.OnModelCreating(modelBuilder);
        }

    }
}