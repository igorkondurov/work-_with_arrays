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
    public partial class twodimensional_array : Form
    {
        private List<List<int>> list = new List<List<int>>();
        private int count_row, count_column;

        public twodimensional_array()
        {
            InitializeComponent();
        }

        private void PRINT()
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, (float)10, FontStyle.Bold);

            string str;
            for (int i = 0; i < count_row; i++)
            {
                str = "";
                for (int j = 0; j < count_column; j++)
                {
                    str += list[i][j] + " ";
                }

                str += "\n";
                richTextBox1.AppendText(str);
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            int k = 0;

            for (int i = 0; i < count_row / 2; i++)
                for (int j = 0; j < count_column; j++)
                {
                    k = list[i][j];
                    list[i][j] = list[count_row - i - 1][j];
                    list[count_row - i - 1][j] = k;
                }

            PRINT();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            int k = 0;

            for (int i = 0; i < count_row; i++)
                for (int j = 0; j < count_column / 2; j++)
                {
                    k = list[i][j];
                    list[i][j] = list[i][count_column - j - 1];
                    list[i][count_column - j - 1] = k;
                }

            PRINT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();  

            if (String.IsNullOrEmpty(textBox1.Text) || !Int32.TryParse(textBox1.Text, out count_row) || Convert.ToInt32(textBox1.Text) <= 0)
            {
                MessageBox.Show("Size is a number > 0 !");
                return;
            }

            if (String.IsNullOrEmpty(textBox2.Text) || !Int32.TryParse(textBox2.Text, out count_column) || Convert.ToInt32(textBox2.Text) <= 0)
            {
                MessageBox.Show("Size is a number > 0 !");
                return;
            }

            bool ThereIs;
            int newRandomNumber;
            var rnd = new Random();
            for (int i = 0; i < count_row; i++)
            {
                list.Add(new List<int>());
                for (int j = 0; j < count_column;)
                {
                    ThereIs = false;
                    newRandomNumber = rnd.Next(1, count_column + 1);

                    for (int k = 0; k < j; k++)
                    {
                        if (list[i][k] == newRandomNumber)
                        {
                            ThereIs = true;
                            break;
                        }
                    }

                    if (!ThereIs)
                    {
                        list[i].Add(newRandomNumber);
                        j++;
                    }


                }

            }

            PRINT();
        }
    }
}
