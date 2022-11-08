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
        public double Contact { get; set; }
        public string Description { get; set; }
        //public int Views { get; set; }
        //public string HashTags { get; set; }
        //public string Category { get; set; }
    }
}
