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
    public partial class Form_Publisher : Form
    {
        PublisherManager publisherManager = new PublisherManager();

        int _id = 0;
        public Form_Publisher()
        {
            InitializeComponent();
            dataGridView1.DataSource = publisherManager.GetAll();
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
                Publisher publisher = new Publisher();
                publisher.Name = textBox1.Text;

                publisherManager.Add(publisher);
                dataGridView1.DataSource = publisherManager.GetAll();
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Publisher editPublisher = publisherManager.GetById(_id);
            editPublisher.Name = textBox1.Text;
            publisherManager.Update(editPublisher);
            button2.Enabled = false;
            button3.Enabled = false;
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Publisher deletePublisher = publisherManager.GetById(_id);
            if (deletePublisher != null)
            {
                publisherManager.Delete(deletePublisher);
                dataGridView1.DataSource = publisherManager.GetAll();
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

                Publisher editPublisher = publisherManager.GetById(_id);

                textBox1.Text = editPublisher.Name;

                button2.Enabled = true;
                button3.Enabled = true;


            }
        }
    }
}
