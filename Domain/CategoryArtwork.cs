using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CategoryArtwork
    {
        public int Id { get; set; }
        public int ArtworkId { get; set; }
        public Artwork Artwork { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
