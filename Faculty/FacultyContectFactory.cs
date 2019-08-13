using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Faculty.Entities
{
    public class FacultyContectFactory : IDesignTimeDbContextFactory<FacultyContext>
    {
        public FacultyContext   CreateDbContext(string[] args)
        {
               
                ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");

            IConfiguration config = builder.Build();

            string connectionString = config.GetConnectionString("DefaultContect");



            DbContextOptionsBuilder<FacultyContext> optionsBuilder = new DbContextOptionsBuilder<FacultyContext>();
            DbContextOptions<FacultyContext> options = optionsBuilder
                   .UseSqlServer(connectionString).Options;




            return new FacultyContext(options);

        }
    }
}
