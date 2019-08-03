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
    public partial class onedimensional_array : Form
    {
        private List<int> array = new List<int>();
        private Random number = new Random();

        public onedimensional_array()
        {
            InitializeComponent();
        }

        private void onedimensional_array_Load(object sender, EventArgs e)
        {
            
        }
        
        private void PRINT_ARRAY()
        {
            for (int i = 0; i < array.Count; i++)
            {
                richTextBox1.AppendText("array [" + i + "] = " + array.ElementAt(i).ToString() + "\n");
            }
        }

        private void Max(int maxElement)
        {
            foreach (int element in array)
            {
                if (maxElement < element)
                {
                    maxElement = element;
                }
            }

            textBox3.Text = Convert.ToString(maxElement);
        }

        private void Min(int minElement)
        {
            foreach (int element in array)
            {
                if (minElement > element)
                {
                    minElement = element;
                }
            }

            textBox4.Text = Convert.ToString(minElement);
        }

        private void AVG()
        {
            int sum = 0;

            for (int i = 0; i < array.Count(); i++)
            {
                sum += array.ElementAt(i);
            }

            double avg = (double)sum / array.Count();
            textBox5.Text = avg.ToString();
        }

        private void MEDIAN()
        {
            double median = 0.0;
            if (array.Count() % 2 == 0)
                median = (double)(array.ElementAt((array.Count() - 1)/2) + array.ElementAt((array.Count()) / 2))/2;
            else if (array.Count() % 2 == 1)
                median = (int)(array.ElementAt((array.Count()-1)/2));

            textBox6.Text = median.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            richTextBox1.Clear();
            array.Clear();
            int result;

            if (String.IsNullOrEmpty(textBox2.Text) || !Int32.TryParse(textBox2.Text, out result) || Convert.ToInt32(textBox2.Text) <= 0)
            {
                MessageBox.Show("Size is a number > 0 !");
                return;
            }

            int num;
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, (float)12, FontStyle.Bold);

            for (int i = 0; i < result;)
            {
                num = number.Next(0, result*result);

                if (!array.Contains(num))
                {
                    array.Add(num);
                    i++;

                }

            }

            PRINT_ARRAY();
            Max(array.ElementAt(0));
            Min(array.ElementAt(0));
            AVG();
            MEDIAN();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (array.Count == 0)
                return;

            richTextBox1.Clear();

            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count - 1; j++)
                {
                    if (array.ElementAt(j) > array.ElementAt(j + 1))
                    {
                        int z = array.ElementAt(j);
                        array[j] = array.ElementAt(j + 1);
                        array[j + 1] = z;
                    }
                }
            }

            PRINT_ARRAY();
            MEDIAN();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (array.Count == 0)
                return;

            richTextBox1.Clear();

            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count - 1; j++)
                {
                    if (array.ElementAt(j) < array.ElementAt(j + 1))
                    {
                        int z = array.ElementAt(j);
                        array[j] = array.ElementAt(j + 1);
                        array[j + 1] = z;
                    }
                }
            }

            PRINT_ARRAY();
            MEDIAN();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("ONLY NUMBERS!");
                return;
            }

            foreach (char i in richTextBox1.Text)
            {
                if (i < '0' || i > '9')
                    MessageBox.Show("ONLY NUMBERS!");
                return;
            }

            array.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, (float)12, FontStyle.Bold);

            var ints = richTextBox1.Text.Split(' ').Select(Int32.Parse).ToArray();
            for (int i = 0; i < ints.Length; i++)
            {
                array.Add(ints.ElementAt(i));
            }

            richTextBox1.Clear();

            PRINT_ARRAY();
            Max(array.ElementAt(0));
            Min(array.ElementAt(0));
            AVG();
            MEDIAN();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (array.Count == 0)
                return;

            for (int i = 0; i < array.Count; i++)
            {
                if (array.ElementAt(i) % 2 == 0)
                    array.RemoveAt(i);
            }

            richTextBox1.Clear();
            PRINT_ARRAY();
            Max(array.ElementAt(0));
            Min(array.ElementAt(0));
            AVG();
            MEDIAN();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (array.Count == 0)
                return;

            for (int i = 0; i < array.Count; i++)
            {
                if (array.ElementAt(i) % 2 == 1)
                    array.RemoveAt(i);
            }

            richTextBox1.Clear();
            PRINT_ARRAY();
            Max(array.ElementAt(0));
            Min(array.ElementAt(0));
            AVG();
            MEDIAN();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            int element;

            if (String.IsNullOrEmpty(textBox7.Text) || !Int32.TryParse(textBox7.Text, out element))
            {
                MessageBox.Show("NUMBER >= 0 !");
                return;
            }

            int index;

            if (String.IsNullOrEmpty(textBox8.Text) || !Int32.TryParse(textBox8.Text, out index))
            {
                MessageBox.Show("INDEX >= 0 !");
                return;
            }

            array.Insert(index,element);

            PRINT_ARRAY();
            Max(array.ElementAt(0));
            Min(array.ElementAt(0));
            AVG();
            MEDIAN();
        }
    }
}
