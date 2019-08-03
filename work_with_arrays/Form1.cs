using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work_with_arrays
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
            onedimensional_array form_one = new onedimensional_array();
            form_one.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            twodimensional_array form_two = new twodimensional_array();
            form_two.ShowDialog();
        }
    }
}
