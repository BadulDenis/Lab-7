using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаб_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Mas = new int[20];

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                listBox1.Items.Add("Mas[" + i.ToString() +
     "] = " + Mas[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int max = 0, j = -1;
            listBox2.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                if (Mas[i] > max)
                {
                    max = Mas[i];
                    j = i;
                }
            }

            Mas[j] = Mas[0];
            Mas[0] = max;

            for (int i = 0; i < 20; i++)
            {
                listBox2.Items.Add("Mas[" + Convert.ToString(i)
                + "] = " + Mas[i].ToString());
            }
        }

    }
}

