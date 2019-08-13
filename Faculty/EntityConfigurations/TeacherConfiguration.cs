using Faculty.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Faculty.EntityConfigurations
{
    class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Teacher", schema: "dbo");
            builder.HasKey(p => p.TeacherID);
            builder.Property(L => L.Lastname).HasColumnType("varchar(25)");
            builder.Property(F => F.FirstName).HasColumnType("varchar(15)");
            builder.Property(A => A.Age).HasColumnType("int");

        }
    }
}
