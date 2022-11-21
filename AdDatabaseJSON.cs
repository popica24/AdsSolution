using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdsSolution
{
    public class AdDatabaseJSON 
    {
        public List<Ad> AdList = new List<Ad>();
        public string filePath
        {
            get;
            set;
        }
        public AdDatabaseJSON()
        {
            filePath = ConfigurationManager.AppSettings["FilePath"];
            if (!DatabaseExists()) DatabaseCreate();
            AdList = GetElementsAsList();
        }
        //Database Status
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


        //GroupBox function
        public GroupBoxWithRoot CreateContainer(Ad entry, bool IsOwnedByUser)
        {
            GroupBoxWithRoot GroupBox = new GroupBoxWithRoot();
            GroupBox.Root = entry;
            PictureBox PictureBox = new PictureBox();
            try
            {
                PictureBox.Image = ResizeImage(StringToImage(entry.Photos[0]), 132, 132);
            }
            catch(Exception ex)
            {
                PictureBox.Image = ResizeImage(Image.FromFile("PlaceHolder.jpg"), 132, 132);
            }
            PictureBox.Location = new Point(6, 11);
            PictureBox.BorderStyle = BorderStyle.FixedSingle;
            PictureBox.Width = 132;
            PictureBox.Height = 132;
            GroupBox.Controls.Add(PictureBox);

            Label Title = new Label();
            Title.Text = entry.Title;
            Title.Location = new Point(265, 21);
            GroupBox.Controls.Add(Title);

            Label Description = new Label();
            Description.Text = entry.Description;
            Description.Location = new Point(144, 71);
            GroupBox.Controls.Add(Description);

            Label DateAdded = new Label();
            DateAdded.Text = String.Concat("Posted", entry.DatePosted.ToShortDateString());
            DateAdded.Location = new Point(144, 114);
            GroupBox.Controls.Add(DateAdded);

            LinkLabel Edit = new LinkLabel();
            Edit.Text = "Edit";
            Edit.Location = new Point(636, 103);
            Edit.Click += (s, args) => {
                using (EditAdForm E = new EditAdForm(GroupBox.Root,this)) {
                    E.ShowDialog();
                    E.FormClosed += (_s, _args) =>
                    {
                        GroupBox.Root = E.Root;
                    };
                }
            };
            

            LinkLabel Delete = new LinkLabel();
            Delete.Text = "Delete";
            Delete.Location = new Point(623, 130);
            Delete.Click += (s, args) =>
            {
                AdList.Remove(entry);
                File.WriteAllText(Path.Combine(filePath, "Ads.json"), JsonConvert.SerializeObject(AdList));
            };

            if (IsOwnedByUser == true)
            {
                GroupBox.Controls.Add(Edit);
                GroupBox.Controls.Add(Delete);
            }
            GroupBox.Size = new Size(667, 151);
            return GroupBox;
        }
        public List<Ad> GetListOfGroupBoxRoot(Control.ControlCollection _Controls)
        {
            List<GroupBoxWithRoot> ControlList = new List<GroupBoxWithRoot>();
            ControlList.AddRange(_Controls.OfType<GroupBoxWithRoot>());
            List<Ad> TempList = new List<Ad>();
            foreach(GroupBoxWithRoot G in ControlList)
            {
                TempList.Add(G.Root);
            }
            return TempList;
            
        }
        public GroupBoxWithRoot GetGroupBoxByRoot(Ad entry, Control.ControlCollection _Controls)
        {
            foreach(GroupBoxWithRoot C in _Controls)
            {
                if (C.Root.Equals(entry)) return C;
            }
            return null;
        }
      

        //Database Operations
        public void AddElement(Ad entry)
        {
            AdList.Add(entry);
            File.WriteAllText(Path.Combine(filePath, "Ads.json"), JsonConvert.SerializeObject(AdList));
        }
        public List<Ad> GetElementsAsList()
        {
            var TempList = new List<Ad>();
            var RawText = File.ReadAllText(Path.Combine(filePath, "Ads.json"));
            if (string.IsNullOrEmpty(RawText)) return TempList;
            var DeserializedText = JsonConvert.DeserializeObject<List<Ad>>(RawText);
            foreach (var entry in DeserializedText)
            {

                TempList.Add(entry);
            }
            return TempList;
        }
        public void DeleteElement(Ad entry)
        {
            AdList.Remove(entry);
            File.WriteAllText(Path.Combine(filePath, "Ads.json"), JsonConvert.SerializeObject(AdList));
        }
        

        //Image Work
        public Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return (Image)destImage;
        }   //De pe StackOverflow//
        public string ImageToString(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }     //De pe StackOverflow//
        public Image StringToImage(string imageString)

        {
            byte[] array = Convert.FromBase64String(imageString);
            Image image = Image.FromStream(new MemoryStream(array));
            return image;
        }               //De pe StackOverflow//
    }
    public class GroupBoxWithRoot : GroupBox
    {
        public Ad Root { get; set; }
    }
}

