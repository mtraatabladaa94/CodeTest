using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using Biblioteca.Models.POCO;

namespace Biblioteca.Models
{

    public class ModelDb : DbContext
    {

        public ModelDb() : 
            base("Name=DefaultConnection")
        {

        }

        //listados pluralizados
        public DbSet<EntityArea> Areas { get; set; }
        public DbSet<EntityAuthor> Authors { get; set; }
        public DbSet<EntityAuthorOfBook> AuthorsOfBooks { get; set; }
        public DbSet<EntityBook> Books { get; set; }
        public DbSet<BookInLoanEntity> BooksInLoans { get; set; }
        public DbSet<CopyOfBookEntity> CopiesOfBooks { get; set; }
        public DbSet<EntityEditorial> Editorials { get; set; }
        public DbSet<EntityEmployee> Employees { get; set; }
        public DbSet<EntityInstitution> Institutions { get; set; }
        public DbSet<EntityInstitutionOfBook> InstitutionsOfBooks { get; set; }
        public DbSet<EntityLoan> Loans { get; set; }
        public DbSet<EntityPearson> Pearsons { get; set; }
        public DbSet<EntityProfile> Profiles { get; set; }
        public DbSet<EntityStudent> Students { get; set; }
        public DbSet<EntityStudentInCareer> StudentsInCareers { get; set; }
        public DbSet<EntityTeacher> Teachers { get; set; }
        public DbSet<EntityTeacherInCareer> TeachersInCareers { get; set; }
        public DbSet<EntityUniversityCareer> UniversityCareers { get; set; }
        public DbSet<EntityUniversityDepartment> UniversityDepartments { get; set; }
        public DbSet<EntityUserOfBook> UsersOfBooks { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // convenciones
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

            // añadiendo configuración a entidades
            modelBuilder.Configurations.Add(new EntityAreaMapping());
            modelBuilder.Configurations.Add(new EntityAuthorMapping());
            modelBuilder.Configurations.Add(new EntityAuthorOfBookMapping());
            modelBuilder.Configurations.Add(new EntityBookMapping());
            modelBuilder.Configurations.Add(new EntityBookInLoanMapping());
            modelBuilder.Configurations.Add(new EntityCopyOfBookMapping());
            modelBuilder.Configurations.Add(new EntityEditorialMapping());
            modelBuilder.Configurations.Add(new EntityEmployeeMapping());
            modelBuilder.Configurations.Add(new EntityInstitutionMapping());
            modelBuilder.Configurations.Add(new EntityInstitutionOfBookMapping());
            modelBuilder.Configurations.Add(new EntityLoanMapping());
            modelBuilder.Configurations.Add(new EntityPearsonMapping());
            modelBuilder.Configurations.Add(new EntityStudentMapping());
            modelBuilder.Configurations.Add(new EntityStudentInCareerMapping());
            modelBuilder.Configurations.Add(new EntityTeacherMapping());
            modelBuilder.Configurations.Add(new EntityTeacherInCareerMapping());
            modelBuilder.Configurations.Add(new EntityTransactionMapping());
            modelBuilder.Configurations.Add(new EntityUniversityCareerMapping());
            modelBuilder.Configurations.Add(new EntityUniversityDepartmentMapping());
            modelBuilder.Configurations.Add(new EntityUserOfBookMapping());

            // método superclase
            base.OnModelCreating(modelBuilder);
            
        }

    }

}
