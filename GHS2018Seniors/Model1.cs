namespace GHS2018Seniors
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ParentStudentContact> ParentStudentContacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParentStudentContact>()
                .Property(e => e.ContactFName)
                .IsUnicode(false);

            modelBuilder.Entity<ParentStudentContact>()
                .Property(e => e.ContactLName)
                .IsUnicode(false);

            modelBuilder.Entity<ParentStudentContact>()
                .Property(e => e.StudentFName)
                .IsUnicode(false);

            modelBuilder.Entity<ParentStudentContact>()
                .Property(e => e.StudentLName)
                .IsUnicode(false);
        }
    }
}
