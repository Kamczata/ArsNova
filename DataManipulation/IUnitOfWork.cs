using Domain;

namespace DataManipulation
{
    public interface IUnitOfWork
    {
        IGenericRepository<Artist> Artists { get; }
        IGenericRepository<Artwork> Artworks { get; }

        void Save();
    }
}