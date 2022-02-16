using ArsNova.Model.Artist;
using ArsNova.Model.Artowork;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArsNova
{
    public class ArtworkDto: BaseArtworkDto
    {
        [Required]
        public int Id { get; set; }
        public ArtistDto Artist { get; set; }

    }
}
