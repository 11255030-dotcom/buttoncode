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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static int picnum=0;
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            picnum = 1;
            form3.ShowDialog();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            picnum = 2;
            form3.ShowDialog();
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            picnum = 3;
            form3.ShowDialog();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public static void refresh()
        {
            Application.Run(new Form2());

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "當選" + Form3.buynum[0] + "次";
            label2.Text = "當選" + Form3.buynum[1] + "次";
            label3.Text = "當選" + Form3.buynum[2] + "次";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            label1.Text = "當選" + Form3.buynum[0] + "次";
            label2.Text = "當選" + Form3.buynum[1] + "次";
            label3.Text = "當選" + Form3.buynum[2] + "次";
        }
    }
}
