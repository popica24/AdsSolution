using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsSolution
{
    public class Ad
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public List<Image> Photos { get; set; }
        public string Contact { get; set; }
        public string Description { get; set; }
        public int Views { get; set; } = 0;
        public DateTime DatePosted { get; set; } = DateTime.Now;
        //public string HashTags { get; set; }
        //public string Category { get; set; }

        public Ad()
        {
            Title = String.Empty;
            Price = 0;
            Photos = new List<Image>();
            Contact = string.Empty;
            Description = String.Empty;

        }

        public override string ToString()
        {
            return $"{Title}\n{Description}     Price : {Price}";
        }
    }
}
