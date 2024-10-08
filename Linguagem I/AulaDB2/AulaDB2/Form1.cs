using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaDB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet3.Empresa'. Você pode movê-la ou removê-la conforme necessário.
            this.empresaTableAdapter1.Fill(this.database1DataSet3.Empresa);
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet2.Empresa'. Você pode movê-la ou removê-la conforme necessário.
            this.empresaTableAdapter.Fill(this.database1DataSet2.Empresa);
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet1.Depto'. Você pode movê-la ou removê-la conforme necessário.
            this.deptoTableAdapter1.Fill(this.database1DataSet1.Depto);
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Depto'. Você pode movê-la ou removê-la conforme necessário.
            this.deptoTableAdapter.Fill(this.database1DataSet.Depto);

        }
    }
}
