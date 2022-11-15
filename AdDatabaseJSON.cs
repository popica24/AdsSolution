using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace AdsSolution
{
    public class AdDatabaseJSON
    {
        public List<Ad> ListOfAds
        {
            get;
            set;
        }
        private string filePath
        {
            get;
            set;
        }
     
        public AdDatabaseJSON()
        {
            filePath = ConfigurationManager.AppSettings["FilePath"];
            if (!DatabaseExists()) DatabaseCreate();
            ListOfAds = new List<Ad>();
            LoadAds();
        }
        private bool DatabaseExists()
        {
            return File.Exists(Path.Combine(filePath, "Ads.json"));
        }
        private void DatabaseCreate()
        {
            if (!Directory.Exists(filePath)) Directory.CreateDirectory(filePath);

            if (!File.Exists(Path.Combine(filePath, "Ads.json"))) File.Create(Path.Combine(filePath, "Ads.json")).Close();
            
        }
        public void LoadAds()
        {
            var text = File.ReadAllText(Path.Combine(filePath, "Ads.json"));
            if (string.IsNullOrEmpty(text)) return;
            this.ListOfAds = JsonConvert.DeserializeObject<List<Ad>>(text);
        }
        public void Add(Ad A)
        {
            this.ListOfAds.Add(A);
            var json = JsonConvert.SerializeObject(this.ListOfAds,Formatting.Indented);
            File.WriteAllText(Path.Combine(filePath, "Ads.json"), json);
        }
      
    }
}