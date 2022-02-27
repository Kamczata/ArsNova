using Domain;

namespace DataManipulation
{
    public interface IUnitOfWork
    {
        IGenericRepository<Artist> Artists { get; }
        IGenericRepository<Artwork> Artworks { get; }
        IGenericRepository<Category> Categories { get; }
        IGenericRepository<Technique> Techniques { get; }
        IGenericRepository<Location> Locations { get; }
        IGenericRepository<CategoryArtist> CategoriesArtist { get; }
        IGenericRepository<CategoryArtwork> CategoriesArtwork { get; }
        IGenericRepository<TechniqueArtwork> TechniquesArtwork { get; }

        void Save();
    }
}