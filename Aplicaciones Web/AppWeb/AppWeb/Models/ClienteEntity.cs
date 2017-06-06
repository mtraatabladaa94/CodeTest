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
    public partial class ClienteEntity
    {

        [Display(Name = "Nº")]
        public int ClienteID { get; set; }
         
        [Display(Name = "Cédula")]
        public string Cedula { get; set; }

        [Display(Name = "Nombres")]
        public string Nombres { get; set; }

        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }

        [Display(Name = "E - Mail")]
        public string Email { get; set; }

        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

    }

    public partial class ClienteEntity
    {
        public ClienteEntity()
        {
            //this.Productos = new HashSet<ProductoEntity>();
        }
        public virtual ICollection<VentaEntity> Ventas { get; set; }
    }

    public class ClienteEntityMapping : EntityTypeConfiguration<ClienteEntity>
    {
        public ClienteEntityMapping()
        {
            this.ToTable("tblClientes");

            HasKey(c => c.ClienteID);
            Property(c => c.ClienteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Cedula)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(16);

            Property(c => c.Nombres)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(c => c.Apellidos)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(c => c.Email)
                .IsOptional()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(c => c.Telefono)
                .IsOptional()
                .HasColumnType("varchar")
                .HasMaxLength(9);

            Property(c => c.Direccion)
                .IsOptional()
                .HasColumnType("varchar")
                .HasMaxLength(500);

        }
    }

    
}