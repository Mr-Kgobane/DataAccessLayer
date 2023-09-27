using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_3
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Class1 student = new Class1();
            student.stid = int.Parse(btnsearch.Text);

            DataHandler dataHandler = new DataHandler();
            dataGridView1.DataSource= dataHandler.Search(student.stid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
