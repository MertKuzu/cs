using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace öğrenciKayıtUygulaması
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
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayın.");
            }
            else
            {
                listBox1.Items.Add("Ad Soyad: " + textBox1.Text + ", Bölüm: " + comboBox1.Text + ", Adres: " + textBox2.Text + ", Şehir: " + textBox3.Text + ", Telefon Numarası: " + textBox4.Text + ", E-posta: " + textBox5.Text + ", Doğum Tarihi: " + dateTimePicker1.Text + ", Ülke: " + textBox6.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string s in listBox1.SelectedItems.OfType<string>().ToList())
                 listBox1.Items.Remove(s);
        }
    }
}
