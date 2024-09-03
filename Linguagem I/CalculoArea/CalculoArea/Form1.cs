namespace CalculoArea
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                if(listBox1.Text == "Quadrado" || listBox1.Text == "C�rculo")
                {
                    label3.Hide();
                    textBox2.Hide();
                    textBox2.Text = "0";
                } else
                {
                    label3.Show();
                    textBox2.Show();
                    textBox2.Text = string.Empty;
                }

                switch (listBox1.Text)
                {
                    case "Quadrado":
                        label2.Text = "Lado";
                        break;

                    case "Ret�ngulo":
                        label2.Text = "Base";
                        label3.Text = "Altura";
                        break;

                    case "C�rculo":
                        label2.Text = "Raio";
                        break;

                    case "Tri�ngulo":
                        label2.Text = "Base";
                        label3.Text = "Altura";
                        break;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                const double PI = Math.PI;

                double valorA = double.Parse(textBox1.Text);
                double valorB = double.Parse(textBox2.Text);

                switch (listBox1.Text)
                {
                    case "Quadrado":
                        MessageBox.Show(Math.Pow(valorB, 2).ToString());
                        break;
                    case "Ret�ngulo":
                        MessageBox.Show((valorA * valorB).ToString());
                        break;
                    case "C�rculo":
                        MessageBox.Show((PI * Math.Pow(valorA, 2)).ToString());
                        break;
                    case "Tri�ngulo":
                        MessageBox.Show(((valorA * valorB) / 2).ToString());
                        break;
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}