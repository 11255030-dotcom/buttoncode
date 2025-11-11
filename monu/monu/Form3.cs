using monu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public static int[] buynum = {0,0,0 };
        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            if (Form2.picnum == 1)
            {

                pictureBox1.Image = Resources.蔣;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (Form2.picnum == 2)
            {

                pictureBox1.Image = Resources.柯;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (Form2.picnum == 3)
            {

                pictureBox1.Image = Resources.王;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text=(int.Parse(textBox1.Text)+1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox1.Text) - 1).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          

            if (Form2.picnum == 1)
            {
                buynum[0] += int.Parse(textBox1.Text);
            }
            if (Form2.picnum == 2)
            {
                buynum[1] += int.Parse(textBox1.Text);
            }
            if (Form2.picnum == 3)
            {
                buynum[2] += int.Parse(textBox1.Text);
            }
        }
    }
}
