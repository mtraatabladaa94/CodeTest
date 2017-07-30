using System;
using System.Collections.Generic;
using System.Text;

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    public partial class AuthorOfBookEntity
    {

        [Key, Column(Order = 1), ForeignKey("Author")]
        public Guid AuthorID { get; set; }

        [Key, Column(Order = 2), ForeignKey("Book")]
        public Guid BookID { get; set; }

    }

    public partial class AuthorOfBookEntity
    {

        public AuthorEntity Author { get; set; }
        
        public BookEntity Book { get; set; }

    }

    public class AuthorOfBookEntityMapping : EntityTypeConfiguration<AuthorOfBookEntity>
    {

        public AuthorOfBookEntityMapping()
        {

            this.ToTable("tblAuthorsOfBooks");

        }

    }

}
