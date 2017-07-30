using System;
using System.Collections.Generic;
using System.Text;

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    public partial class CopyOfBookEntity
    {
        public Guid CopyID { get; set; }

        public Guid BookID { get; set; }

        public Guid CopyNumber { get; set; }

        public Guid RegisterNumber { get; set; }

        public Boolean IsActive { get; set; }
    }

    public partial class CopyOfBookEntity
    {

        public virtual BookEntity Book { get; set; }

        public virtual ICollection<BookInLoanEntity> BooksInLoans { get; set; }

    }

    public class EntityCopyOfBookMapping : EntityTypeConfiguration<CopyOfBookEntity>
    {

        public EntityCopyOfBookMapping()
        {

            this.ToTable("tblCopiesOfBooks");

            this.HasKey(c => c.CopyID);

        }

    }
    
}