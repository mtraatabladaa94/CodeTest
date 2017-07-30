using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Models
{

    public partial class AuthorEntity
    {
        public Guid AuthorID { get; set; }

        public String Name { get; set; }

        public String LastName { get; set; }
    }

    public partial class AuthorEntity
    {

        public virtual ICollection<AuthorOfBookEntity> AuthorsOfBooks { get; set; }

    }

    public class AuthorEntityMapping : EntityTypeConfiguration<AuthorEntity>
    {

        public AuthorEntityMapping()
        {

            this.ToTable("tblAuthors");

            this.HasKey(c => c.AuthorID);

        }

    }

}