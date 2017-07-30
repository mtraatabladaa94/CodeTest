using System;
using System.Collections.Generic;
using System.Text;

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    public partial class EditorialEntity
    {

        public Guid EditorialID { get; set; }

        public String EditorName { get; set; }

        public String Location { get; set; }

    }

    public partial class EditorialEntity
    {

        public virtual ICollection<BookEntity> Books { get; set; }

    }

    public class EntityEditorialMapping : EntityTypeConfiguration<EditorialEntity>
    {

        public EntityEditorialMapping()
        {

            this.ToTable("tblEditorials");

            this.HasKey(c => c.EditorialID);

        }

    }

}
