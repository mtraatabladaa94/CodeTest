using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AppWeb.Models
{
    public partial class ProductoEntity
    {

        public int ProductoID { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [Display(Name= "Categoria")]
        public int CategoriaID { get; set; }

    }

    public partial class ProductoEntity
    {
        [Display(Name = "Categoria")]
        public virtual CategoriaEntity CategoriaEntity { get; set; }
    }

    public class ProductoEntityMapping : EntityTypeConfiguration<ProductoEntity>
    {

        public ProductoEntityMapping()
        {
            ToTable("tblProductos");

            HasKey(c=> c.ProductoID);
            Property(c => c.ProductoID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Nombre)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(c => c.Descripcion)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(c => c.CategoriaID)
                .IsRequired();

        }

    }

}