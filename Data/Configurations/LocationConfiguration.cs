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
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(
                new Location { Id = 1, City = "Malaga", Country = "Hiszpania" },
                new Location { Id = 2, City = "Kraków", Country = "Polska" },
                new Location { Id = 3, City = "Warszawa", Country = "Polska" },
                new Location { Id = 4, City = "Wrocław", Country = "Polska" },
                new Location { Id = 5, City = "Poznań", Country = "Polska" },
                new Location { Id = 6, City = "Łódź", Country = "Polska" },
                new Location { Id = 7, City = "Gdańsk", Country = "Polska" }
            );
        }
    }
}