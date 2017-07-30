using System;
using System.Collections.Generic;
using System.Text;

using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    public partial class EntityPearson
    {
        public Guid PearsonID { get; set; }

        public String PearsonKey { get; set; }

        public String Name { get; set; }

        public String LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public String Email { get; set; }

        public String Phone { get; set; }

        public String Address { get; set; }

        public Boolean IsActive { get; set; }
    }

    public partial class EntityPearson
    {

        public virtual ICollection<EntityLoan> Loans { get; set; }

    }

    public class EntityPearsonMapping : EntityTypeConfiguration<EntityPearson>
    {

        public EntityPearsonMapping()
        {

            this.ToTable("tblPearsons");

            this.HasKey(c => c.PearsonID);

        }

    }
    
}
