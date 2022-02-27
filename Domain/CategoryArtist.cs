using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CategoryArtist
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
