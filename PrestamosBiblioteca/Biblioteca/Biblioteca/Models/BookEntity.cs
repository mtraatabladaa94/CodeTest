using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Models
{

    public partial class BookEntity
    {

        public Guid BookID { get; set; }

        public String TypeDoc { get; set; }

        public String TopographicalSignature { get; set; }

        public String Title { get; set; }

        public String SubTitle { get; set; }

        public Nullable<int> Edition { get; set; }

        public Nullable<int> Volume { get; set; }

        public String ISBN { get; set; }

        public String Language { get; set; }

        public String DayOfPublication { get; set; }

        public Boolean IsActive { get; set; }

        public Guid EditorialID { get; set; }
        
    }

    public partial class BookEntity
    {

        public virtual ICollection<AuthorOfBookEntity> AuthorsOfBooks { get; set; }

        public virtual EditorialEntity Editorial { get; set; }

        public virtual ICollection<CopyOfBookEntity> CopiesOfBook { get; set; }

    }

    public class BookEntityMapping : EntityTypeConfiguration<BookEntity>
    {

        public BookEntityMapping ()
	    {

            this.ToTable("tblBooks");

            this.HasKey(c => c.BookID);

	    }

    }
}