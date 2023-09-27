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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            Class1 student = new Class1();
            student.stid = int.Parse(btndel.Text);

            DataHandler dataHandler = new DataHandler();
            dataHandler.Delete(student.stid);
        }

        private void btnex_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
