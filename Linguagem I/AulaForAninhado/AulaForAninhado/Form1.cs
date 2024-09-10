namespace AulaForAninhado
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();
                if (listBox1.GetSelected(0))
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        listView1.Items.Add("TABUADA DO " + i);
                        for (int j = 1; j <= 10; j++)
                        {
                            listView1.Items.Add(i.ToString() + "x" + j + " = " + i * j);
                        }
                    }
                }
                else
                {
                    int numTabuada = int.Parse(listBox1.Text.ToString());
                    listView1.Items.Add("TABUADA DO " + numTabuada.ToString());
                    for (int i = 1; i <= 10; i++)
                    {
                        listView1.Items.Add(numTabuada.ToString() + "x" + i + " = " + numTabuada * i);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
