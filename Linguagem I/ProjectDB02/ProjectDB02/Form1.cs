using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDB02
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

        private void buttonPessoa_Click(object sender, EventArgs e)
        {
            try
            {
                //faz a conexão sql
                SqlConnection cn = new SqlConnection();
                //seta a string de conexão
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\24100169\Desktop\Nova pasta\ProjectDB02\ProjectDB02\Database1.mdf;Integrated Security=True";
                //abre a conexão
                cn.Open();
                //Cria o comando sql
                SqlCommand cmd = new SqlCommand();
                //string com sql
                string sqlQuery = "select Id, nome from pessoa order by nome";
                //passa a query para o comando e abre a conexão
                cmd = new SqlCommand(sqlQuery, cn);
                //cria o Sql Data Adapter
                SqlDataAdapter dAdapter = new SqlDataAdapter();
                //cria Data Table
                DataTable dt = new DataTable();
                //Incializa SQL Data Adapter Command Property
                dAdapter.SelectCommand = cmd;
                //Preenche Data Table
                dAdapter.Fill(dt);
                //Popula Combo Box com os dados do Data Table
                comboBoxPessoa.DataSource = dt;
                //Seta combobox com o valor
                comboBoxPessoa.ValueMember = "Id";
                //seta combobox com descrição
                comboBoxPessoa.DisplayMember = "nome";
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCartaoC_Click(object sender, EventArgs e)
        {
            try
            {
                // caminho da conexão na properiedade do banco de dados -- connection string
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\24100169\Desktop\Nova pasta\ProjectDB02\ProjectDB02\Database1.mdf;Integrated Security=True");

                // comando
                SqlCommand comm = new SqlCommand();

                // chama  a conexão
                comm.Connection = conn;

                // abre a conexao
                conn.Open();
                //MessageBox.Show("teste " + comboBox2.SelectedValue);

                {
                    using (SqlDataAdapter a = new SqlDataAdapter(
                           "SELECT * FROM CartaoC WHERE CARTAOC.IDPESSOA = " + comboBoxPessoa.SelectedValue, conn)
                           )
                    {

                        DataTable t = new DataTable();
                        a.Fill(t);
                        // Render data onto the screen
                        dataGridViewCartaoC.DataSource = t;
                    }
                }
                // fecha conexao
                conn.Close();
            }
            catch (Exception Ex)
            {
                // Show(Ex.Message);
                MessageBox.Show(Ex.Message);
            }
        }

        private void comboBoxPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewCartaoC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
