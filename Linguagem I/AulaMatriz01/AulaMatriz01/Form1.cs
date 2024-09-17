namespace AulaMatriz01
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

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                Random random = new Random();
                int[,] matriz = new int[5,5];

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    matriz[i, i] = random.Next(1, 100);
                }
                for (int i = 0;i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++) 
                    {
                        listBox1.Items.Add(matriz[i, j]);
                    }
                }
            } catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }
    }
}
