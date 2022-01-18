using Entities.DBClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MusicalogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Musicalog;Trusted_connection=true");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<AlbumStock> AlbumStocks { get; set; }
        public DbSet<CatalogAlbum> CatalogAlbums { get; set; }

    }
}
