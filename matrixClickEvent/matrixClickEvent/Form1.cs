namespace matrixClickEvent
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

                    buttons[i, j].Click += button_click;


                    this.Controls.Add(buttons[i, j]);
                    left += 100;

                   
                }
                left = 10;
                top += 100;

            }

        }

        private void button_click(object sender, EventArgs e)
        {
            if(sender is Button)
            {
                Button b = sender as Button;
                if(b.BackColor != Color.Red)
                {
                    b.BackColor = Color.Red;
                }
                else
                {
                    b.BackColor= Color.White;
                }

            }
            
        }
    }
}