using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TechniqueArtwork
    {
        public int Id { get; set; }
        public int ArtworkId { get; set; }
        public Artwork Artwork { get; set; }

        public int TechniqueId { get; set; }
        public Technique Technique { get; set; }
    }
}
