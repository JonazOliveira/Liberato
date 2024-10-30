using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisaoProva3
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();

                int size = 10;

                int[] vetorA = new int[size];
                int[] vetorB = new int[size];
                int[] vetorC = new int[size];

                for (int i = 0; i < size; i++)
                {
                    vetorA[i] = random.Next(-10, 10);
                    vetorB[i] = random.Next(-10, 10);
                }

                for (int i = 0, j = size-1; i < size; i++, j--)
                {
                    vetorC[i] = vetorA[i] * vetorB[j];
                }

                for (int i = 0; i < size ; i++)
                {
                    listBox1.Items.Add(vetorA[i]);
                    listBox2.Items.Add(vetorB[i]);
                    listBox3.Items.Add(vetorC[i]);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}
