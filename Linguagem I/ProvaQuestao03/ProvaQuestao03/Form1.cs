using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaQuestao03
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                Random random = new Random();

                int dias = int.Parse(textBox1.Text);
                int[] temperatura = new int[dias];

                double menor = 42;
                double maior = 0;
                double sum = 0;
                double media;


                for (int i = 0; i < temperatura.Length; i++)
                {
                    temperatura[i] = random.Next(0, 42);
                }

                for (int i = 0; i < temperatura.Length; i++)
                {
                    if (temperatura[i] < menor)
                    {
                        menor = temperatura[i];
                    }
                    if (temperatura[i] > maior)
                    {
                        maior = temperatura[i];
                    }
                    sum += temperatura[i];
                }

                for(int i = 0; i < temperatura.Length; i++)
                {
                    listBox1.Items.Add("Dia " + (i+1) + " ~ Temperatura " + temperatura[i]);
                }

                media = sum / dias;

                label4.Text = menor.ToString();
                label6.Text = maior.ToString();
                label8.Text = media.ToString();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
