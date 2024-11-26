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

namespace ProvaFinal
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

        private void labelCidade01_Click(object sender, EventArgs e)
        {

        }

        private void labelPessoa01_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCidade01_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewPessoa01_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCidade01_Click(object sender, EventArgs e)
        {
            try
            {
                //faz a conexão sql
                SqlConnection cn = new SqlConnection();
                //seta a string de conexão
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\24100169\Desktop\Nova pasta\ProvaFinal\ProvaFinal\Database1.mdf;Integrated Security=True";
                //abre a conexão
                cn.Open();
                //Cria o comando sql
                SqlCommand cmd = new SqlCommand();
                //string com sql
                string sqlQuery = "SELECT IDCIDADE, NOMECIDADE FROM CIDADE ORDER BY NOMECIDADE;";
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
                comboBoxCidade01.DataSource = dt;
                //Seta combobox com o valor
                comboBoxCidade01.ValueMember = "IDCIDADE";
                //seta combobox com descrição
                comboBoxCidade01.DisplayMember = "NOMECIDADE";
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPessoa01_Click(object sender, EventArgs e)
        {
            //popula grid view
            try
            {
                // caminho da conexão na properiedade do banco de dados -- connection string
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\24100169\Desktop\Nova pasta\ProvaFinal\ProvaFinal\Database1.mdf;Integrated Security=True");

                // comando
                SqlCommand comm = new SqlCommand();

                // chama  a conexão
                comm.Connection = conn;

                // abre a conexao
                conn.Open();
                //MessageBox.Show("teste " + comboBox2.SelectedValue);

                {
                    using (SqlDataAdapter a = new SqlDataAdapter(
                           "SELECT NOME, IDADE FROM PESSOA WHERE IDCIDADE = " + comboBoxCidade01.SelectedValue.ToString() + ";", conn)
                           )
                    {

                        DataTable t = new DataTable();
                        a.Fill(t);
                        // Render data onto the screen
                        dataGridViewPessoa01.DataSource = t;
                    }
                }
                // fecha conexao
                conn.Close();
            }
            catch (Exception ex)
            {
                // Show(Ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void labelCidade02_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCidade02_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCidade02_Click(object sender, EventArgs e)
        {
            try
            {
                //faz a conexão sql
                SqlConnection cn = new SqlConnection();
                //seta a string de conexão
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\24100169\Desktop\Nova pasta\ProvaFinal\ProvaFinal\Database1.mdf;Integrated Security=True";
                //abre a conexão
                cn.Open();
                //Cria o comando sql
                SqlCommand cmd = new SqlCommand();
                //string com sql
                string sqlQuery = "SELECT IDCIDADE, NOMECIDADE FROM CIDADE ORDER BY NOMECIDADE;";
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
                comboBoxCidade02.DataSource = dt;
                //Seta combobox com o valor
                comboBoxCidade02.ValueMember = "IDCIDADE";
                //seta combobox com descrição
                comboBoxCidade02.DisplayMember = "NOMECIDADE";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelEstadoCivil01_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEstadoCivil01_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEstadoCivil01_Click(object sender, EventArgs e)
        {
            try
            {
                //faz a conexão sql
                SqlConnection cn = new SqlConnection();
                //seta a string de conexão
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\24100169\Desktop\Nova pasta\ProvaFinal\ProvaFinal\Database1.mdf;Integrated Security=True";
                //abre a conexão
                cn.Open();
                //Cria o comando sql
                SqlCommand cmd = new SqlCommand();
                //string com sql
                string sqlQuery = "SELECT IDESTADOC, DESCRICAO FROM ESTADOCIVIL ORDER BY DESCRICAO;";
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
                comboBoxEstadoCivil01.DataSource = dt;
                //Seta combobox com o valor
                comboBoxEstadoCivil01.ValueMember = "IDESTADOC";
                //seta combobox com descrição
                comboBoxEstadoCivil01.DisplayMember = "DESCRICAO";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelPessoa02_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewPessoa02_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonPessoa02_Click(object sender, EventArgs e)
        {
            //popula grid view
            try
            {
                // caminho da conexão na properiedade do banco de dados -- connection string
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\24100169\Desktop\Nova pasta\ProvaFinal\ProvaFinal\Database1.mdf;Integrated Security=True");

                // comando
                SqlCommand comm = new SqlCommand();

                // chama  a conexão
                comm.Connection = conn;

                // abre a conexao
                conn.Open();
                //MessageBox.Show("teste " + comboBox2.SelectedValue);

                {
                    using (SqlDataAdapter a = new SqlDataAdapter(
                           "SELECT PESSOA.NOME, PESSOA.IDADE, CIDADE.NOMECIDADE, ESTADOCIVIL.DESCRICAO FROM PESSOA INNER JOIN CIDADE ON PESSOA.IDCIDADE = CIDADE.IDCIDADE INNER JOIN ESTADOCIVIL ON PESSOA.IDESTADOC = ESTADOCIVIL.IDESTADOC WHERE PESSOA.IDCIDADE = " + comboBoxCidade02.SelectedValue.ToString() + "AND PESSOA.IDESTADOC = " + comboBoxEstadoCivil01.SelectedValue.ToString() + ";", conn)
                           )
                    {

                        DataTable t = new DataTable();
                        a.Fill(t);
                        // Render data onto the screen
                        dataGridViewPessoa02.DataSource = t;
                    }
                }
                // fecha conexao
                conn.Close();
            }
            catch (Exception ex)
            {
                // Show(Ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
