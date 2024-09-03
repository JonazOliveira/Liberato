namespace AulaForLoop2
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
                int valorInicial = int.Parse(textBox1.Text);
                int valorFinal = int.Parse(textBox2.Text);

                if (valorInicial > valorFinal)
                {
                    MessageBox.Show("O valor inicial não pode ser maior que o valor final!");
                }

                for (int i = valorInicial; i <= valorFinal; i++)
                {
                    listBox1.Items.Add(i.ToString());
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Apenas números são permitidos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
