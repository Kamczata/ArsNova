using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArsNova.Model.Artowork;

namespace ArsNova.Model.Artist
{
    public class UpdateArtistDto: BaseArtistDto
    {
        IList<ArtworkDto> Artworks { get; set; }
    }
}
