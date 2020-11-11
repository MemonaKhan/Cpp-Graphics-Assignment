using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox[] drop = new PictureBox[34];
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            drop[0] = pictureBox2; drop[12] = pictureBox14; drop[24] = pictureBox26;
            drop[1] = pictureBox3; drop[13] = pictureBox15; drop[25] = pictureBox27;
            drop[2] = pictureBox4; drop[14] = pictureBox16; drop[26] = pictureBox28;
            drop[3] = pictureBox5; drop[15] = pictureBox17; drop[27] = pictureBox29;
            drop[4] = pictureBox6; drop[16] = pictureBox18; drop[28] = pictureBox30;
            drop[5] = pictureBox7; drop[17] = pictureBox19; drop[29] = pictureBox31;
            drop[6] = pictureBox8; drop[18] = pictureBox20; drop[30] = pictureBox32;
            drop[7] = pictureBox9; drop[19] = pictureBox21; drop[31] = pictureBox33;
            drop[8] = pictureBox10; drop[20] = pictureBox22; drop[32] = pictureBox34;
            drop[9] = pictureBox11; drop[21] = pictureBox23; drop[33] = pictureBox35;
            drop[10] = pictureBox12; drop[22] = pictureBox24; 
            drop[11] = pictureBox13; drop[23] = pictureBox25;
            for (int i = 0; i < 34; i++)
            {
                Bitmap bmp = new Bitmap(drop[i].Image);
                bmp.MakeTransparent(bmp.GetPixel(5, 5));
                drop[i].Image = (Image)bmp;
            }
        }

        int y = 100;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r1 = new Random();
           
            for (int i = 0; i < 34; i++)
            {
                drop[i].Location = new Point(r1.Next(30 * i, 35 * i), r1.Next(100, 600));
            }
            y += 10;
        }
    }
}
