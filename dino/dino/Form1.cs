using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer2.Enabled = true;
            timer2.Interval = 5;
            button1.Visible = false;

            timer3.Enabled = true;
            timer3.Interval = 5;
        }
        bool isjump = false;
        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Bounds.IntersectsWith(pictureBox4.Bounds))
                {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
            }
            pictureBox2.Image = imageList1.Images[num];
            if (isjump)
            {
                pictureBox2.Top -= 200;
            }
                if (num == 1) 
            {
                num = 0;
            }
            else
            {
                num ++;
            }
         
        }
        
        //跑
        private void timer2_Tick(object sender, EventArgs e)
        {
            {
                pictureBox1.Left -= 5;
                pictureBox3.Left -= 5;

                if (pictureBox1.Location.X < -50000)
                {
                    pictureBox1.Left = 50000;
                }
                if (pictureBox3.Location.X < -1390)
                {
                    pictureBox3.Left = 1000;
                }
                label1.Text = pictureBox1.Location.X.ToString();
                label2.Text = pictureBox3.Location.X.ToString();
            }

        }

       
        //仙
        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox4.Left -= 5;
            if(pictureBox4.Location.X<-1000)
            {
                pictureBox4.Left = 1000;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox4.Left = 2000;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                pictureBox2.Top -= 55;
            }
        }
    }
}
