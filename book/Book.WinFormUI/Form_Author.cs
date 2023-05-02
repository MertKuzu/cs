using Book.Business.Concrete;
using Book.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book.WinFormUI
{
    public partial class Form_Author : Form
    {
        AuthorManager authorManager = new AuthorManager();

        int _id = 0;
        public Form_Author()
        {
            InitializeComponent();
            dataGridView1.DataSource = authorManager.GetAll();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;

            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Author author = new Author();
                author.Name = textBox1.Text;

                authorManager.Add(author);
                dataGridView1.DataSource = authorManager.GetAll();
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Author editAuthor = authorManager.GetById(_id);
            editAuthor.Name = textBox1.Text;
            authorManager.Update(editAuthor);
            button2.Enabled = false;
            button3.Enabled = false;
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Author deleteAuthor = authorManager.GetById(_id);
            if (deleteAuthor != null)
            {
                authorManager.Delete(deleteAuthor);
                dataGridView1.DataSource = authorManager.GetAll();
                button2.Enabled = false;
                button3.Enabled = false;
                textBox1.Text = "";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                _id = Int32.Parse(row.Cells[0].Value.ToString());

                Author editAuthor = authorManager.GetById(_id);

                textBox1.Text = editAuthor.Name;

                button2.Enabled = true;
                button3.Enabled = true;


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
