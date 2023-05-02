using Book.Business.Concrete;
using Book.Entities.Concrete;

namespace Book.WinFormUI
{
    public partial class Form1 : Form
    {
        CategoryManager categoryManager = new CategoryManager();
        AuthorManager authorManager = new AuthorManager();  
        PublisherManager publisherManager = new PublisherManager();
        MyBookManager myBookManager = new MyBookManager();
        int _id = 0;
        public Form1()
        {
            InitializeComponent();
            comboBox2.DataSource = categoryManager.GetAll();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
            comboBox1.DataSource = authorManager.GetAll();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox3.DataSource = publisherManager.GetAll();
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "Id";

            dataGridView1.DataSource = myBookManager.GetAll();


            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                MyBook myBook = new MyBook();
                myBook.Name = textBox1.Text;
                myBook.ISBN = textBox2.Text;

                myBook.AuthorId = Int32.Parse(comboBox1.SelectedValue.ToString());
                myBook.CategoryId = Int32.Parse(comboBox2.SelectedValue.ToString());
                myBook.PublisherId = Int32.Parse(comboBox3.SelectedValue.ToString());

                myBook.IsDeleted = false;

                myBookManager.Add(myBook);
                dataGridView1.DataSource = myBookManager.GetAll();

                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); 
            form2.ShowDialog();
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox2.DataSource = categoryManager.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Author form_author = new Form_Author();
            form_author.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox1.DataSource = authorManager.GetAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Publisher form_publisher = new Form_Publisher();
            form_publisher.ShowDialog();
        }

        private void comboBox3_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox3.DataSource = publisherManager.GetAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyBook editMyBook = myBookManager.GetById(_id);
            editMyBook.Name = textBox1.Text;
            editMyBook.ISBN = textBox2.Text;

            editMyBook.AuthorId = Int32.Parse(comboBox1.SelectedValue.ToString());
            editMyBook.CategoryId = Int32.Parse(comboBox2.SelectedValue.ToString());
            editMyBook.PublisherId = Int32.Parse(comboBox3.SelectedValue.ToString());



            myBookManager.Update(editMyBook);
            textBox1.Text = "";
        }
    }
}