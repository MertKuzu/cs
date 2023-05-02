namespace sınav1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("40TL " + button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("10TL " + button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("35TL " + button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("10TL " + button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("10TL " + button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("40TL " + button6.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (string s in listBox1.SelectedItems.OfType<string>().ToList())
                listBox1.Items.Remove(s);
        }
        string price;
        int n = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Masa adı girin.");
            }
            else
            {
                foreach(string i in listBox1.Items)
                {
                    price = i[0].ToString()+i[1].ToString();
                    n += Convert.ToInt32(price);
                    
                }

                listBox2.Items.Add(textBox1.Text + ", Toplam Fiyat: " + n);
                n = 0;
            }
        }
    }
}