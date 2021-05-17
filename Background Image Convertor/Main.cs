using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Background_Image_Convertor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            int height = ColorTrackBar.Location.Y - 100 - pianoheight;
            int width = (int)((double)height / 9 * 16);
            Bitmap result = new Bitmap(width, height);
            Graphics resultGraphics = Graphics.FromImage(result);
            resultGraphics.CopyFromScreen(new Point(this.Location.X + locForCenteredImage.X + 10, this.Location.Y + locForCenteredImage.Y + 50), new Point(0, 0), new Size(width, height));
            //g.DrawRectangle(new Pen(new SolidBrush(Color.Green), 3), new Rectangle(locForCenteredImage, new Size(width, height)));
            SaveFileDialog d = new SaveFileDialog();
            string mypath = "D:\\Clouds\\Mega\\DanielMusicIL\\Synthesia\\Updated Images";
            if (System.IO.Directory.Exists(mypath))
                d.InitialDirectory = mypath;
            d.FileName= System.IO.Path.GetFileNameWithoutExtension(PathTextBox.Text);
            if (d.ShowDialog() == DialogResult.OK)
                result.Save(d.FileName+".png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            string mypath = "D:\\Clouds\\Mega\\DanielMusicIL\\Synthesia\\Images";
            if (System.IO.Directory.Exists(mypath))
                f.InitialDirectory = mypath;
            f.Filter = "JPG (*.jpg)|*.jpg| PNG (*.png)|*.png| All Files (*.*)|*.*";
            if (f.ShowDialog() == DialogResult.OK)
            {
                PathTextBox.Text = f.FileName;
                OutlinePanel.Enabled = true;
            }
        }
        Graphics g;
        Color SelectedColor = Color.Black;
        Color[] DefualtColors = new Color[10] 
        { 
            Color.Black,
            Color.White,
            Color.Red, 
            Color.Blue, 
            Color.Green, 
            Color.Gray, 
            Color.DarkGray, 
            Color.Yellow, 
            Color.Orange, 
            Color.Purple, 
        };
        const int startY = 100;
        private void Main_Paint(object sender, PaintEventArgs e)
        {
            
            //g.DrawLine(new Pen(Color.Black), new Point(this.Width/2, startY), new Point(this.Width/2,ColorTrackBar.Location.Y));
            drawSelectedColor();
            for (int i = 0; i < DefualtColors.Length; i++)
            {
                g.FillRectangle(new SolidBrush(DefualtColors[i]), new Rectangle(new Point(i*(ColorTrackBar.Size.Width/(ColorTrackBar.Maximum-ColorTrackBar.Minimum)-7),ColorTrackBar.Location.Y+ColorTrackBar.Size.Height), new Size(100,GenerateButton.Location.Y-ColorTrackBar.Location.Y-ColorTrackBar.Height)));
            }
            if (PathTextBox.Text != "")
            {
                drawn = false;
                Image img = new Bitmap(PathTextBox.Text);
                //g.DrawImage(img, CenterObj(img,new Point(0, startY),new Size(this.Width/2, ColorTrackBar.Location.Y - startY)));
                //g.DrawImage(img, CenterObj(img, new Point(0, startY), new Size(this.Width, ColorTrackBar.Location.Y - startY-pianoheight)));
                int height = ColorTrackBar.Location.Y - startY - pianoheight;
                int width = (int)((double)height / 9 * 16);
                locForCenteredImage = CenterImg(ResizeImage(img, width, height),new Point(0, 70), new Size(this.Width, height));
                drawImage();
                if (!drawn)
                    drawSynthesiaLines(locForCenteredImage, width, height);
            }
            if (load)
                drawpiano();
        }
        Point locForCenteredImage;
        public void drawSynthesiaLines(Point loc ,int width,int height)
        {
            for (int i = 0; i < whitekeycount; i++)
            {
                if (((i - 2) % 7 == 0) || ((i - 5) % 7 == 0))
                    g.DrawLine(new Pen(SelectedColor, (i - 2) % 7 == 0 ? 2 : 1), new Point(loc.X + (int)(i * (double)width / (double)whitekeycount), loc.Y), new Point(loc.X + (int)(i * (double)width / (double)whitekeycount), loc.Y + height));
            }
            drawn = true;
        }
        public Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        bool load = true, drawn=false;
        const int pianoheight = 50, whitekeycount = 52;
        public void drawpiano()
        {
            //draw a piano
            Pen blackpen = new Pen(Color.Black);
            Size pianosize = new Size((int)((double)((ColorTrackBar.Location.Y - 100 - pianoheight) / 9 * 16)), pianoheight);
            Point startpoint = new Point(this.Width/2-pianosize.Width/2, ColorTrackBar.Location.Y - pianoheight - 25);
            double notewidth = ((double)pianosize.Width / (double)whitekeycount);
            g.FillRectangle(new SolidBrush(Color.FromArgb(252, 250, 238)), new Rectangle(startpoint, pianosize));
            for (int i = 0; i < whitekeycount + 1; i++)
            {
                g.DrawLine(blackpen, new Point(startpoint.X + (int)(i * notewidth), startpoint.Y), new Point(startpoint.X + (int)(i * notewidth), startpoint.Y + pianosize.Height));
            }
            g.DrawLine(blackpen, startpoint, new Point(startpoint.X + pianosize.Width, startpoint.Y));
            g.DrawLine(blackpen, new Point(startpoint.X, startpoint.Y + pianosize.Height), new Point(startpoint.X + pianosize.Width, startpoint.Y + pianosize.Height));
            for (int i = 0; i < whitekeycount - 1; i++)
            {
                if (!(((i - 1) % 7 == 0) || ((i - 4) % 7 == 0)))
                    g.FillRectangle(new SolidBrush(Color.Black), new Rectangle(new Point(startpoint.X + (int)((i + (double)1 / 2) * notewidth) + 1, startpoint.Y), new Size((int)(notewidth) - 2, pianosize.Height / 3 * 2)));
            }
            load = false;
        }
        public Point CenterImg(Image img ,Point zero,Size area)
        {
             return new Point(zero.X+area.Width/2-img.Size.Width/2,zero.Y+area.Height/2-img.Size.Height/2);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            
        }
        public void drawSelectedColor()
        {
            g.FillRectangle(new SolidBrush(SelectedColor), new Rectangle(new Point(this.Size.Width - 150, this.Size.Height - 200 - GenerateButton.Height+10), new Size(100, 100)));
        }
        public bool isBlack(Color c)
        {
            return (c.R < 10 && c.G < 10 && c.B < 10);
        }
        public Bitmap removeDarkTop(Bitmap b)
        {
            int pixelsToCut = 0;
            for (int i = 0; i < b.Height / 2; i++)
            {
                Color c1 = b.GetPixel(b.Width / 2, i);
                Color c2 = b.GetPixel(b.Width / 3, i);
                Color c3 = b.GetPixel(b.Width / 3 * 2, i);
                if (!(isBlack(c1) && isBlack(c2) && isBlack(c3)))
                {
                    pixelsToCut = i;
                    break;
                }
            }
            decimal precent = TopNumericUpDown.Value / 100;
            int updatedPIxeltoCut = (int)(pixelsToCut * precent);
            Bitmap result= new Bitmap(b.Width,b.Height- updatedPIxeltoCut);
            Graphics.FromImage(result).DrawImage(b, new Rectangle(new Point(0, 0), result.Size), new Rectangle(new Point(0, updatedPIxeltoCut),new Size(b.Width,b.Height- updatedPIxeltoCut)),GraphicsUnit.Pixel);
            return result;
        }
        public Bitmap removeDarkBottom(Bitmap b)
        {
            int pixelsToCut = 0;
            for (int i = b.Height-1; i > b.Height/2; i--)
            {
                Color c1 = b.GetPixel(b.Width / 2, i);
                Color c2 = b.GetPixel(b.Width / 3, i);
                Color c3 = b.GetPixel(b.Width / 3 * 2, i);
                if (!(isBlack(c1) && isBlack(c2) && isBlack(c3)))
                {
                    pixelsToCut = b.Height - i;
                    break;
                }
            }
            decimal precent = BottomNumericUpDown.Value / 100;
            int updatedPIxeltoCut = (int)(pixelsToCut * precent);
            Bitmap result = new Bitmap(b.Width, b.Height - updatedPIxeltoCut);
            Graphics.FromImage(result).DrawImage(b, new Rectangle(new Point(0, 0), result.Size), new Rectangle(new Point(0, 0), new Size(b.Width, b.Height - updatedPIxeltoCut)), GraphicsUnit.Pixel);
            return result;
        }
        public Bitmap removeDarkRight(Bitmap b)
        {
            int pixelsToCut = 0;
            for (int i = b.Width - 1; i > b.Height / 2; i--)
            {
                Color c1 = b.GetPixel(i, b.Height / 2);
                Color c2 = b.GetPixel(i, b.Height / 3);
                Color c3 = b.GetPixel(i, b.Height / 3 * 2);
                if (!(isBlack(c1) && isBlack(c2) && isBlack(c3)))
                {
                    pixelsToCut = b.Width - i;
                    break;
                }
            }
            decimal precent = RightNumericUpDown.Value / 100;
            int updatedPIxeltoCut = (int)(pixelsToCut * precent);
            Bitmap result = new Bitmap(b.Width - updatedPIxeltoCut, b.Height);
            Graphics.FromImage(result).DrawImage(b, new Rectangle(new Point(0, 0), result.Size), new Rectangle(new Point(0, 0), new Size(b.Width - updatedPIxeltoCut, b.Height)), GraphicsUnit.Pixel);
            return result;
        }
        public Bitmap removeDarkLeft(Bitmap b)
        {
            int pixelsToCut = 0;
            for (int i = 0; i < b.Width / 2; i++)
            {
                Color c1 = b.GetPixel(i, b.Height / 2);
                Color c2 = b.GetPixel(i, b.Height / 3);
                Color c3 = b.GetPixel(i, b.Height / 3 * 2);
                if (!(isBlack(c1) && isBlack(c2) && isBlack(c3)))
                {
                    pixelsToCut = i;
                    break;
                }
            }
            decimal precent = LeftNumericUpDown.Value / 100;
            int updatedPIxeltoCut = (int)(pixelsToCut * precent);
            Bitmap result = new Bitmap(b.Width - updatedPIxeltoCut, b.Height);
            Graphics.FromImage(result).DrawImage(b, new Rectangle(new Point(0, 0), result.Size), new Rectangle(new Point(updatedPIxeltoCut, 0), new Size(b.Width - updatedPIxeltoCut, b.Height)), GraphicsUnit.Pixel);
            return result;
        }

        public void drawImage()
        {
            Image img = new Bitmap(PathTextBox.Text);
            int height = ColorTrackBar.Location.Y - startY - pianoheight;
            int width = (int)((double)height / 9 * 16);
            locForCenteredImage = CenterImg(ResizeImage(img, width, height), new Point(0, 70), new Size(this.Width, height));

            if (TopCheckBox.Checked)
                img = removeDarkTop(new Bitmap(img));
            if (BottomCheckBox.Checked)
                img = removeDarkBottom(new Bitmap(img));
            if (RightCheckBox.Checked)
                img = removeDarkRight(new Bitmap(img));
            if (LeftCheckBox.Checked)
                img = removeDarkLeft(new Bitmap(img));
            img = ResizeImage(img, width, height);
            g.DrawImage(img, locForCenteredImage);
            drawSynthesiaLines(locForCenteredImage, width, height);
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox caller = (CheckBox)sender;
            string name = caller.Name.Substring(0, caller.Name.Length - 8);

            drawImage();
            
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            drawImage();
        }

        private void ColorTrackBar_Scroll(object sender, EventArgs e)
        {
            SelectedColor = DefualtColors[ColorTrackBar.Value];
            drawSelectedColor();
            int height = ColorTrackBar.Location.Y - 100 - pianoheight;
            if (drawn)
                drawSynthesiaLines(locForCenteredImage, (int)((double)height / 9 * 16), height);
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                SelectedColor = cd.Color;
                drawSelectedColor();
                int height = ColorTrackBar.Location.Y - 100 - pianoheight;
                if (drawn)
                    drawSynthesiaLines(locForCenteredImage, (int)((double)height / 9 * 16), height);
            }
        }
    }
}
