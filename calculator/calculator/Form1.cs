namespace calculator
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

        double ilkSayi, ikinciSayi, sonuc;
        string islem;
        bool ekraniSil = false, enterValue = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ekraniSil == true)
            {
                textBox1.Text = "";
                ekraniSil = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
                
            }
        }

      

        private void button12_Click(object sender, EventArgs e)

        {
            if (ekraniSil == true)
            {
                textBox1.Text = "";
                ekraniSil = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (ekraniSil == true)
            {
                textBox1.Text = "";
                ekraniSil = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (ekraniSil == true)
            {
                textBox1.Text = "";
                ekraniSil = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (ekraniSil == true)
            {
                textBox1.Text = "";
                ekraniSil = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (ekraniSil == true)
            {
                textBox1.Text = "";
                ekraniSil = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (ekraniSil == true)
            {
                textBox1.Text = "";
                ekraniSil = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (ekraniSil == true)
            {
                textBox1.Text = "";
                ekraniSil = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (ekraniSil == true)
            {
                textBox1.Text = "";
                ekraniSil = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (islem == "+")
            {
                sonuc = Convert.ToDouble(textBox1.Text) + ilkSayi;
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
                
            }

            if (islem == "-")
            {
                sonuc = ilkSayi - Convert.ToDouble(textBox1.Text);
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }

            if (islem == "*")
            {
                sonuc = Convert.ToDouble(textBox1.Text) * ilkSayi;
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }

            if (islem == "/")
            {
                sonuc = ilkSayi / Convert.ToDouble(textBox1.Text);
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }

            ilkSayi = Convert.ToDouble(textBox1.Text);
            ekraniSil = true;
            islem = "+";



        
        }


    

        private void button5_Click(object sender, EventArgs e)
        {
            if (islem == "+")
            {
                sonuc = Convert.ToDouble(textBox1.Text) + ilkSayi;
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }

            if (islem == "-")
            {
                sonuc = ilkSayi - Convert.ToDouble(textBox1.Text);
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }

            if (islem == "*")
            {
                sonuc = Convert.ToDouble(textBox1.Text) * ilkSayi;
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }

            if (islem == "/")
            {
                sonuc = ilkSayi / Convert.ToDouble(textBox1.Text);
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }

            ilkSayi = Convert.ToDouble(textBox1.Text);
            ekraniSil = true;
            islem = "-";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (islem == "+")
            {
                sonuc = Convert.ToDouble(textBox1.Text) + ilkSayi;
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }

            if (islem == "-")
            {
                sonuc = ilkSayi - Convert.ToDouble(textBox1.Text);
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }

            if (islem == "*")
            {
                sonuc = Convert.ToDouble(textBox1.Text) * ilkSayi;
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }

            if (islem == "/")
            {
                sonuc = ilkSayi / Convert.ToDouble(textBox1.Text);
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }

            ilkSayi = Convert.ToDouble(textBox1.Text);
            ekraniSil = true;
            islem = "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (islem == "+")
            {
                sonuc = Convert.ToDouble(textBox1.Text) + ilkSayi;
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }

            if (islem == "-")
            {
                sonuc = ilkSayi - Convert.ToDouble(textBox1.Text);
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }

            if (islem == "*")
            {
                sonuc = Convert.ToDouble(textBox1.Text) * ilkSayi;
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }

            if (islem == "/")
            {
                sonuc = ilkSayi / Convert.ToDouble(textBox1.Text);
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }

            ilkSayi = Convert.ToDouble(textBox1.Text);
            ekraniSil = true;
            islem = "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            

            if (islem == "+")
            {
                sonuc = Convert.ToDouble(textBox1.Text) + ilkSayi;
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }

            if (islem == "-")
            {
                sonuc = ilkSayi - Convert.ToDouble(textBox1.Text);
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }

            if (islem == "*")
            {
                sonuc = Convert.ToDouble(textBox1.Text) * ilkSayi;
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }

            if (islem == "/")
            {
                sonuc = ilkSayi / Convert.ToDouble(textBox1.Text);
                label1.Text = ilkSayi.ToString() + islem.ToString() + Convert.ToString(textBox1.Text);
                textBox1.Text = Convert.ToString(sonuc);
                ilkSayi = sonuc;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {

            }
            else
            {
                if (ekraniSil == true)
                {
                    textBox1.Text = "";
                    ekraniSil = false;
                }
                if (textBox1.Text == "0" && textBox1.Text != null)
                {

                }
                else
                {
                    textBox1.Text = textBox1.Text + ".";
                }
            }    
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (ekraniSil == true)
            {
                textBox1.Text = "";
                ekraniSil = false;
            }
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            ilkSayi = 0;
            islem = "";
            label1.Text = "";
            
            ekraniSil = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}