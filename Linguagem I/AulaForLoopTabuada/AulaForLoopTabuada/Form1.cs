namespace AulaForLoopTabuada
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
                int valor = int.Parse(textBox1.Text);

                listBox1.Items.Clear();

                for (int i = 1; i <= 10; i++)
                {
                    listBox1.Items.Add(valor.ToString() + "x" + i.ToString() + " = " + valor*i);
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
