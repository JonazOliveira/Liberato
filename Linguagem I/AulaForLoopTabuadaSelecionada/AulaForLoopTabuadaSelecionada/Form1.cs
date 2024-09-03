namespace AulaForLoopTabuadaSelecionada
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int valorInicial = int.Parse(textBox1.Text);
                int valorFinal = int.Parse(textBox2.Text);
                int multiplo = int.Parse(textBox3.Text);

                listBox1.Items.Clear();
                if (valorInicial > valorFinal)
                {
                    MessageBox.Show("O valor inicial não pode ser maior que o valor final!");
                } 
                else if (multiplo < 1 || multiplo > 9)
                {
                    MessageBox.Show("\"Valor\" invalido!");
                }
                else
                {
                    for (int i = valorInicial; i <= valorFinal; i++)
                    {
                        listBox1.Items.Add(multiplo + "x" + i + " = " + multiplo * i);
                    }
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("ERRO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
