using System;
using System.Collections.Generic;
using System.Text;
using Faculty.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Faculty.EntityConfigurations
{
    class SubjectConfiguration : IEntityTypeConfiguration<Subjects>
    {
        public void Configure(EntityTypeBuilder<Subjects> builder)

        {
            builder.HasKey(p => p.SubjectID);
            builder.Property(S => S.Subject).HasColumnType("varchar(25)");
            builder.Property(T => T.TimeDuration).HasColumnType("Time");
        }
    }
}
