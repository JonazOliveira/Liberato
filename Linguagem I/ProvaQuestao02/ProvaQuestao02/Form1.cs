using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaQuestao02
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idade = int.Parse(textBox1.Text);


                if (idade < 5)
                {
                    label3.Text = "Idade insuficiente";
                }
                else if (idade > 4 && idade < 8)
                {
                    label3.Text = "Infantil A";
                }
                else if (idade > 7 && idade < 12)
                {
                    label3.Text = "Infantil B";
                }
                else if (idade > 11 && idade < 14)
                {
                    label3.Text = "Juvenil A";
                }
                else if (idade > 13 && idade < 18)
                {
                    label3.Text = "Juvenil B";
                }
                else if (idade >= 18)
                {
                    label3.Text = "Adultos";
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
