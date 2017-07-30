using System;
using System.Collections.Generic;
using System.Text;

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    public partial class EntityLoan
    {

        public Guid LoanID { get; set; }

        public long LoanNumber { get; set; }

        public DateTime LoanDate { get; set; }

        public String LoanObservation { get; set; }

        public Boolean IsActive { get; set; }

        public Guid ProfileID { get; set; }

        public Guid PearsonID { get; set; }

    }

    public partial class EntityLoan
    {

        public virtual EntityPearson PearsonEntity { get; set; }

        public virtual ICollection<BookInLoanEntity> BooksInLoans { get; set; }
        
    }

    public class EntityLoanMapping : EntityTypeConfiguration<EntityLoan>
    {

        public EntityLoanMapping()
        {

            this.ToTable("tblLoans");

            this.HasKey(c => c.LoanID);

        }

    }
}