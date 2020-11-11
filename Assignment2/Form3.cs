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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int score = 0;
        int x = 76;
        int y = 90;
        int i;

        private void Form3_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            blast.Hide();
            killer.BringToFront();
            killer.Image = Image.FromFile(@"D:\2nd semester\OOPs\Pictures\lion.jpg");
            obj1.Image = Image.FromFile(@"D:\2nd semester\OOPs\Pictures\man.jpg");
            obj2.Image = Image.FromFile(@"D:\2nd semester\OOPs\Pictures\man.jpg");
            obj3.Image = Image.FromFile(@"D:\2nd semester\OOPs\Pictures\man.jpg");
            obj4.Image = Image.FromFile(@"D:\2nd semester\OOPs\Pictures\man.jpg");
            obj5.Image = Image.FromFile(@"D:\2nd semester\OOPs\Pictures\man.jpg");
            blast.Image = Image.FromFile(@"D:\2nd semester\OOPs\Pictures\blast.png");
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                i = 10;
            }
            if (e.KeyCode == Keys.Left)
            {
                i = 15;
            }
            if (e.KeyCode == Keys.Up)
            {
                i = 20;
            }
            if (e.KeyCode == Keys.Down)
            {
                i = 25;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 10)
            {
                x = x + 10;
                killer.Location = new Point(x, y);
            }
            if (i == 15)
            {
                x = x - 10;
                killer.Location = new Point(x, y);
            }
            if (i == 20)
            {
                y = y - 10;
                killer.Location = new Point(x, y);
            }
            if (i == 25)
            {
                y = y + 10;
                killer.Location = new Point(x, y);
            }
            if (killer.Bounds.IntersectsWith(obj1.Bounds) && (obj1.Visible))
            {
                blast.Location = obj1.Location;
                blast.Show();
                obj1.Hide();
                score += 1;
                label1.Text = "Score is" + score;
            }
            if (killer.Bounds.IntersectsWith(obj2.Bounds) && (obj2.Visible))
            {
                blast.Location = obj2.Location;
                blast.Show();
                obj2.Hide();
                score += 1;
                label1.Text = "Score is" + score;
            }
            if (killer.Bounds.IntersectsWith(obj3.Bounds) && (obj3.Visible))
            {
                blast.Location = obj3.Location;
                blast.Show();
                obj3.Hide();
                score += 1;
                label1.Text = "Score is" + score;
            }
            if (killer.Bounds.IntersectsWith(obj4.Bounds) && (obj4.Visible))
            {
                blast.Location = obj4.Location;
                blast.Show();
                obj4.Hide();
                score += 1;
                label1.Text = "Score is" + score;
            }
            if (killer.Bounds.IntersectsWith(obj5.Bounds) && (obj5.Visible))
            {
                blast.Location = obj5.Location;
                blast.Show();
                obj5.Hide();
                score += 1;
                label1.Text = "Score is" + score;
            }

        }
    }
}
