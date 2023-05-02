using StokTakip.DAL;
using StokTakip.Entities;

namespace StokTakip
{
    public partial class Form1 : Form
    {
        AppDbContext _context = new AppDbContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Urunler.ToList();

            comboBox1.DataSource = _context.Kategoriler.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var category = new Kategori();
            category.Name = textBox1.Text;

            _context.Kategoriler.Add(category);
            _context.SaveChanges();

            comboBox1.DataSource = _context.Kategoriler.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ýsim alanýný boþ býrakmayýn!");
            }
            else
            {
                var product = new Urun();
                product.Name = textBox2.Text;
                product.KategoriId = (int)comboBox1.SelectedValue;

                _context.Urunler.Add(product);
                _context.SaveChanges();

                dataGridView1.DataSource = _context.Urunler.ToList();
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {

            var search = from x in _context.Urunler select x;
            if (textBox3.Text != "")
            {
                dataGridView1.DataSource = search.Where(x => x.Name.Contains(textBox3.Text)).ToList();
            }

        }
    }
}
            
        