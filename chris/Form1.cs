namespace chris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "«õ«Î«õ«Î";
            pictureBox1.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "ÞË!§A¦º¤F";
            pictureBox1.BackColor = Color.Red;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "¶Â£~£°";
            pictureBox1.BackColor = Color.Yellow;
        }
    }
}
