using Faculty.Entities;
using Faculty.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Faculty
{
   public class FacultyContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
       // public DbSet<Subjects> Subjects1 { get; set; }

        public FacultyContext(DbContextOptions<FacultyContext> options) : base (options)
        {
            Database.EnsureCreated();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
           // modelBuilder.ApplyConfiguration(new SubjectConfiguration());
        }
    }
}
