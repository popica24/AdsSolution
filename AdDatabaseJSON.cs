using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdsSolution
{
    public class AdDatabaseJSON : IDatabaseJSON<Ad>, IDisposable
    {
        public ImageHandler handler = new ImageHandler();
        private string filePath
        {
            get;
            set;
        }
        public AdDatabaseJSON()
        {
            filePath = ConfigurationManager.AppSettings["FilePath"];
            if (!DatabaseExists()) DatabaseCreate();
        }
        public void AddElement(Ad entry)
        {
            var Text = File.ReadAllText(Path.Combine(filePath, "Ads.json"));
            List<Ad> Ads = new List<Ad>();
            if (string.IsNullOrEmpty(Text)) { Ads.Add(entry); File.WriteAllText(Path.Combine(filePath, "Ads.json"), JsonConvert.SerializeObject(Ads)); return; }

                Ads = JsonConvert.DeserializeObject<List<Ad>>(Text);

            Ads.Add(entry);
           

        }

        public GroupBox CreateContainer(Ad entry)
        {
            GroupBox G = new GroupBox();
            return G;
        }

        public void CreateNewElement(Ad entry)
        {
            throw new NotImplementedException();
        }

        public bool DatabaseExists()
        {

            return File.Exists(Path.Combine(filePath, "Ads.json"));
        }
        public void DatabaseCreate()
        {
            if (!Directory.Exists(filePath))
                Directory.CreateDirectory(filePath);

            if (!File.Exists(Path.Combine(filePath, "Ads.json")))
                File.Create(Path.Combine(filePath, "Ads.json"));
        }

        public List<Ad> GetElements()
        {
            throw new NotImplementedException();
        }

        public Ad LoadElement(int Key)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
