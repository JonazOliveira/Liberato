using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisaoProva
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double valorBruto = double.Parse(textBox1.Text);

                if (valorBruto < 24511.93)
                {
                    MessageBox.Show(valorBruto.ToString());
                } else if (valorBruto < 33919.81)
                {
                    MessageBox.Show((valorBruto - (valorBruto * (7.5 / 100))).ToString());
                } else if (valorBruto < 45012.61)
                {
                    MessageBox.Show((valorBruto - (valorBruto * (15 / 100))).ToString());
                } else if (valorBruto < 55976.17)
                {
                    MessageBox.Show((valorBruto - (valorBruto * (22.5 / 100))).ToString());
                } else
                {
                    MessageBox.Show((valorBruto - (valorBruto * (27.5 / 100))).ToString());
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
