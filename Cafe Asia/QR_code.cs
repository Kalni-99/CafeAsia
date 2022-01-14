using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using ZXing.Presentation;
using ZXing.QrCode;

namespace Cafe_Asia
{
    public partial class QR_code : Form
    {
        public QR_code()
        {
            InitializeComponent();
        }

        

        private void btn_encode_Click(object sender, EventArgs e)
        {
            var options = new QrCodeEncodingOptions
            {
                Height = pictureBox1.Height,
                Width = pictureBox1.Width
            };
            //create instrance of BarcoderWriter
            var writer = new ZXing.BarcodeWriter();
            //set format
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;
            var text = textBox1.Text;
            var result = writer.Write(text);
            pictureBox1.Image = result;
        }

        private void btn_saveQR_Click(object sender, EventArgs e)
        {
            string initialDIR = @"C:\Users\94768\Desktop\GUI\project\QRtest";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = initialDIR;
            dialog.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(dialog.FileName);
            }
        }

        private void btn_decodeQR_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var reader = new ZXing.BarcodeReader();
                var imgfile = Image.FromFile(dialog.FileName) as Bitmap;
                pictureBox1.Image = imgfile;
                var result = reader.Decode(imgfile);
                textBox1.Text = result.Text;

            }
        }

        private void iconPictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard ad = new Admin_Dashboard();
            ad.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
