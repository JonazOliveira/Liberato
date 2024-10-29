using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisaoProva2
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int size = 20;
                int[] fibo;

                fibo = new int[size];
                fibo[1] = 1;

                for (int i = 0, j = 1, k = 2; k < fibo.Length; i++, j++, k++)
                {
                    fibo[k] = fibo[i] + fibo[j];
                }

                for(int i = 0; i < size; i++)
                {
                    if (fibo[i] % 2 != 0 && fibo[i] <= 100)
                    {
                        listView1.Items.Add(fibo[i].ToString());
                    }
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
