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
using System.Diagnostics;

namespace personalAssistant
{
    public partial class image_edit : Form
    {
        public image_edit()
        {
            InitializeComponent();
        }
        List<ColorMatrix> colorList = new List<ColorMatrix>();


        Image file;
        Boolean opened = false; //to check whether the pic is open in pic box or not
        void openImage()
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                pictureBox2.Image = file;
                opened = true;

            }


        }

        void saveImage()
        {

            if (opened)
            {

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Images|* .png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    string ext = Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpeg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;




                    }
                    pictureBox2.Image.Save(sfd.FileName, format);


                }




            }
            else
            {

                MessageBox.Show("PLEASE OPEN AN IMAGE FIRST");

            }


        }
        void filter1()
        {
            if (!opened)
            {
                MessageBox.Show("OPEN PIC FIRST");
            }
            else
            {
                Image img = pictureBox2.Image;
                Bitmap bmInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                
                new float[]{.393f,.349f+0.5f,.272f,0,0},
                new float[]{.769f+0.3f,.686f,.534f,0,0},
                new float[]{.183f,.169f,.131f+0.5f,0,0},
                new float[]{0,0,0,1,0},
                new float[]{0,0,0,0,1}
                
                
                });

                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox2.Image = bmInverted;


            }

        }




        void filter2()
        {
            if (!opened)
            {
                MessageBox.Show("OPEN PIC FIRST");
            }
            else
            {
                Image img = pictureBox2.Image;
                Bitmap bmInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                
                new float[]{.593f,.39f,.0f,0,0},
                new float[]{.769f+0.3f,.986f,.534f,0,0},
                new float[]{.183f,.169f,0,0,0},
                new float[]{0,0,0,1,0},
                new float[]{0,0,0,0,1}
                
                
                });

                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox2.Image = bmInverted;


            }

        }


        void filter3()
        {
            if (!opened)
            {
                MessageBox.Show("OPEN PIC FIRST");
            }
            else
            {
                Image img = pictureBox2.Image;
                Bitmap bmInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                
                new float[]{.393f,.349f+0.5f,.272f,0,0},
                new float[]{.769f+0.3f,.686f,.534f,0,0},
                new float[]{.183f,.169f,.131f+0.5f,0,0},
                new float[]{.40f,.10f,.30f,1,0},
                new float[]{0.8f,.10f,.2f,0,1}
                
                
                });

                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox2.Image = bmInverted;


            }

        }

        void filter4()
        {
            if (!opened)
            {
                MessageBox.Show("OPEN PIC FIRST");
            }
            else
            {
                Image img = pictureBox2.Image;
                Bitmap bmInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                
                new float[]{0,0.5f,.272f,0,0},
                new float[]{.79f+0.3f,.686f,.534f,0,0},
                new float[]{.83f,.19f,.131f,0,0},
                new float[]{0,0,0,1,0},
                new float[]{0,0,0,0,1}
                
                
                });

                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox2.Image = bmInverted;


            }

        }



        void filter5()
        {
            if (!opened)
            {
                MessageBox.Show("OPEN PIC FIRST");
            }
            else
            {
                Image img = pictureBox2.Image;
                Bitmap bmInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                
                new float[]{.393f,.349f+0.5f,.272f,0,0},
                new float[]{.4f+0.3f,.686f,.534f,0,.9f},
                new float[]{.183f,.339f,.131f+0.5f,0.34f,0},
                new float[]{0,.30f,0,1,0},
                new float[]{0,0,0,0,1}
                
                
                });

                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox2.Image = bmInverted;


            }

        }


        void filter6()
        {
            if (!opened)
            {
                MessageBox.Show("OPEN PIC FIRST");
            }
            else
            {
                Image img = pictureBox2.Image;
                Bitmap bmInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                
                new float[]{.193f,.149f+0.5f,.172f,0,0},
                new float[]{.569f,.086f,.134f,.650f,0},
                new float[]{.183f,.169f,.5f,0,0},
                new float[]{0,.10f,0,1,0},
                new float[]{0,0,0,0,1}
                
                
                });

                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox2.Image = bmInverted;


            }

        }

        void reload()
        {

            if (!opened)
            {
                MessageBox.Show("open an image first");

            }
            else
            {
                if (opened)
                {
                    file = Image.FromFile(openFileDialog1.FileName);
                    pictureBox2.Image = file;
                    opened = true;


                }



            }


        }

        void hue()
        {

            float changeRed = redBar.Value * 0.1f;
            float changeGreen = greenBar.Value * 0.1f;
            float changeBlue =blueBar.Value* 0.1f;
            reload();

            if (!opened)
            {
                MessageBox.Show("Open an image");
            }
            else
            {
                Image img = pictureBox2.Image;
                Bitmap bmInverted = new Bitmap(img.Width, img.Height);
                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                
                new float[]{1+changeRed,0,0,0,0},
                new float[]{0,1+changeGreen,0,0,0},
                new float[]{0,0,1+changeBlue,0,0},
                new float[]{0,0,0,1,0},
                new float[]{0,0,0,0,1}
                
                
                });

                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox2.Image = bmInverted;



            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            reload();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            openImage();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            saveImage();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            reload();
            filter1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reload();
            filter2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reload();
            filter3();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reload();
            filter4();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reload();
            filter5();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            reload();
            filter6();
        }

        private void blueBar_ValueChanged(object sender, EventArgs e)
        {
            hue();
        }

        private void greenBar_ValueChanged(object sender, EventArgs e)
        {
            hue();
        }

        private void redBar_ValueChanged(object sender, EventArgs e)
        {
            hue();
        }

        //private void redBar_ValueChanged(object sender, EventArgs e)
        //{
        //    hue();
        //}

        //private void greenBar_ValueChanged(object sender, EventArgs e)
        //{
        //    hue();
        //}

        //private void blueBar_ValueChanged(object sender, EventArgs e)
        //{
        //    hue();
        //}

    }
}
