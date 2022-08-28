using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace ProjectLTUD
{
    public partial class Filter : Form
    {

        Image file;
        Boolean opened = false;

        public Filter()
        {
            InitializeComponent();
        }
        Mat img = new Mat();

         private void ColorButtonClick(object sender, EventArgs e)
         {
             foreach (Control c in panel1.Controls)
             {
                 c.BackColor = Color.Aqua;

             }
             Control click = (Control)sender;
            click.BackColor = Color.Aqua;

         }

        private void ColorButtonLeave(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                c.BackColor = Color.Transparent;

            }
            Control leave = (Control)sender;
            leave.BackColor = Color.Transparent;

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            if (file.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = file.FileName;
                opened = true;
                img = Cv2.ImRead(textBox1.Text);
                pictureBox1.Image = img.ToBitmap();
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = img.ToBitmap();
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        void hue()
        {
            float changered = RBar.Value * 0.1f;
            float changegreen = GBar.Value * 0.1f;
            float changeblue = BBar.Value * 0.1f;

            RValue.Text = changered.ToString();
            BValue.Text = changeblue.ToString();
            GValue.Text = changegreen.ToString();

            img = Cv2.ImRead(textBox1.Text);
            pictureBox2.Image = img.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            if (!opened)
            {
            }
            else
            {



                Image img = pictureBox2.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{1+changered, 0,             0,            0, 0},
                    new float[]{0,           1+changegreen, 0,            0, 0},
                    new float[]{0,           0,             1+changeblue, 0, 0},
                    new float[]{0,           0,             0,            1, 0},
                    new float[]{0,           0,             0,            0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox2.Image = bmpInverted;


            }
        }
        void FL()
        {
            float c = FLBar.Value /255.0f;
            FLValue.Text = FLBar.Value.ToString();

            img = Cv2.ImRead(textBox1.Text);
            pictureBox2.Image = img.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
            
                Image img = pictureBox2.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    //new float[]{1,                  0,             0,            0, 0},
                    //new float[]{0,                  1,             0,            0, 0},
                    //new float[]{0,                  0,             1,            0, 0},
                    //new float[]{0,                  0,             0,            1, 0},
                    //new float[]{changeBrightness, changeBrightness, changeBrightness,           1, 1}
                    new float[]{1,0,0,0,0},
                    new float[]{0,1,0,0,0},
                    new float[]{0,0,1,0,0},
                    new float[]{0,0,0,1,0},
                    new float[]{c,c,c,0f,1f}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox2.Image = bmpInverted;

            }
        }

        // Filter CLick
        private void button1_Click(object sender, EventArgs e) // show
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                img = Cv2.ImRead(textBox1.Text);
                pictureBox2.Image = img.ToBitmap();
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            ColorButtonClick(ShowImage, null);

        }

        Mat[] RGB = new Mat[3];
        private void SplitImg_Click(object sender, EventArgs e)
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                hue();
            }
            ColorButtonClick(SplitImg, null);
        }

        private void Sobel_Click(object sender, EventArgs e)
        {
            Mat imggray_sobel = new Mat();
            Cv2.CvtColor(img, imggray_sobel, ColorConversionCodes.BGR2GRAY);
            Mat imgsobel = new Mat();
            Cv2.Sobel(imggray_sobel, imgsobel, -1, 1, 0);
            pictureBox2.Image = imgsobel.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            ColorButtonClick(Sobel, null);
        }

        private void deleteImg_Click(object sender, EventArgs e)
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                pictureBox1.Image = null;
                pictureBox2.Image = null;
            }
        }

        private void GauseFilter_Click(object sender, EventArgs e)
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Mat imggray_gause = new Mat();
                Cv2.CvtColor(img, imggray_gause, ColorConversionCodes.BGR2GRAY);
                Mat imgGause = new Mat();
                Cv2.GaussianBlur(imggray_gause, imgGause, new OpenCvSharp.Size(3, 3), 1);
                pictureBox2.Image = imgGause.ToBitmap();
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            ColorButtonClick(GauseFilter, null);
        }

        private void Filter_Load(object sender, EventArgs e)
        {

        }

        private void GrayClick(object sender, EventArgs e)
        {
            img = Cv2.ImRead(textBox1.Text);
            pictureBox2.Image = img.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = pictureBox2.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{0.299f, 0.299f, 0.299f, 0, 0},
                    new float[]{0.587f, 0.587f, 0.587f, 0, 0},
                    new float[]{0.114f, 0.114f, 0.114f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 0}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox2.Image = bmpInverted;
            }
            ColorButtonClick(Gray, null);
        }

        private void Sepia_Click(object sender, EventArgs e)
        {
            img = Cv2.ImRead(textBox1.Text);
            pictureBox2.Image = img.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {

                Image img = pictureBox2.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{.393f, .349f, .272f, 0, 0},
            new float[]{.769f, .686f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox2.Image = bmpInverted;

            }
            ColorButtonClick(Sepia, null);
        }

        private void Flash_Click(object sender, EventArgs e)
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                FL();
            }
            ColorButtonClick(Flash, null);
        }

        private void Exposure_Click(object sender, EventArgs e)
        {
            img = Cv2.ImRead(textBox1.Text);
            pictureBox2.Image = img.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = pictureBox2.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{-1, 0, 0, 0, 0},
                    new float[]{0, -1, 0, 0, 0},
                    new float[]{0, 0,-1, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{1, 1, 1, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox2.Image = bmpInverted;
            }
            ColorButtonClick(Exposure, null);
        }
        private void BGR_Click(object sender, EventArgs e)
        {
            img = Cv2.ImRead(textBox1.Text);
            pictureBox2.Image = img.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = pictureBox2.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{0, 0, 1, 0, 0},
                    new float[]{0, 1, 0, 0, 0},
                    new float[]{1, 0, 0, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 0}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox2.Image = bmpInverted;
            }
            ColorButtonClick(BGR, null);
        }

        private void BlackWhite_Click(object sender, EventArgs e)
        {
            img = Cv2.ImRead(textBox1.Text);
            pictureBox2.Image = img.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = pictureBox2.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[] {1, -0.2f, 0, 0, 0},
                     new float[] {0, 1, 0, -0.1f, 0},
                     new float[] {0, 1.2f, 1, 0.1f, 0}, //1.5f, 1.5f, 1.5f, 0, 0
                     new float[] {0, 0, 1.7f, 1, 0},
                     new float[] {0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox2.Image = bmpInverted;
            }
            ColorButtonClick(BlackWhile, null);
        }
        ///
        /// 
        ///
        ///
        /// 
        // Filter btn leave
        private void button1_Leave(object sender, EventArgs e)
        {
            ColorButtonLeave(ShowImage, null);
        }

        private void SplitImg_Leave(object sender, EventArgs e)
        {
            ColorButtonLeave(SplitImg, null);
        }

        private void Sobel_Leave(object sender, EventArgs e)
        {
            ColorButtonLeave(Sobel, null);
        }

        private void GauseFilter_Leave(object sender, EventArgs e)
        {
            ColorButtonLeave(GauseFilter, null);
        }

        private void Gray_Leave(object sender, EventArgs e)
        {
            ColorButtonLeave(Gray, null);
        }

        private void Sepia_Leave(object sender, EventArgs e)
        {
            ColorButtonLeave(Sepia, null);
        }

        private void Flash_Leave(object sender, EventArgs e)
        {
            ColorButtonLeave(Flash, null);
        }

        private void Exposure_Leave(object sender, EventArgs e)
        {
            ColorButtonLeave(Exposure, null);
        }

        private void BGR_Leave(object sender, EventArgs e)
        {
            ColorButtonLeave(BGR, null);
        }

        private void BlackWhite_Leave(object sender, EventArgs e)
        {
            ColorButtonLeave(BlackWhile, null);
        }
        /// 
        /// 
        /// 
        ///

        private void radioR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioG_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioB_CheckedChanged(object sender, EventArgs e)
        {

        }
        float gma = 0;

        void SaveImage()
        {
            if (opened)
            {
                SaveFileDialog sfd = new SaveFileDialog(); // create a new save file dialog object
                sfd.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png;// you want to store it in by default format
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox2.Image.Save(sfd.FileName, format);
                }


            }
            else { MessageBox.Show("No image loaded, first upload image "); }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void RBar_ValueChanges(object sender, EventArgs e)
        {

        }

        private void GBar_ValueChanges(object sender, EventArgs e)
        {

        }

        private void BBar_ValueChanges(object sender, EventArgs e)
        {

        }

        private void RBar_Scroll(object sender, EventArgs e)
        {
            hue();
        }

        private void GBar_Scroll(object sender, EventArgs e)
        {
            hue();
        }

        private void BBar_Scroll(object sender, EventArgs e)
        {
            hue();
        }

        private void FLBar_ValueChanges(object sender, EventArgs e)
        {

        }

        private void FLBar_Scroll(object sender, EventArgs e)
        {
            FL();
        }


    }
}   
