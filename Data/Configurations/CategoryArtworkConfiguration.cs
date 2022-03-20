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
    public class CategoryArtworkConfiguration : IEntityTypeConfiguration<CategoryArtwork>
    {
        public void Configure(EntityTypeBuilder<CategoryArtwork> builder)
        {
            builder.HasData(
                new CategoryArtwork { Id = 1, ArtworkId = 1, CategoryId = 1 },
                new CategoryArtwork { Id = 2, ArtworkId = 2, CategoryId = 1 },
                new CategoryArtwork { Id = 3, ArtworkId = 3, CategoryId = 2 },
                new CategoryArtwork { Id = 4, ArtworkId = 4, CategoryId = 2 },
                new CategoryArtwork { Id = 5, ArtworkId = 5, CategoryId = 2 },
                new CategoryArtwork { Id = 6, ArtworkId = 6, CategoryId = 2 }
                );
        }
    }
}
