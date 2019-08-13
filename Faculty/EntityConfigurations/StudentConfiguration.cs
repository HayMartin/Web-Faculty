using Faculty.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Faculty.EntityConfigurations
{
    class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder.ToTable("Student", schema: "dbo");
            builder.HasKey(p => p.StudentID);
            builder.Property(p => p.StudentID).ValueGeneratedOnAdd();
            builder.Property(L => L.Lastname).HasColumnType("nvarchar(25)");
            builder.Property(F => F.FirstName).HasColumnType("nvarchar(15)");
            builder.Property(A => A.Age).HasColumnType("int");

        }
    }
}
