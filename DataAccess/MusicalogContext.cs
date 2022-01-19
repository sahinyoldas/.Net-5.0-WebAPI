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
        public DbSet<CatalogAlbum> CatalogAlbums { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        /// <summary>
        /// Test Users For Authentication  -- SEED DATA
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Jack",
                    Email = "jack@jack.com",
                    Password = "123",
                    BirthDate = DateTime.Now.AddYears(-25)
                },
                new User
                {
                    Id = 2,
                    Name = "Carol",
                    Email = "carol@carol.com",
                    Password = "123",
                    BirthDate = DateTime.Now.AddYears(-30)
                }
            );

            modelBuilder.Entity<UserRole>().HasData(
                new UserRole { Id = 1, UserId = 1, Role = "admin"},
                new UserRole { Id = 2, UserId = 2, Role = "add" },
                new UserRole { Id = 3, UserId = 2, Role = "list" }
            );
        }
    }
}
