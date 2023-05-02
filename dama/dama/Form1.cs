namespace dama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int en = Int32.Parse(textBox1.Text);
            int boy = Int32.Parse(textBox2.Text);
            Dama(en, boy);
            
        }

        public void Dama(int en, int boy)
        {
            int left = 10;
            int top = 100;

            Button[,] buttons = new Button[en, boy];

            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(0); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 100;
                    buttons[i, j].Height = 100;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    buttons[i, j].Text = i.ToString() + "," + j.ToString();


                    this.Controls.Add(buttons[i, j]);
                    left += 100;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i,j].BackColor = Color.Red;
                    }
                    else
                    {
                        buttons[i,j].BackColor = Color.Green;
                    }
                }
                left = 10;
                top += 100;

            }

            
            
        }
    }
}