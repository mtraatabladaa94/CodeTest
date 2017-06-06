using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Collections.ObjectModel;

namespace AppWeb.Models
{
    public partial class CategoriaEntity
    {
        [Display(Name="Nº Categoria")]
        public int CategoriaID { get; set; }

        [Display(Name= "Nombre de la Categoria")]
        public string Nombre { get; set; }

    }

    public partial class CategoriaEntity
    {
        public CategoriaEntity()
        {
            //this.Productos = new HashSet<ProductoEntity>();
        }
        public virtual ObservableCollection<ProductoEntity> Productos { get; set; }
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