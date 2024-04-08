using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using System;

namespace N20240408.AccesoADatos
{
    public class AppDbContextFactory: IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] options)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            const string conn = "Data Source=.;Initial Catalog=N20240408Db;Integrated Security=True;Encrypt=False";
            optionsBuilder.UseSqlServer(conn);

            return new ApplicationDbContext(optionsBuilder.Options);
        }
        
    }
}
