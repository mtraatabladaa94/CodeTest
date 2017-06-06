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
    public partial class VentaDetalleEntity
    {
        public int DetalleVentaID { get; set; }

        [Display(Name = "Cantidad")]
        public decimal Cantidad { get; set; }

        [Display(Name = "Precio")]
        public decimal Precio { get; set; }

        [Display(Name = "Venta")]
        public Guid VentaID { get; set; }

        [Display(Name = "Producto")]
        public int ProductoID { get; set; }

    }

    public partial class VentaDetalleEntity
    {
        public virtual VentaEntity Venta { get; set; }

        public virtual ProductoEntity Producto { get; set; }
    }

    public class VentaDetalleEntityMapping : EntityTypeConfiguration<VentaDetalleEntity>
    {
        public VentaDetalleEntityMapping()
        {
            this.ToTable("tblVentasDetalles");

            HasKey(c => c.DetalleVentaID);
            Property(c => c.DetalleVentaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}