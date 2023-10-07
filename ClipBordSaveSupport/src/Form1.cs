using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace ClipBordSaveSupport
{
    public partial class Form1 : Form
    {
        private string path = "C:\\Users\\Yuki\\Documents\\アルバイト\\TOKIUM\\receipt\\";

        public Form1()
        {
            InitializeComponent();
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
        /// <summary>
        /// クリップボードの画像を保存
        /// </summary>
        /// <param name="folder"></param>
        /// <param name="fileNamePath"></param>
        /// <param name="format"></param>
        /// <param name="imageType"></param>
        /// <param name="quality"></param>
        public void SaveClipboard(string fileNamePath, string imageType = "png", int quality = 100)
        {
            Save((Bitmap)Clipboard.GetImage(), fileNamePath, imageType, quality);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void saveShopNameClick(object sender, EventArgs e)
        {
            var fileNamePath = path + "shop_name.png";

            SaveClipboard(fileNamePath);
        }

        private void btn_Tel_Click(object sender, EventArgs e)
        {
            var fileNamePath = path + "tel.png";

            SaveClipboard(fileNamePath);
        }

        private void btn_Date_Click(object sender, EventArgs e)
        {
            var fileNamePath = path + "date.png";

            SaveClipboard(fileNamePath);

        }

        private void btn_AmountSum_Click(object sender, EventArgs e)
        {

            var fileNamePath = path + "amount_sum.png";

            SaveClipboard(fileNamePath);
        }

        private void btn_Tax10_Click(object sender, EventArgs e)
        {

            var fileNamePath = path + "tax10.png";

            SaveClipboard(fileNamePath);
        }

        private void btn_Tax8_Click(object sender, EventArgs e)
        {

            var fileNamePath = path + "tax8.png";

            SaveClipboard(fileNamePath);
        }

        private void btn_Free_Click(object sender, EventArgs e)
        {

            var fileNamePath = path + "free.png";

            SaveClipboard(fileNamePath);
        }

        private void btn_No_Click(object sender, EventArgs e)
        {

            var fileNamePath = path + "no.png";

            SaveClipboard(fileNamePath);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            foreach (string pathFrom in System.IO.Directory.EnumerateFiles(path, "*.png", System.IO.SearchOption.AllDirectories))
            {
                //１ファイルの削除実行。
                Console.WriteLine(pathFrom);
                System.IO.File.Delete(pathFrom);
            }
        }
    }
}
