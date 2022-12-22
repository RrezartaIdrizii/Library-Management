using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;
using Library_Management.Models;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Library_Management.Configuration
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Libraries> Libraries { get; set; }
        public DbSet<Books> Books { get; set; }

      // public object Books { get; internal set; }
        //public DbSet<Books> Books { get; set; }
    }
    }
