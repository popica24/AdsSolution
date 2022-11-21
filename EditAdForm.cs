using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//EDIT AD
namespace AdsSolution
{
    public partial class EditAdForm : Form
    {
        public Ad Root;
        public AdDatabaseJSON ADB;
        public EditAdForm(Ad Root, AdDatabaseJSON _ADB)
        {
            InitializeComponent();
            this.Root = Root;
            ADB = _ADB;
            TitleBox.Text = Root.Title;
            DescBox.Text = Root.Description;
            for (int i = 0; i < Root.Photos.Count; i++)
            {
              
                ImageGrid.Controls.Add(GetPictureBox(ADB.ResizeImage(ADB.StringToImage(Root.Photos[i]), 187, 144)));
                 if(i<3)
                ImageGrid.Controls.Add(AddPhoto, i + 1,0);
                else ImageGrid.Controls.Add(AddPhoto, i + 1, 1);
            }
           
        }

        private void Post_Click(object sender, EventArgs e)
        {
            var TempList = new List<string>();
            foreach(PictureBox c in ImageGrid.Controls)
            {
                using (var ms = new MemoryStream())
                {
                    TempList.Add(ADB.ImageToString(c.Image, ms));
                }
            }
            foreach (var a in ADB.AdList) {
                if (a.Equals(Root))
                {
                    a.Title = TitleBox.Text;
                    a.Description = DescBox.Text;
                    a.Photos = TempList;
                }
            }
            File.WriteAllText(Path.Combine(ADB.filePath, "Ads.json"), JsonConvert.SerializeObject(ADB.AdList));
            this.Close();
        }
        private string GetPictureBoxName()
        {
            return ImageContainer.Images.Count + 1.ToString();
        }
        private PictureBox GetPictureBox(Image img)
        {
            PictureBox Picture = new PictureBox();
            Picture.Image = img;
            Picture.Name = Name;
            Picture.Width = 188;
            Picture.Height = 188;
            return Picture;
        }
        private PictureBox CreatePictureBox(string FilePath, string Name)
        {
            PictureBox Picture = new PictureBox();
            Picture.Image = ADB.ResizeImage(Image.FromFile(FilePath), 188, 188);
            Picture.Name = Name;
            Picture.Width = 188;
            Picture.Height = 188;
            return Picture;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ChosePhoto.ShowDialog();
            string FilePath = ChosePhoto.FileName;

            for (int rowIndex = 0; rowIndex < ImageGrid.RowCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < ImageGrid.ColumnCount; colIndex++)
                {
                    Control c = ImageGrid.GetControlFromPosition(colIndex, rowIndex);
                    if (c == null || c.Name == "AddPhoto")
                    {
                        ImageGrid.Controls.Add(CreatePictureBox(FilePath, GetPictureBoxName()), colIndex, rowIndex);
                        ImageGrid.Controls.Add(AddPhoto, colIndex + 1, rowIndex);
                        goto End;
                    }
                }
            }
        End: return;
        }
    }
}
