using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Artwork
    {
        public int Id { get; set; }
        public Artist Artist { get; set; }

        [ForeignKey(nameof(Artist))]
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public string ImgSource { get; set; }
        public string Description { get; set; }
        public IList<CategoryArtwork> CategoriesArtwork { get; set; }
        public IList<TechniqueArtwork> TechniquesArtwork { get; set; }
        public List<Hashtag> Hashtags { get; set; }

        //public List<Technique> Techniques { get; set; }

    }
}
