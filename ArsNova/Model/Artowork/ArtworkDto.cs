using System.ComponentModel.DataAnnotations;
using ArsNova.Model.Artist;

namespace ArsNova.Model.Artowork
{
    public class ArtworkDto: BaseArtworkDto
    {
        [Required]
        public int Id { get; set; }
        public ArtistDto Artist { get; set; }

    }
}
