using CCFF.Datos.DataContext;
using CCFF.Modelo;
using CCFF.Modelo.Entities;
using Microsoft.EntityFrameworkCore;

namespace CCFF.Datos
{
    public class AplicationDbContext : DbContext
    {

        public class OptionBuild
        {
            public OptionBuild()
            {
                settings = AppConfiguration.GetInstance();
                opsBuilder = new DbContextOptionsBuilder<AplicationDbContext>();
                opsBuilder.UseSqlServer(settings.sqlConnectionString);
                dbOptions = opsBuilder.Options;
            }

            public DbContextOptionsBuilder<AplicationDbContext> opsBuilder { get; set; }
            public DbContextOptions<AplicationDbContext> dbOptions { get; set; }
            private AppConfiguration settings { get; set; }

        }

        public static OptionBuild ops = new OptionBuild();

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }



        //entities
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Paremet> Paramets { get; set; }
        public DbSet<ParametersCcff> ParametersCcffs { get; set; }
        //public DbSet<Evento> Eventos { get; set; }
        // public DbSet<Reunion> Reuniones { get; set; }

    }
}
