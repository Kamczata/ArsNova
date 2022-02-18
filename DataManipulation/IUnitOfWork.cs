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

        void Save();
    }
}