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
    public partial class VentaEntity
    {

        public Guid VentaID { get; set; }

        [Display(Name = "Nº Factura")]
        public int NumeroFactura { get; set; }


        [Display(Name = "Fecha")]
        public DateTime FechaFactura { get; set; }

        [Display(Name = "Cliente")]
        public int ClienteID { get; set; }

        [Display(Name = "Total")]
        public decimal Total { get; set; }
    }

    public partial class VentaEntity
    {
        public VentaEntity()
        {
            //this.VentasDetalles = new HashSet<VentaDetalleEntity>();
        }

        public virtual ClienteEntity Cliente { get; set; }

        public virtual ICollection<VentaDetalleEntity> VentasDetalles { get; set; }
    }

    public class VentaEntityMapping : EntityTypeConfiguration<VentaEntity>
    {
        public VentaEntityMapping()
        {
            this.ToTable("tblVentas");

            this.HasKey(c => c.VentaID);

        }
    }
}