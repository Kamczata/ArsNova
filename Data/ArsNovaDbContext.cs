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

        public DbSet<CategoryArtist> CategoriesArtists { get; set; }
        public DbSet<CategoryArtwork> CategoriesArtwork { get; set; }
        public DbSet<TechniqueArtwork> TechniquesArtwork { get; set; }

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
            modelBuilder.Entity<CategoryArtist>().HasKey(sc => new { sc.ArtistId, sc.CategoryId });
            modelBuilder.Entity<CategoryArtwork>().HasKey(sc => new { sc.ArtworkId, sc.CategoryId });
            modelBuilder.Entity<TechniqueArtwork>().HasKey(sc => new { sc.ArtworkId, sc.TechniqueId });

        }
    }
}
