using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary1
{
    public class Class1 : DbContext
    {
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Musicalog;Trusted_connection=true");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
    }

    public class User 
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class Catalog
    {
        public long Id { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public long UserId { get; set; }
        public string Name { get; set; }
    }
}
