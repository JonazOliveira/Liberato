namespace AulaVetor01
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] vetor = new int[25];
                Random random = new Random();

                int inicial = int.Parse(textBox1.Text);
                int final = int.Parse(textBox2.Text);
                int multiplo = int.Parse(textBox3.Text);


                for (int i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = random.Next(inicial, final);
                }

                for (int i = 0; i < vetor.Length; i++)
                {
                    if (vetor[i] % multiplo == 0)
                    {
                        listView1.Items.Add(vetor[i].ToString());
                    }
                    else
                    {
                        listView2.Items.Add(vetor[i].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
