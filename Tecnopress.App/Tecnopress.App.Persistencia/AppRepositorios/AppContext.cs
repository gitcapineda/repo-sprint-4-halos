//puente entre las entidades y la BD
using System;
using Microsoft.EntityFrameworkCore;
using Tecnopress.App.Dominio;

namespace Tecnopress.App.Persistencia
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Categoria>?Categorias { get; set; }
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Fase>? Fases { get; set; }
        public DbSet<Login>? Logins { get; set; }
        public DbSet<Proyecto>? Proyectos { get; set; }
        public DbSet<Usuario>? Usuarios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-1D612VV\\MSQLSERVER; Initial Catalog = Tecno; User ID = sa;Password=1986");
            }
            
        }

    }
}