using db_template.DAL;
using db_template.Entities;

namespace kitaplarım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AppDbContext _context = new AppDbContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Categories.ToList();

            comboBox2.DataSource = _context.Categories.ToList(); //veritabanından ilgili verileri çekmek için.
            comboBox2.DisplayMember = "CATEGORY"; //combobox nesnesinde görünen sütunun Name olmasını sağlamak için.
            comboBox2.ValueMember = "ID";

            dataGridView2.DataSource = _context.Books.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var category = new Categories();
            category.CATEGORY = textBox4.Text;

            _context.Categories.Add(category);
            _context.SaveChanges();
            dataGridView1.DataSource = _context.Categories.ToList();

            comboBox2.DataSource = _context.Categories.ToList(); //veritabanından ilgili verileri çekmek için.
            comboBox2.DisplayMember = "CATEGORY"; //combobox nesnesinde görünen sütunun Name olmasını sağlamak için.
            comboBox2.ValueMember = "ID";




        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            var book = new Books();
            book.NAME = textBox1.Text;
            book.ISBN = Convert.ToInt32(textBox2.Text);
            book.AUTHOR = textBox3.Text;
            book.CATEGORYID = comboBox2.SelectedIndex; 
            

            _context.Books.Add(book);
            _context.SaveChanges();

            dataGridView2.DataSource = _context.Categories.ToList();




        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}