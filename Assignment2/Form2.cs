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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            car.Image=Image.FromFile(@"D:\2nd semester\OOPs\Pictures\cardown.png");
            car.Location = new Point(12, 495);
            timer1.Enabled = true;
        }

        int x = 12;
        int y = 495;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x < 723 && y == 495)
            {
                car.Image = Image.FromFile(@"D:\2nd semester\OOPs\Pictures\cardown.png");
                car.Location = new Point(x, y);
                car.Size = new Size(126, 64);
                x++;
                
            }
            else if (x == 723 && y > 16)
            {
                car.Image = Image.FromFile(@"D:\2nd semester\OOPs\Pictures\carright.png");
                car.Location = new Point(x, y);
                car.Size = new Size(64, 126);
                y--;
            }
            else if (x > 12 && y == 16)
            {
                car.Image = Image.FromFile(@"D:\2nd semester\OOPs\Pictures\carup.png");
                car.Location = new Point(x, y);
                car.Size = new Size(126, 64);
                x--;
            }
            else if (x == 12 && y < 495)
            {
                car.Image = Image.FromFile(@"D:\2nd semester\OOPs\Pictures\carleft.png");
                car.Location = new Point(x, y);
                car.Size = new Size(64, 126);
                y++;
            }

        }
    }

        
}
