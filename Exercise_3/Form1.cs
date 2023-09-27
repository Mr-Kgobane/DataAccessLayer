using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Exercise_3
{
    public partial class Student : Form
    {
        DataHandler handler = new DataHandler();
        Class1 student = new Class1();
        public Student()
        {
            InitializeComponent();
        }

        private void REg_Click(object sender, EventArgs e)
        {
            student.stid = int.Parse(stID.Text);
            student.name = FN.Text;
            student.surname = LN.Text;
            student.cid = CID.Text;

            handler.register(student.stid, student.name, student.surname, student.cid);
        }

        private void search_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            s.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Delete d = new Delete();
            d.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void update_Click(object sender, EventArgs e)
        {
            student.stid = int.Parse(stID.Text);
            student.name = FN.Text;
            student.surname = LN.Text;
            student.cid = CID.Text;
            
            handler.update(student.stid, student.name, student.surname, student.cid);
        }
    }
}
