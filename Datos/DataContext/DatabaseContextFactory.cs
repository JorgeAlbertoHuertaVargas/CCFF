using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCFF.Datos.DataContext
{
    public class DatabaseContextFactory:IDesignTimeDbContextFactory<AplicationDbContext>
    {
        public AplicationDbContext CreateDbContext(string[] args)
        {
            AppConfiguration appConfig = AppConfiguration.GetInstance(); //*** SE AUMENTA .GetInstance() * PATRON SINGLETON *
            var opsBuilder = new DbContextOptionsBuilder<AplicationDbContext>();
            opsBuilder.UseSqlServer(appConfig.sqlConnectionString);
            return new AplicationDbContext(opsBuilder.Options);
        }
    }
}
