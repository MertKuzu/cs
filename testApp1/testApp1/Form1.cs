namespace testApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        int questionNo = 1, timeLimit = 60, correct = 0, wrong = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (questionNo == 1)
            {
                textBox1.Text = "T�rkiye'nin ba�kenti hangi �ehirdir?";
                button2.Text = "�stanbul";
                button3.Text = "Ankara";
                button4.Text = "Sakarya";
                button5.Text = "Bursa";
                button1.Text = "�leri";
                
            }

            if (questionNo == 2)
            {
                label1.Text = "Soru 2";
                textBox1.Text = "D�nyan�n uzun da�� hangisidir?";
                button2.Text = "A�r�";
                button3.Text = "Ilgaz";
                button4.Text = "Everest";
                button5.Text = "Uluda�";
                
            }

            if (questionNo == 3)
            {
                label1.Text = "Soru 3";
                textBox1.Text = "G�n�llerin �ampiyonu sigma erkek adam gibi adam F1 pilotu kimdir?";
                button2.Text = "Sergio Perez";
                button3.Text = "Max Verstappen";
                button4.Text = "Lewis Hamilton";
                button5.Text = "Charles Leclerc";
                
            }

            if (questionNo == 4)
            {
                label1.Text = "Soru 4";
                textBox1.Text = "T�rkiye'nin en kalabal�k �ehri hangisidir?";
                button2.Text = "�stanbul";
                button3.Text = "Ankara";
                button4.Text = "Sakarya";
                button5.Text = "Bursa";
                
            }

            if (questionNo == 5)
            {
                label1.Text = "Soru 5";
                textBox1.Text = "En uzun nehir hangisidir?";
                button2.Text = "K�z�l�rmak";
                button3.Text = "Nil";
                button4.Text = "F�rat";
                button5.Text = "Ganj";
                
            }

            if (questionNo > 5)
            {
                MessageBox.Show("S�nav bitmi�tir");
                timer1.Enabled = false;
            }

            questionNo += 1;
        }

        //if you click answer buttons this buttons are returning to a control varriable.
        private void button2_Click(object sender, EventArgs e)
        {
            if(questionNo == 4 && questionNo == 5)
            {
                correct += 1;
                label5.Text = Convert.ToString(correct);
            }
            else
            {
                wrong += 1;
                label6.Text = Convert.ToString(wrong);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(questionNo == 1 && questionNo == 6)
            {
                correct += 1;
                label5.Text = Convert.ToString(correct);
            }
            else
            {
                wrong += 1;
                label6.Text = Convert.ToString(wrong);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (questionNo == 3)
            {
                correct += 1;
                label5.Text = Convert.ToString(correct);
            }
            else
            {
                wrong += 1;
                label6.Text = Convert.ToString(wrong);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            wrong += 1;
            label6.Text = Convert.ToString(wrong);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLimit--;
            label2.Text = Convert.ToString(timeLimit);
            if (timeLimit == 0)
            {
                MessageBox.Show("S�re dolmu�tur.");
                timer1.Enabled = false;
            }
        }
    }
}