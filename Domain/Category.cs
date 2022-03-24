using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public IList<CategoryArtwork> CategoriesArtwork { get; set; }
        public IList<CategoryArtist> CategoriesArtist { get; set; }
    }
}
