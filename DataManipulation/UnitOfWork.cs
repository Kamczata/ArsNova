using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManipulation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ArsNovaDbContext _context;
        public IGenericRepository<Artist> Artists => new GenericRepository<Artist>(_context);
        public IGenericRepository<Artwork> Artworks => new GenericRepository<Artwork>(_context);

        public UnitOfWork(ArsNovaDbContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
