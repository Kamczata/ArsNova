using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Resume Resume { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<SocialMedia> Media { get; set; }
        public List<Artwork> Artworks { get; set; }
    }
}
