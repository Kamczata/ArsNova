using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Malarstwo", Description = "Dziedzina sztuki wizualnej." },
                new Category { Id = 2, Name = "Grafika", Description = "Dziedzina sztuki wizualnej." },
                new Category { Id = 3, Name = "Rzeźba", Description = "Dziedzina sztuki wizualnej." },
                new Category { Id = 4, Name = "Rysunek", Description = "Dziedzina sztuki wizualnej." },
                new Category { Id = 5, Name = "Inne", Description = "Dziedzina sztuki wizualnej." }
            );
        }
    }
}

