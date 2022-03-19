using ArsNova.Model.Artist;

namespace ArsNova.Model.Artowork
{
    public class UpdateArtworkDto: BaseArtworkDto
    {
        public ArtistDto Artist { get; set; }
    }
}
