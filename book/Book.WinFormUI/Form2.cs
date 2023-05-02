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
    public partial class Form2 : Form
    {
        CategoryManager categoryManager = new CategoryManager();

        int _id = 0;
        public Form2()
        {
            InitializeComponent();
            dataGridView1.DataSource = categoryManager.GetAll();
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
                Category category = new Category();
                category.Name = textBox1.Text;

                categoryManager.Add(category);
                dataGridView1.DataSource = categoryManager.GetAll();
                textBox1.Text = "";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                _id = Int32.Parse(row.Cells[0].Value.ToString());

                Category editCategory = categoryManager.GetById(_id);

                textBox1.Text=editCategory.Name;

                button2.Enabled = true;
                button3.Enabled = true;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category editCategory = categoryManager.GetById(_id);
            editCategory.Name = textBox1.Text;
            categoryManager.Update(editCategory);
            button2.Enabled=false;
            button3.Enabled=false;
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Category deleteCategory = categoryManager.GetById(_id);
            if (deleteCategory != null)
            {
                categoryManager.Delete(deleteCategory);
                dataGridView1.DataSource=categoryManager.GetAll();
                button2.Enabled = false;
                button3.Enabled = false;
                textBox1.Text = "";
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
