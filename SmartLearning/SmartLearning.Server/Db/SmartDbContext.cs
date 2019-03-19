using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLearning.Shared.Models; 

namespace SmartLearning.Server.Db
{
    public class SmartDbContext : DbContext
    {
        public SmartDbContext(DbContextOptions<SmartDbContext> SmartLearningDbContetOptions) : base(SmartLearningDbContetOptions)
        {

        }
        public DbSet<Student> Students { get; set; } 
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Examination> Examinations { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<Class>()
        //        .Property(c => c.Name).HasMaxLength(30).IsRequired(true);
        //    modelBuilder.Entity<Class>()
        //       .HasMany(c => c.Enrollments).WithOne(e => e.Class)
        //       .HasPrincipalKey(c => c.Id);
        //    modelBuilder.Entity<Class>().ToTable("");



        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
