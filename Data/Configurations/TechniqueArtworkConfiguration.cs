using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    class TechniqueArtworkConfiguration : IEntityTypeConfiguration<TechniqueArtwork>
    {
        public void Configure(EntityTypeBuilder<TechniqueArtwork> builder)
        {
            builder.HasData(
                new TechniqueArtwork { Id = 1, ArtworkId = 1, TechniqueId = 1 },
                new TechniqueArtwork { Id = 2, ArtworkId = 2, TechniqueId = 1 },
                new TechniqueArtwork { Id = 3, ArtworkId = 3, TechniqueId = 20},
                new TechniqueArtwork { Id = 4, ArtworkId = 4, TechniqueId = 20},
                new TechniqueArtwork { Id = 5, ArtworkId = 5, TechniqueId = 9},
                new TechniqueArtwork { Id = 6, ArtworkId = 6, TechniqueId = 9}


                );
        }
    }
}
