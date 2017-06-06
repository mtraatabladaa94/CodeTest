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
    public class UsuarioEntity
    {
        [Display(Name = "Nº Usuario")]
        public int UsuarioID { get; set; }

        [Display(Name = "Nombre de Usuario")]
        public string NombreUsuario { get; set; }

        [Display(Name = "Contraseña")]
        public string Contraseña { get; set; }

        [Display(Name = "Rol")]
        public int Rol { get; set; }
    }

    public class UsuarioEntityMapping : EntityTypeConfiguration<UsuarioEntity>
    {
        public UsuarioEntityMapping()
        {
            this.ToTable("tblUsuarios");

            HasKey(c => c.UsuarioID);
            Property(c => c.UsuarioID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.NombreUsuario)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(c => c.Contraseña)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

        }
    }
}