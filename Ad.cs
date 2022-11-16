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
        public List<string> Photos { get; set; }
        public string Contact { get; set; } = "Phone";
        public string Description { get; set; }
        public int Views { get; set; } = 0;
        public Guid OwnedBy { get; set; }
        public DateTime DatePosted { get; set; } = DateTime.Now;
        //public string HashTags { get; set; }
        //public string Category { get; set; }

        public Ad(string _Title,List<string> _Photos ,string _Contact,string _Description, Guid _OwnedBy)
        {
            Title = _Title;
            Photos = _Photos;
            Contact = _Contact;
            Description = _Description;
         
            OwnedBy = _OwnedBy;
        }

        public override string ToString()
        {
            return $"{Title}\n{Description}";
        }

      
    }
}
