using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaQuestao01
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = double.Parse(textBox1.Text);
                int indexListBox1 = listBox1.SelectedIndex;
                int indexListBox2 = listBox2.SelectedIndex;

                if (indexListBox1 == indexListBox2)
                {
                    label4.Text = valor.ToString();
                }
                else
                {
                    while (indexListBox1 != indexListBox2)
                    {
                        if (indexListBox1 < indexListBox2)
                        {
                            valor *= 10;
                            indexListBox1++;
                        }
                        if (indexListBox1 > indexListBox2)
                        {
                            valor /= 10;
                            indexListBox2++;
                        }
                    }
                    label4.Text = valor.ToString();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
