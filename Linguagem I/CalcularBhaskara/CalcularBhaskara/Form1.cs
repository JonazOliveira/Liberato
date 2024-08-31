using System.Diagnostics;

namespace CalcularBhaskara
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
            if (textBox1.Text == "0")
            {
                label5.Text = "Error! Not's zero!";
            }
            else
            {
                label5.Text = string.Empty;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                    double valorA = double.Parse(textBox1.Text);
                    double valorB = double.Parse(textBox2.Text);
                    double valorC = double.Parse(textBox3.Text);

                    if (valorA == 0)
                    {
                        MessageBox.Show("\"A\" not's zero!");
                    }
                    else
                    {
                        double delta = Math.Pow(valorB, 2) - (4 * valorA * valorC);

                        double bhaskaraPositiva = (-valorB + Math.Sqrt(delta)) / (2 * valorA);
                        double bhaskaraNegativa = (-valorB - Math.Sqrt(delta)) / (2 * valorA);

                        MessageBox.Show(bhaskaraPositiva.ToString() + " OU " + bhaskaraNegativa.ToString());

                    }
            } 
            catch (FormatException) 
            {
                MessageBox.Show("Only numbers are allowed");
            }
            catch (Exception ex)
            {
                if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
                {
                    MessageBox.Show("Fill in all values with numbers");
                } 
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
