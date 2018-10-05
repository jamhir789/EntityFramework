using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace entityF
{
    class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

                                              //la ConnetionString de abaajo es para crear la base de datos desde entityframework
        {                                  //"Data Source=EISEILAP0319;Initial Catalog=EntityF;Integrated Security=True"
            optionsBuilder.UseSqlServer("Server=EISEILAP0319;Database=EntityF;Trusted_Connection=True;MultipleActiveResultSets=true")
            .EnableSensitiveDataLogging(true)//esto nos sirver para que nos de un log y saber como actuan nuestras querys 
            .UseLoggerFactory(new LoggerFactory().AddConsole((category, level) => level == LogLevel.Information && category == DbLoggerCategory.Database.Command.Name, true));
        }

        public DbSet<Estudiante> Estudiantes { get; set; }



    }
}
