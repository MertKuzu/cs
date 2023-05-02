namespace Proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        int soruNO = 0, dogru = 0, yanlis = 0, sayac = 10;
        bool kontrol = true;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           sayac--;
           label6.Text = sayac.ToString();
           if (sayac == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Süreniz doldu");
                button22.PerformClick();
                button21.PerformClick();
            }
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (kontrol == false)
            {
                MessageBox.Show("Bu soruya cevap verdiniz!");
            }
            else
            {
                timer1.Enabled = false;
                switch (soruNO)
                {
                    case 1:
                        if (textBox1.Text == "ankara")
                        {
                            dogru++;
                            button1.BackColor = Color.Green;
                            label2.Text = dogru.ToString();
                            kontrol = false;
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                            kontrol = false;
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            dogru++;
                            button2.BackColor = Color.Green;
                            label2.Text = dogru.ToString();
                            kontrol = false;
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                            kontrol = false;
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "ceviz")
                        {
                            dogru++;
                            button1.BackColor = Color.Green;
                            label2.Text = dogru.ToString();
                            kontrol = false;
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                            kontrol = false;
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "denizli")
                        {
                            dogru++;
                            button4.BackColor = Color.Green;
                            label2.Text = dogru.ToString();
                            kontrol = false;
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                            kontrol = false;
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "edirne")
                        {
                            dogru++;
                            button5.BackColor = Color.Green;
                            label2.Text = dogru.ToString();
                            kontrol = false;
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                            kontrol = false;
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "fare")
                        {
                            dogru++;
                            button6.BackColor = Color.Green;
                            label2.Text = dogru.ToString();
                            kontrol = false;
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                            kontrol = false;
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "hatay")
                        {
                            dogru++;
                            button6.BackColor = Color.Green;
                            label2.Text = dogru.ToString();
                            kontrol = false;
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                            kontrol = false;
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "hatay")
                        {
                            dogru++;
                            button6.BackColor = Color.Green;
                            label2.Text = dogru.ToString();
                            kontrol = false;
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                            kontrol = false;
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "kemal")
                        {
                            dogru++;
                            button6.BackColor = Color.Green;
                            label2.Text = dogru.ToString();
                            kontrol = false;
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                            kontrol = false;
                        }
                        break;
                }
            }
            
        }


        private void button21_Click(object sender, EventArgs e)
        {
            button21.Text = "Sonraki";
            soruNO++;
            kontrol = true;
            timer1.Enabled = true;
            this.Text = "Soru No: " + soruNO;
            sayac = 10;
            if (soruNO == 1)
            {
                richTextBox1.Text = "Türkiye'nin baþkenti neresidir?";
                button1.BackColor = Color.Yellow;
            }
            if (soruNO == 2)
            {
                richTextBox1.Text = "Kestanesi ile meþhur ilimiz?";
                button2.BackColor = Color.Yellow;
                
            }
            if (soruNO == 3)
            {
                richTextBox1.Text = "Beyin yakan kuruyemiþ?";
                button3.BackColor = Color.Yellow;
                
            }
            if (soruNO == 4)
            {
                richTextBox1.Text = "Pamukkale hangi ilimizdedir?";
                button4.BackColor = Color.Yellow;
                
            }
            if (soruNO == 5)
            {
                richTextBox1.Text = "Selemiye camisi hnagi ilimizde bulunmaktadýr?";
                button5.BackColor = Color.Yellow;
                
            }
            if (soruNO == 6)
            {
                richTextBox1.Text = "Deneylerde kullanýlan bir hayvan?";
                button6.BackColor = Color.Yellow;
                
            }
            if (soruNO == 7)
            {
                richTextBox1.Text = "Künefeyle ünlü ilimiz?";
                button7.BackColor = Color.Yellow;
            }
            if (soruNO == 8)
            {
                richTextBox1.Text = "Anadolunun yüce daðýnýn ismi?";
                button8.BackColor = Color.Yellow;
            }
            if (soruNO == 9)
            {
                richTextBox1.Text = "Atatürkün 2. adý ?";
                button8.BackColor = Color.Yellow;
            }
        }
    }
}