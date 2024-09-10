namespace AulaVetor
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                Random valorRandom = new Random();

                int[] vetor = new int[100];

                for(int i = 0; i < vetor.Length; i++) { 
                    vetor[i] = valorRandom.Next(1, 80);
                    listView1.Items.Add("Posição " + i + " = " + vetor[i]);
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
