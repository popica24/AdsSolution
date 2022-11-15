using Newtonsoft.Json;
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
        public string Title
        {
            get;
            set;
        }
       
        public string Contact
        {
            get;
            set;
        } = "Phone";
        public string Description
        {
            get;
            set;
        }
        public int Views
        {
            get;
            set;
        } = 0;
        public Guid OwnedBy
        {
            get;
            set;
        }
        public DateTime DatePosted
        {
            get;
            set;
        } = DateTime.Now;
       
      

        public Ad(string _Title, string _Contact, string _Description, int _Views, Guid _OwnedBy)
        {
            Title = _Title;
           
            Contact = _Contact;
            Description = _Description;
            Views = _Views;
            OwnedBy = _OwnedBy;
        }

        public override string ToString()
        {
            return $"{Title}\n{Description}";
        }

    }
}