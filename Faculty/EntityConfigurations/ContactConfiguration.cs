using Faculty.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;


namespace Faculty.EntityConfigurations
{
    class ContactConfiguration : IEntityTypeConfiguration<Contacts>
    {
        

        public void Configure(EntityTypeBuilder<Contacts> builder)
        {
            builder.ToTable("Contacts", schema: "dbo");   
            builder.HasKey(p => p.StudentID);
            builder.HasKey(p => p.TeacherID);
            builder.Property(C=> C.City).HasColumnType("nvarchar(25)");
            builder.Property(A => A.Address).HasColumnType("nvarchar(25)");
            builder.Property(P => P.Phone).HasColumnType("char(9)");
            builder.Property(E => E.Email).HasColumnType("varchar(30)");



            // foreign key
            builder.HasOne(x => x.student)
                .WithMany  (x => x.Contacts)
                .HasForeignKey(x => x.StudentID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.teacher)
              .WithMany(x => x.Contacts)
              .HasForeignKey(x => x.TeacherID)
              .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
