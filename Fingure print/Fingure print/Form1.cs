using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fingure_print
{
    public partial class Form1 : Form
    {
        Bitmap bitmapPictureBox1;
        Bitmap bitmapPictureBox2;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null || pictureBox2.Image == null)
            {
                MessageBox.Show("Upload Image");
            }

            else
            {
                try
                {

                    int alphaPic1 = 0, redPic1 = 0, greenPic1 = 0, bluePic1 = 0;
                    int alphaPic2 = 0, redPic2 = 0, greenPic2 = 0, bluePic2 = 0;
                    try
                    {



                        Color pixelColor1;
                        for (int i = 0; i < bitmapPictureBox1.Width; i++)
                        {
                            for (int j = 0; j < bitmapPictureBox1.Height; j++)
                            {

                                pixelColor1 = bitmapPictureBox1.GetPixel(i, j);
                                int alpha1 = pixelColor1.A;
                                alphaPic1 += alpha1;

                                int red1 = pixelColor1.R;
                                redPic1 += red1;

                                int green1 = pixelColor1.G;
                                greenPic1 += green1;

                                int blue1 = pixelColor1.B;
                                bluePic1 += blue1;

                                // int avg1 = (red1 + green1 + blue1) / 3;

                                //bitmapPictureBox1.SetPixel(i, j, Color.FromArgb(alpha1, avg1, avg1, avg1));
                            }

                        }





                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Picture 1   " + ex);
                    }

                    try
                    {

                        Color pixelColor2;
                        for (int x = 0; x < bitmapPictureBox2.Width; x++)
                        {
                            for (int y = 0; y < bitmapPictureBox2.Height; y++)
                            {

                                pixelColor2 = bitmapPictureBox2.GetPixel(x, y);
                                int alpha2 = pixelColor2.A;
                                alphaPic2 += alpha2;

                                int red2 = pixelColor2.R;
                                redPic2 += red2;

                                int green2 = pixelColor2.G;
                                greenPic2 += green2;

                                int blue2 = pixelColor2.B;
                                bluePic2 += blue2;
                                //int avg2 = (red2 + green2 + blue2) / 3;

                                // bitmapPictureBox2.SetPixel(x, y, Color.FromArgb(alpha2, avg2, avg2, avg2));
                            }

                        }


                        pictureBox1.Image = bitmapPictureBox1;


                        pictureBox2.Image = bitmapPictureBox2;

                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("Picture 2  " + ex2);
                    }



                    int posX_of_pic1 = bitmapPictureBox1.Height / 2;
                    int posY_of_pic1 = bitmapPictureBox1.Width / 2;
                    Color Color_pic1PosXY = bitmapPictureBox1.GetPixel(posX_of_pic1, posY_of_pic1);

                    int posX_of_pic2 = bitmapPictureBox2.Height / 2;
                    int posY_of_pic2 = bitmapPictureBox2.Width / 2;
                    Color Color_pic1Pos2XY = bitmapPictureBox2.GetPixel(posX_of_pic2, posY_of_pic2);

                    int pic1X10 = posX_of_pic1 + 10;
                    int pic1Y10 = posY_of_pic1 + 10;
                    Color Color_pic1Pos10XY = bitmapPictureBox1.GetPixel(pic1X10, pic1Y10);

                    int pic2X10 = posX_of_pic1 + 10;
                    int pic2Y10 = posY_of_pic1 + 10;
                    Color Color_pic1PosM10XY = bitmapPictureBox2.GetPixel(pic2X10, pic2Y10);

                    int pic1XM10 = posX_of_pic1 - 10;
                    int pic1YM10 = posY_of_pic1 - 10;
                    Color Color_pic1Pos10MXY = bitmapPictureBox1.GetPixel(pic1XM10, pic1YM10);

                    int pic2XM10 = posX_of_pic2 - 10;
                    int pic2YM10 = posY_of_pic2 - 10;
                    Color Color_pic2Pos10MXY = bitmapPictureBox1.GetPixel(pic2XM10, pic2YM10);



                    if (Color_pic1PosXY == Color_pic1Pos2XY && Color_pic1Pos10XY == Color_pic1PosM10XY && Color_pic1Pos10MXY == Color_pic2Pos10MXY && alphaPic1 == alphaPic2 && redPic1 == redPic2 && greenPic1 == greenPic2 && bluePic1 == bluePic2)
                    {
                        label1.ForeColor = Color.FromArgb(252, 0, 252, 0);
                        label1.Text = "Same";
                    }
                    else
                    {
                        label1.ForeColor = Color.FromArgb(252, 244, 0, 0);
                        label1.Text = "Not Same";

                    }
                }
                catch(Exception)
                {
                    label1.ForeColor = Color.FromArgb(252, 244, 0, 0);
                    label1.Text = "Not Same";
                }
            
                
                }
            
            
        }
        OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
        private void BtnChoosePic1_Click(object sender, EventArgs e)
        {
            
            if(OpenFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                
                pictureBox1.ImageLocation = OpenFileDialog1.FileName;
               
                bitmapPictureBox1 = new Bitmap(OpenFileDialog1.FileName);
            }
            label1.ForeColor = Color.FromArgb(252, 0, 0, 0);
            label1.Text = "0";
        }
        OpenFileDialog OpenFileDialog2 = new OpenFileDialog();
        private void btnChoosePic2_Click(object sender, EventArgs e)
        {
            
            if(OpenFileDialog2.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
               
                pictureBox2.ImageLocation = OpenFileDialog2.FileName;
               
                bitmapPictureBox2 = new Bitmap(OpenFileDialog2.FileName);
                
            }
            label1.ForeColor = Color.FromArgb(252, 0, 0, 0);
            label1.Text = "0";
        }
    }
}
