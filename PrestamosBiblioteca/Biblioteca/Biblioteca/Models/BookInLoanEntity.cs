using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    public partial class BookInLoanEntity
    {

        [Column(Order = 0), Key(), ForeignKey("CopyOfBook")]
        public Guid CopyID { get; set; }

        [Column(Order = 1), Key(), ForeignKey("Loan")]
        public Guid LoanID { get; set; }

    }

    public partial class BookInLoanEntity
    {

        public virtual CopyOfBookEntity CopyOfBook { get; set; }

        public virtual EntityLoan Loan { get; set; }

    }

    public class EntityBookInLoanMapping : EntityTypeConfiguration<BookInLoanEntity>
    {

        public EntityBookInLoanMapping()
        {

            this.ToTable("tblBooksInLoans");
            
        }

    }

}
