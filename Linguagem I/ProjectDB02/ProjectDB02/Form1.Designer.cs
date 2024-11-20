namespace ProjectDB02
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
            this.comboBoxPessoa = new System.Windows.Forms.ComboBox();
            this.dataGridViewCartaoC = new System.Windows.Forms.DataGridView();
            this.buttonPessoa = new System.Windows.Forms.Button();
            this.buttonCartaoC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartaoC)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPessoa
            // 
            this.comboBoxPessoa.FormattingEnabled = true;
            this.comboBoxPessoa.Location = new System.Drawing.Point(12, 12);
            this.comboBoxPessoa.Name = "comboBoxPessoa";
            this.comboBoxPessoa.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPessoa.TabIndex = 0;
            this.comboBoxPessoa.SelectedIndexChanged += new System.EventHandler(this.comboBoxPessoa_SelectedIndexChanged);
            // 
            // dataGridViewCartaoC
            // 
            this.dataGridViewCartaoC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCartaoC.Location = new System.Drawing.Point(22, 98);
            this.dataGridViewCartaoC.Name = "dataGridViewCartaoC";
            this.dataGridViewCartaoC.Size = new System.Drawing.Size(444, 150);
            this.dataGridViewCartaoC.TabIndex = 1;
            this.dataGridViewCartaoC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCartaoC_CellContentClick);
            // 
            // buttonPessoa
            // 
            this.buttonPessoa.Location = new System.Drawing.Point(170, 12);
            this.buttonPessoa.Name = "buttonPessoa";
            this.buttonPessoa.Size = new System.Drawing.Size(75, 23);
            this.buttonPessoa.TabIndex = 2;
            this.buttonPessoa.Text = "EXE";
            this.buttonPessoa.UseVisualStyleBackColor = true;
            this.buttonPessoa.Click += new System.EventHandler(this.buttonPessoa_Click);
            // 
            // buttonCartaoC
            // 
            this.buttonCartaoC.Location = new System.Drawing.Point(485, 165);
            this.buttonCartaoC.Name = "buttonCartaoC";
            this.buttonCartaoC.Size = new System.Drawing.Size(75, 23);
            this.buttonCartaoC.TabIndex = 3;
            this.buttonCartaoC.Text = "EXE";
            this.buttonCartaoC.UseVisualStyleBackColor = true;
            this.buttonCartaoC.Click += new System.EventHandler(this.buttonCartaoC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCartaoC);
            this.Controls.Add(this.buttonPessoa);
            this.Controls.Add(this.dataGridViewCartaoC);
            this.Controls.Add(this.comboBoxPessoa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCartaoC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPessoa;
        private System.Windows.Forms.DataGridView dataGridViewCartaoC;
        private System.Windows.Forms.Button buttonPessoa;
        private System.Windows.Forms.Button buttonCartaoC;
    }
}

