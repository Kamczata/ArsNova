using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    public class ArsNovaDbContext : DbContext
    {
        private const string ConnectionString = "Data Source=localhost;Database=ArsNova;Integrated Security=true";
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Technique> Techniques { get; set; }
        public DbSet<Artwork> Artworks { get; set; }
        public DbSet<Hashtag> Tags { get; set; }

        public ArsNovaDbContext()
        {

        }

        public ArsNovaDbContext(DbContextOptions options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(ConnectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
