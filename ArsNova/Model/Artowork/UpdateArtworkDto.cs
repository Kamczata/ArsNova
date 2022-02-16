using ArsNova.Model.Artist;
using ArsNova.Model.Artowork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArsNova
{
    public class UpdateArtworkDto: BaseArtworkDto
    {
        public ArtistDto Artist { get; set; }
    }
}
