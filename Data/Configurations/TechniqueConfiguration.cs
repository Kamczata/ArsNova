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
    public class TechniqueConfiguration: IEntityTypeConfiguration<Technique>
    {
        public void Configure(EntityTypeBuilder<Technique> builder)
        {
            builder.HasData(
                new Technique { Id = 1, Name = "Olej", Description = "Technika malarska", CategoryId=1 },
                new Technique { Id = 2, Name = "Akwarela", Description = "Technika malarska", CategoryId = 1 },
                new Technique { Id = 3, Name = "Akryl", Description = "Technika malarska", CategoryId = 1 },
                new Technique { Id = 4, Name = "Tempera", Description = "Technika malarska", CategoryId = 1 },
                new Technique { Id = 5, Name = "Pastele", Description = "Technika malarska", CategoryId = 1 },

                new Technique { Id = 6, Name = "Akwatinta", Description = "Technika grafiki warsztatowej", CategoryId = 2 },
                new Technique { Id = 7, Name = "Akwaforta", Description = "Technika grafiki warsztatowej", CategoryId = 2 },
                new Technique { Id = 8, Name = "Sucha igła", Description = "Technika grafiki warsztatowej", CategoryId = 2 },
                new Technique { Id = 9, Name = "Drzeworyt", Description = "Technika grafiki warsztatowej", CategoryId = 2 },
                new Technique { Id = 10, Name = "Miedzioryt", Description = "Technika grafiki warsztatowej", CategoryId = 2 },
                new Technique { Id = 11, Name = "Linoryt", Description = "Technika grafiki warsztatowej", CategoryId = 2 },
                new Technique { Id = 12, Name = "Litografia", Description = "Technika grafiki warsztatowej", CategoryId = 2 },

                new Technique { Id = 13, Name = "Drewno", Description = "Technika rzeźbiarska", CategoryId = 3 },
                new Technique { Id = 14, Name = "Kamień", Description = "Technika rzeźbiarska", CategoryId = 3 },
                new Technique { Id = 15, Name = "Metal", Description = "Technika rzeźbiarska", CategoryId = 3 },
                new Technique { Id = 16, Name = "Inne", Description = "Technika rzeźbiarska", CategoryId = 3 },

                new Technique { Id = 17, Name = "Węgiel", Description = "Technika rysunku", CategoryId = 4 },
                new Technique { Id = 18, Name = "Ołówek", Description = "Technika rysunku", CategoryId = 4 },
                new Technique { Id = 19, Name = "Kreda", Description = "Technika rysunku", CategoryId = 4 },
                new Technique { Id = 20, Name = "Tusz", Description = "Technika rysunku", CategoryId = 4 },
                new Technique { Id = 21, Name = "Inne", Description = "Technika rysunku", CategoryId = 4 }


            );
        }
    }
}
