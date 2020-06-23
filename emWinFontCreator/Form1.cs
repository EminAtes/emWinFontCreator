using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace emWinFontCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComboBoxFonts.DrawItem += ComboBoxFonts_DrawItem;
            ComboBoxFonts.DataSource = System.Drawing.FontFamily.Families.ToList();
        }
        int xSize = 400, ySize = 400, xOffSet = 0,yOffSet = 0;
        Image tempImage;
        private void ComboBoxFonts_DrawItem(object sender, DrawItemEventArgs e)
        {
            var comboBox = (ComboBox)sender;
            var fontFamily = (FontFamily)comboBox.Items[e.Index];
            var font = new Font(fontFamily, comboBox.Font.SizeInPoints);

            e.DrawBackground();
            e.Graphics.DrawString(font.Name, font, Brushes.Black, e.Bounds.X, e.Bounds.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void ComboBoxFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = ComboBoxFonts.SelectedItem.ToString();
            s = s.TrimEnd(']');
            s = s.Substring(s.IndexOf('=') + 1);
            FontFamily fontFamily = new FontFamily(s);
            Font font = new Font(
               fontFamily,
               Convert.ToInt16(textBox2.Text),
               FontStyle.Regular,
               GraphicsUnit.Pixel);
            textBox1.Font = font;

            DrawText();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string s = ComboBoxFonts.SelectedItem.ToString();
            s = s.TrimEnd(']');
            s = s.Substring(s.IndexOf('=') + 1);
            FontFamily fontFamily = new FontFamily(s);
            Font font = new Font(
               fontFamily,
               textBox2.Text != ""?(Convert.ToInt16(textBox2.Text)>10? Convert.ToInt16(textBox2.Text):10):10,
               FontStyle.Regular,
               GraphicsUnit.Pixel);
            textBox1.Font = font;

            DrawText();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            DrawText();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void DrawText()
        {
            Image resultImage = new Bitmap(xSize, ySize, PixelFormat.Format24bppRgb);

            using (Graphics grp = Graphics.FromImage(resultImage))
            {
                grp.FillRectangle(Brushes.White, 0, 0, xSize, ySize);
            }
            RectangleF rectf = new RectangleF(xOffSet, yOffSet, xSize, ySize);

            Graphics g = Graphics.FromImage(resultImage);


            if (checkBox1.Checked)
            {
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            }
            g.DrawString(textBox1.Text, textBox1.Font, Brushes.Black, rectf);

            g.Flush();
            tempImage = resultImage;
            pictureBox1.Image = resultImage;

            DrawRectangel();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                xOffSet = Convert.ToInt32(textBox3.Text);
            }
            else
            {
                xOffSet = 0;
            }
            if (textBox4.Text != "")
            {
                yOffSet = Convert.ToInt32(textBox4.Text);
            }
            else
            {
                yOffSet = 0;
            }


            DrawText();
        }
        private void OnTextChanged(object sender, EventArgs e)
        {
            //TextBox textbox = sender as TextBox;
            //if (!System.Text.RegularExpressions.Regex.IsMatch(textbox.Text, "^[0-9]*$"))
            //{
            //    textbox.Text = string.Empty;
            //}
            DrawRectangel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //char : textBox1.Text
            Rectangle cropRect = new Rectangle(new Point(Convert.ToInt32(textBoxLeftOffset.Text), Convert.ToInt32(textBoxTopOffset.Text)),
                new Size(pictureBox1.Width - (Convert.ToInt32(textBoxLeftOffset.Text) + Convert.ToInt32(textBoxRightOffset.Text)),
                pictureBox1.Height - (Convert.ToInt32(textBoxTopOffset.Text) + Convert.ToInt32(textBoxBottomOffset.Text))));
            Bitmap src = (Bitmap)tempImage;
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height, PixelFormat.Format24bppRgb);

            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height),
                                 cropRect,
                                 GraphicsUnit.Pixel);
            }


            //for (int i = 0; i < target.Width; i++)
            //{
            //    for (int j = 0; j < target.Height; j++)
            //    {
            //        Color c = target.GetPixel(i, j);

            //        //Apply conversion equation
            //        byte gray = (byte)(.21 * c.R + .71 * c.G + .071 * c.B);

            //        //Set the color of this pixel
            //        target.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
            //    }
            //}

            //target.Save("target.bmp", ImageFormat.Bmp);
            //var srcBitmap = new Bitmap("target.bmp");
            var bitmapData = target.LockBits(new Rectangle(new Point(0,0),target.Size),ImageLockMode.ReadWrite,PixelFormat.Format24bppRgb);
            var length = bitmapData.Stride * bitmapData.Height;

            byte[] RgbByteArray = new byte[length];

            // Copy bitmap to byte[]
            Marshal.Copy(bitmapData.Scan0, RgbByteArray, 0, length);
            target.UnlockBits(bitmapData);

            byte[] chr = Encoding.ASCII.GetBytes(textBox1.Text);
            string write = "GUI_CONST_STORAGE unsigned char acGUI_Font" + textBox1.Font.Name + Convert.ToInt32(textBox2.Text) + "_" + chr[0] + "[" + ((target.Width+1)/2)*target.Height + "] =\n{\n\t";
            for (int i = 0; i < target.Height; i++)
            {
                for (int j = 0; j < (target.Width + 1)/2; j++)
                {
                    //write += "0x" + ((RgbByteArray[i * target.Width * 3 + j * 3 + 2] < 0x10) ? "0" : "") + RgbByteArray[i * target.Width * 3 + j *3 + 1].ToString("X") +", ";
                    int temp = (byte)((255-RgbByteArray[i * target.Width * 3 + j * 3 * 2])>>4);
                    write += "0x" + temp.ToString("X");

                    temp = (byte)((255-RgbByteArray[i * target.Width * 3 + j * 3 * 2 + 3])>>4);
                    write +=   temp.ToString("X")+", ";
                    //((i * target.Width * 3 + j * 3 * 2 + 3) >= (target.Width) / 2) ? "0" : 
                }
                write += "\n\t";
            }
            write += "};";

            string path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            if (Environment.OSVersion.Version.Major >= 6)
            {
                path = Directory.GetParent(path).ToString();
            }
            System.IO.File.WriteAllText(path+ @"\Desktop\CustomFonts\" + textBox1.Text + ".c", write);
            pictureBox1.Image = target;

        }
        ushort Map(ushort x, ushort in_min, ushort in_max, ushort out_min, ushort out_max)
        {
            return (ushort)(((int)x - (int)in_min) * ((int)out_max - (int)out_min) / ((int)in_max - (int)in_min) + (int)out_min);
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }


        public static Bitmap ToGrayscale(Bitmap bmp)
        {
            var result = new Bitmap(bmp.Width, bmp.Height, PixelFormat.Format8bppIndexed);

            BitmapData data = result.LockBits(new Rectangle(0, 0, result.Width, result.Height), ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);

            // Copy the bytes from the image into a byte array
            byte[] bytes = new byte[data.Height * data.Stride];
            Marshal.Copy(data.Scan0, bytes, 0, bytes.Length);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    var c = bmp.GetPixel(x, y);
                    var rgb = (byte)((c.R + c.G + c.B) / 3);

                    bytes[x * data.Stride + y] = rgb;
                }
            }

            // Copy the bytes from the byte array into the image
            Marshal.Copy(bytes, 0, data.Scan0, bytes.Length);

            result.UnlockBits(data);

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"arrow.png");
            tempImage = pictureBox1.Image;
        }

        private void DrawRectangel()
        {
            if (textBoxTopOffset.Text != "" && textBoxBottomOffset.Text != "" && textBoxLeftOffset.Text != "" && textBoxRightOffset.Text != "")
            {
                Pen blackPen = new Pen(Color.Red, 1);
                Image bmp = (Image)tempImage.Clone();
                int x1 = 0;
                int y1 = Convert.ToInt32(textBoxTopOffset.Text);
                int x2 = pictureBox1.Width;
                int y2 = Convert.ToInt32(textBoxTopOffset.Text);
                // Draw line to screen.
                using (var graphics = Graphics.FromImage(bmp))
                {
                    graphics.DrawLine(blackPen, x1, y1, x2, y2);
                }

                x1 = 0;
                y1 = (pictureBox1.Height - Convert.ToInt32(textBoxBottomOffset.Text));
                x2 = pictureBox1.Width;
                y2 = (pictureBox1.Height - Convert.ToInt32(textBoxBottomOffset.Text));
                // Draw line to screen.
                using (var graphics = Graphics.FromImage(bmp))
                {
                    graphics.DrawLine(blackPen, x1, y1, x2, y2);
                }

                x1 = Convert.ToInt32(textBoxLeftOffset.Text);
                y1 = 0;
                x2 = Convert.ToInt32(textBoxLeftOffset.Text);
                y2 = pictureBox1.Height;
                // Draw line to screen.
                using (var graphics = Graphics.FromImage(bmp))
                {
                    graphics.DrawLine(blackPen, x1, y1, x2, y2);
                }

                x1 = (pictureBox1.Width - Convert.ToInt32(textBoxRightOffset.Text));
                y1 = 0;
                x2 = (pictureBox1.Width - Convert.ToInt32(textBoxRightOffset.Text));
                y2 = pictureBox1.Height;
                // Draw line to screen.
                using (var graphics = Graphics.FromImage(bmp))
                {
                    graphics.DrawLine(blackPen, x1, y1, x2, y2);
                }

                pictureBox1.Image = bmp;
            }
        }
        private void TextKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if(textBox5.Text !="")
            {
                xSize = Convert.ToInt32(textBox5.Text);
            }
            else
            {
                xSize = 400;
            }
            if (textBox6.Text != "")
            {
                ySize = Convert.ToInt32(textBox6.Text);
            }
            else
            {
                ySize = 400;
            }


            DrawText();

        }
    }
}
