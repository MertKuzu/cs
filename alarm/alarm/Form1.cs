namespace alarm
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int sayac;
        private void button1_Click(object sender, EventArgs e)
        {
            if (label3.Text == "")
            {
                if(textBox1.Text != "")
                {
                    sayac = Convert.ToInt32(textBox1.Text);
                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("Boþ býrakmayýn");
                }
               
            }
            else
            {
                sayac = Convert.ToInt32(label3.Text);
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = sayac.ToString();
            sayac--;
            if (sayac == 0)
            {
                timer1.Stop();
                MessageBox.Show("Süre doldu");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label3.Text = "";
            textBox1.Text = "";
            sayac = 0;
        }
    }
}