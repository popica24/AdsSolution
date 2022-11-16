using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsSolution
{
    public class ImageHandler
    {
        public Image ScaleImage(Image image, int height)
        {
            double ratio = (double)height / image.Height;
            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);
            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            image.Dispose();
            return newImage;
        }

        public string ImageToString(Image path, MemoryStream ms)
        {
            if (path == null)

                throw new ArgumentNullException("path");

            Image im = path;



            im.Save(ms, im.RawFormat);

            byte[] array = ms.ToArray();
          //  path.Dispose();

            return Convert.ToBase64String(array);

        }

        public Image StringToImage(string imageString)

        {

            if (imageString == null)

                throw new ArgumentNullException("imageString");

            byte[] array = Convert.FromBase64String(imageString);

            Image image = Image.FromStream(new MemoryStream(array));

            return image;
        }
    }
}
