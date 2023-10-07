using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputClipBoardImageDuringCharacter
{
    public class ClipBoardImage
    {
        public Bitmap image { get; private set; }

        public ClipBoardImage(Bitmap image)
        {
            if (image != null)
            {
                this.image = image;
            }
        }
        /// <summary>
        /// 指定したBitmapの保存
        /// formatには "jpg","bmp","png","gif" が指定可能
        /// formatに"jpg"を指定した時のみ qualityの値が有効になる
        /// </summary>
        /// <param name="img"></param>
        /// <param name="fileName"></param>
        /// <param name="format"></param>
        /// <param name="quality"></param>
        public void Save(Bitmap img, string fileNamePath, string imageType = "png", int quality = 100)
        {
            if (img == null)
            {
                return;
            }

            switch (imageType)
            {
                case "jpg":
                    //var parameters = new EncoderParameters(1);
                    //parameters.Param[0] = new EncoderParameter(Encoder.Quality, quality);
                    //var jpeg_encoder = ImageCodecInfo.GetImageEncoders().FirstOrDefault(i => i.MimeType == "image/jpeg");
                    //img.Save(fileNamePath, jpeg_encoder, parameters);
                    break;
                case "bmp":
                    img.Save(fileNamePath, ImageFormat.Bmp);
                    break;
                case "png":
                    var parameters = new EncoderParameters(1);
                    parameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
                    var png_encoder = ImageCodecInfo.GetImageEncoders().FirstOrDefault(i => i.MimeType == "image/png");
                    img.Save(fileNamePath, png_encoder, parameters);
                    //img.Save(fileNamePath, ImageFormat.Png);
                    break;
                case "gif":
                    img.Save(fileNamePath, ImageFormat.Gif);
                    break;
            }
        }
        public void Save(string fileNamePath, string imageType = "png", int quality = 100)
        {
            Save(this.image, fileNamePath, imageType, quality);
        }

    }
}
