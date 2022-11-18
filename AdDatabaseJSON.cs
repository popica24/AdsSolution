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
    public partial class AdDatabaseJSON : IDatabaseJSON<Ad>, IDisposable
    {
        public ImageHandler handler = new ImageHandler();
        public string filePath
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
            File.WriteAllText(Path.Combine(filePath, "Ads.json"), JsonConvert.SerializeObject(Ads));

        }

        public GroupBox CreateContainer(Ad entry,bool IsOwnedByUser)
        {
            GroupBox G = new GroupBox();
            PictureBox P = new PictureBox();
            P.Image = handler.ResizeImage(handler.StringToImage(entry.Photos[0]), 132, 132);
            P.Location = new Point(6, 11);
            P.BorderStyle = BorderStyle.FixedSingle;
            P.Width = 132;
            P.Height = 132;
            Label L = new Label();
            L.Text = entry.Title;
            L.Location = new Point(265, 21);
            Label D = new Label();
            D.Text = entry.Description;
            D.Location = new Point(144, 71);
            Label T = new Label();
            T.Text = String.Concat("Posted", entry.DatePosted.ToShortDateString());
            T.Location = new Point(144, 114);
            G.Controls.Add(P);
            G.Controls.Add(L);
            G.Controls.Add(D);
            G.Controls.Add(T);
            G.Size = new Size(667, 151);
            LinkLabel Edit = new LinkLabel();
            Edit.Text = "Edit";
            Edit.Location = new Point(636, 103);
            
            LinkLabel Delete = new LinkLabel();
        
            Delete.Text = "Delete";
            Delete.Location = new Point(623, 130);
            L.AutoSize = true;
            if (IsOwnedByUser == true)
            {
                G.Controls.Add(Edit);
                G.Controls.Add(Delete);
            }
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
                File.Create(Path.Combine(filePath, "Ads.json")).Close();
        }

        public List<Ad> GetElements()
        {
            var _temp = new List<Ad>();
            var text = File.ReadAllText(Path.Combine(filePath, "Ads.json"));
            if(string.IsNullOrEmpty(text))return _temp;
            var Ads = JsonConvert.DeserializeObject<List<Ad>>(text);
            foreach (var entry in Ads)
            {

                _temp.Add(entry);
            }
            return _temp;
        }
    

        public Ad LoadElement(int Key)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        
        public void DeleteElement(Ad entry)
        {
            File.WriteAllText(Path.Combine(filePath, "Ads.json"), JsonConvert.SerializeObject(GetElements().Remove(entry)));
        }
    }
}
