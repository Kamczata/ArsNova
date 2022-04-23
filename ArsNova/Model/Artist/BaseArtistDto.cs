using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArsNova.Model.Artist
{
    public abstract class BaseArtistDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 1000, ErrorMessage = "Description is too long!")]
        public string ImgSrc { get; set; }
        public string Description { get; set; }
        [Required]
        public Location Location { get; set; }
        public List<Category> Categories { get; set; }
        public Resume Resume { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<SocialMedia> Media { get; set; }
    }
}
