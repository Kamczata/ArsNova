using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArsNova.Model.Artist
{
    public class ArtistDto: CreateArtistDto
    {
        [Required]
        public int Id { get; set; }
        public IList<ArtworkDto> Artworks { get; set; }
    }
}
