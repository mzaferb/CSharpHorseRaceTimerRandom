namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int horse1, horse2, horse3;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnReset.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left + rnd.Next(1, 20);
            pictureBox2.Left = pictureBox2.Left + rnd.Next(1, 20);
            pictureBox3.Left = pictureBox3.Left + rnd.Next(1, 20);

            if (pictureBox1.Left >= 1036 || pictureBox2.Left >= 1036 || pictureBox3.Left >= 1036)
            {
                timer1.Stop();

                horse1 = pictureBox1.Left;
                horse2 = pictureBox2.Left;
                horse3 = pictureBox3.Left;

                if (horse1 > horse2 && horse1 > horse3)
                {
                    label6.Text = "Winner :  ' 1 '";
                    btnReset.Visible = true;
                }
                else if (horse2 > horse1 && horse2 > horse3)
                {
                    label6.Text = "Winner :  ' 2 '";
                    btnReset.Visible = true;
                }
                else
                {
                    label6.Text = "Winner :  ' 3 '";
                    btnReset.Visible = true;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnReset.Visible = false;
            btnStart.Visible = true;

            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;

            label6.Text = "Winner :";
        }
    }
}