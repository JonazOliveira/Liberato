namespace AulaDB2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.database1DataSet = new AulaDB2.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deptoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deptoTableAdapter = new AulaDB2.Database1DataSetTableAdapters.DeptoTableAdapter();
            this.deptoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new AulaDB2.Database1DataSet1();
            this.deptoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.deptoTableAdapter1 = new AulaDB2.Database1DataSet1TableAdapters.DeptoTableAdapter();
            this.database1DataSet2 = new AulaDB2.Database1DataSet2();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaTableAdapter = new AulaDB2.Database1DataSet2TableAdapters.EmpresaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDeptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.database1DataSet3 = new AulaDB2.Database1DataSet3();
            this.empresaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empresaTableAdapter1 = new AulaDB2.Database1DataSet3TableAdapters.EmpresaTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.deptoBindingSource;
            this.comboBox1.DisplayMember = "descricao";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(395, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "IdDepto";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // deptoBindingSource
            // 
            this.deptoBindingSource.DataMember = "Depto";
            this.deptoBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // deptoTableAdapter
            // 
            this.deptoTableAdapter.ClearBeforeFill = true;
            // 
            // deptoBindingSource1
            // 
            this.deptoBindingSource1.DataMember = "Depto";
            this.deptoBindingSource1.DataSource = this.database1DataSetBindingSource;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deptoBindingSource2
            // 
            this.deptoBindingSource2.DataMember = "Depto";
            this.deptoBindingSource2.DataSource = this.database1DataSet1;
            // 
            // deptoTableAdapter1
            // 
            this.deptoTableAdapter1.ClearBeforeFill = true;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "Empresa";
            this.empresaBindingSource.DataSource = this.database1DataSet2;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDeptoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.idEmpresaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deptoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(395, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 205);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDeptoDataGridViewTextBoxColumn
            // 
            this.idDeptoDataGridViewTextBoxColumn.DataPropertyName = "IdDepto";
            this.idDeptoDataGridViewTextBoxColumn.HeaderText = "IdDepto";
            this.idDeptoDataGridViewTextBoxColumn.Name = "idDeptoDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // idEmpresaDataGridViewTextBoxColumn
            // 
            this.idEmpresaDataGridViewTextBoxColumn.DataPropertyName = "IdEmpresa";
            this.idEmpresaDataGridViewTextBoxColumn.HeaderText = "IdEmpresa";
            this.idEmpresaDataGridViewTextBoxColumn.Name = "idEmpresaDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.RazaoSocial});
            this.dataGridView2.DataSource = this.empresaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(57, 72);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(243, 205);
            this.dataGridView2.TabIndex = 2;
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresaBindingSource1
            // 
            this.empresaBindingSource1.DataMember = "Empresa";
            this.empresaBindingSource1.DataSource = this.database1DataSet3;
            // 
            // empresaTableAdapter1
            // 
            this.empresaTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.empresaBindingSource;
            this.comboBox2.DisplayMember = "RazaoSocial";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(57, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "IdEmpresa";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdEmpresa";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdEmpresa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // RazaoSocial
            // 
            this.RazaoSocial.DataPropertyName = "RazaoSocial";
            this.RazaoSocial.HeaderText = "RazaoSocial";
            this.RazaoSocial.Name = "RazaoSocial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource deptoBindingSource;
        private Database1DataSetTableAdapters.DeptoTableAdapter deptoTableAdapter;
        private System.Windows.Forms.BindingSource deptoBindingSource1;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource deptoBindingSource2;
        private Database1DataSet1TableAdapters.DeptoTableAdapter deptoTableAdapter1;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private Database1DataSet2TableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDeptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource empresaBindingSource1;
        private Database1DataSet3TableAdapters.EmpresaTableAdapter empresaTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazaoSocial;
    }
}

