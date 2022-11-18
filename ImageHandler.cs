using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsSolution
{
    public class ImageHandler
    {
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
        }

        public string ImageToString(Image path, MemoryStream ms)
        {
            if (path == null)

                throw new ArgumentNullException("path");

            Image im = path;

            im.Save(ms, ImageFormat.Jpeg);

            byte[] array = ms.ToArray();
            path.Dispose();

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