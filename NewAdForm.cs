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

namespace AdsSolution
{
    public partial class NewAdForm : Form
    {
        public User TargetUser;
       public AdDatabaseJSON ADB = new AdDatabaseJSON();
        public ImageHandler Handler = new ImageHandler();
        public NewAdForm(User U)
        {
            InitializeComponent();
            ImageGrid.Controls.Add(AddPhoto, 0, 0);
            TargetUser = U;
        }
        private string GetPictureBoxName()
        {

            return ImageContainer.Images.Count + 1.ToString();

        }
        private PictureBox CreatePictureBox(string FilePath, string Name)
        {
            PictureBox Picture = new PictureBox();
            Picture.Image = new Bitmap(FilePath);
            Picture.Name = Name;
            Picture.Width = 188;
            Picture.Height = 144;
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
                    Control c = ImageGrid.GetControlFromPosition(colIndex,rowIndex);
                    if (c == null || c.Name=="AddPhoto")
                    {
                        ImageGrid.Controls.Add(CreatePictureBox(FilePath, GetPictureBoxName()), colIndex, rowIndex);
                        ImageGrid.Controls.Add(AddPhoto, colIndex+1, rowIndex);
                        goto End;
                    }
                }
            }
        End: return;
        }

        private void Post_Click(object sender, EventArgs e)
        {

          /*  var _temp = new List<Image>();
            foreach (PictureBox P in ImageGrid.Controls)
            {
                _temp.Add(P.Image);
            }*/
            var _temp = new List<string>();
            using (var ms = new MemoryStream())
            {
                foreach (PictureBox p in ImageGrid.Controls)
                {
                    if (p.Name == "AddPhoto") continue;
                    _temp.Add(Handler.ImageToString(p.Image,ms));
                }
            }

            Ad ad = new Ad(TitleBox.Text,_temp ,TargetUser.Email, DescBox.Text, TargetUser.OwnerKey)//DE ADAUGAT CONTACT
            {
                Title = TitleBox.Text,
                Description = DescBox.Text,
                Photos = _temp
            };
            ADB.AddElement(ad);
        }
    }

}
