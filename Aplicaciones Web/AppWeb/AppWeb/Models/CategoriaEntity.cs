using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AppWeb.Models
{
    public partial class CategoriaEntity
    {

        public int CategoriaID { get; set; }

        [Display(Name= "Categoria")]
        public string Nombre { get; set; }

    }

    public partial class CategoriaEntity
    {

    }

    public class CategoriaEntityMapping : EntityTypeConfiguration<CategoriaEntity>
    {
        public CategoriaEntityMapping()
        {
            ToTable("tblCategorias");

            HasKey(c=> c.CategoriaID);
            Property(c => c.CategoriaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Nombre)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

        }
    }
}