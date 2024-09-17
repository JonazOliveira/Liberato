namespace AulaVetor02
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                Random random = new Random();

                int[] vetorA = new int[10];
                int[] vetorB = new int[10];

                for(int i = 0; i < vetorA.Length; i++)
                {
                    vetorA[i] = random.Next(1, 100);
                    vetorB[i] = random.Next(1, 100);
                }

                for(int i = 0, j = (vetorB.Length-1); i < vetorB.Length; i++, j--)
                {
                    listView1.Items.Add(vetorA[i].ToString());
                    listView2.Items.Add(vetorB[i].ToString());
                    listView3.Items.Add((vetorA[i] * vetorB[j]).ToString());
                }

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
