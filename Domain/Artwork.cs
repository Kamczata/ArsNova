using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Artwork
    {
        public int Id { get; set; }
        public Artist Artist { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public List<Technique> Techniques { get; set; }
        public List<Hashtag> Tags { get; set; }

    }
}
