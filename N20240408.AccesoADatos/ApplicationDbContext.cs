using Microsoft.EntityFrameworkCore;
using N20240408.EntidadesDeNegocio;
using System;

namespace N20240408.AccesoADatos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<PersonasN> PersonaN { get; set; }


    }
}

    
