using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain;

namespace ArsNova.Model.Artowork
{
    public abstract class BaseArtworkDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string ImgSource { get; set; }
        [Required]
        [StringLength(maximumLength: 200, ErrorMessage = "Description is too long")]
        public string Description { get; set; }
        [Required]
        public Category Category { get; set; }
        [Required]
        public List<Technique> Techniques { get; set; }
        public List<Hashtag> Tags { get; set; }
        [Required]
        public int ArtistId { get; set; }
    }
}
