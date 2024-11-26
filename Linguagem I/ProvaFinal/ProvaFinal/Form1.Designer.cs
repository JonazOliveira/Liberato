namespace ProvaFinal
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
            this.labelCidade01 = new System.Windows.Forms.Label();
            this.labelPessoa01 = new System.Windows.Forms.Label();
            this.comboBoxCidade01 = new System.Windows.Forms.ComboBox();
            this.dataGridViewPessoa01 = new System.Windows.Forms.DataGridView();
            this.buttonCidade01 = new System.Windows.Forms.Button();
            this.buttonPessoa01 = new System.Windows.Forms.Button();
            this.buttonPessoa02 = new System.Windows.Forms.Button();
            this.buttonCidade02 = new System.Windows.Forms.Button();
            this.dataGridViewPessoa02 = new System.Windows.Forms.DataGridView();
            this.comboBoxCidade02 = new System.Windows.Forms.ComboBox();
            this.labelPessoa02 = new System.Windows.Forms.Label();
            this.labelCidade02 = new System.Windows.Forms.Label();
            this.buttonEstadoCivil01 = new System.Windows.Forms.Button();
            this.comboBoxEstadoCivil01 = new System.Windows.Forms.ComboBox();
            this.labelEstadoCivil01 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoa01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoa02)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCidade01
            // 
            this.labelCidade01.AutoSize = true;
            this.labelCidade01.Location = new System.Drawing.Point(22, 39);
            this.labelCidade01.Name = "labelCidade01";
            this.labelCidade01.Size = new System.Drawing.Size(40, 13);
            this.labelCidade01.TabIndex = 0;
            this.labelCidade01.Text = "Cidade";
            this.labelCidade01.Click += new System.EventHandler(this.labelCidade01_Click);
            // 
            // labelPessoa01
            // 
            this.labelPessoa01.AutoSize = true;
            this.labelPessoa01.Location = new System.Drawing.Point(22, 105);
            this.labelPessoa01.Name = "labelPessoa01";
            this.labelPessoa01.Size = new System.Drawing.Size(42, 13);
            this.labelPessoa01.TabIndex = 1;
            this.labelPessoa01.Text = "Pessoa";
            this.labelPessoa01.Click += new System.EventHandler(this.labelPessoa01_Click);
            // 
            // comboBoxCidade01
            // 
            this.comboBoxCidade01.FormattingEnabled = true;
            this.comboBoxCidade01.Location = new System.Drawing.Point(90, 39);
            this.comboBoxCidade01.Name = "comboBoxCidade01";
            this.comboBoxCidade01.Size = new System.Drawing.Size(260, 21);
            this.comboBoxCidade01.TabIndex = 2;
            this.comboBoxCidade01.SelectedIndexChanged += new System.EventHandler(this.comboBoxCidade01_SelectedIndexChanged);
            // 
            // dataGridViewPessoa01
            // 
            this.dataGridViewPessoa01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPessoa01.Location = new System.Drawing.Point(90, 105);
            this.dataGridViewPessoa01.Name = "dataGridViewPessoa01";
            this.dataGridViewPessoa01.Size = new System.Drawing.Size(260, 150);
            this.dataGridViewPessoa01.TabIndex = 3;
            this.dataGridViewPessoa01.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPessoa01_CellContentClick);
            // 
            // buttonCidade01
            // 
            this.buttonCidade01.Location = new System.Drawing.Point(368, 39);
            this.buttonCidade01.Name = "buttonCidade01";
            this.buttonCidade01.Size = new System.Drawing.Size(75, 23);
            this.buttonCidade01.TabIndex = 4;
            this.buttonCidade01.Text = "EXE";
            this.buttonCidade01.UseVisualStyleBackColor = true;
            this.buttonCidade01.Click += new System.EventHandler(this.buttonCidade01_Click);
            // 
            // buttonPessoa01
            // 
            this.buttonPessoa01.Location = new System.Drawing.Point(368, 105);
            this.buttonPessoa01.Name = "buttonPessoa01";
            this.buttonPessoa01.Size = new System.Drawing.Size(75, 23);
            this.buttonPessoa01.TabIndex = 5;
            this.buttonPessoa01.Text = "EXE";
            this.buttonPessoa01.UseVisualStyleBackColor = true;
            this.buttonPessoa01.Click += new System.EventHandler(this.buttonPessoa01_Click);
            // 
            // buttonPessoa02
            // 
            this.buttonPessoa02.Location = new System.Drawing.Point(609, 422);
            this.buttonPessoa02.Name = "buttonPessoa02";
            this.buttonPessoa02.Size = new System.Drawing.Size(75, 23);
            this.buttonPessoa02.TabIndex = 11;
            this.buttonPessoa02.Text = "EXE";
            this.buttonPessoa02.UseVisualStyleBackColor = true;
            this.buttonPessoa02.Click += new System.EventHandler(this.buttonPessoa02_Click);
            // 
            // buttonCidade02
            // 
            this.buttonCidade02.Location = new System.Drawing.Point(609, 322);
            this.buttonCidade02.Name = "buttonCidade02";
            this.buttonCidade02.Size = new System.Drawing.Size(75, 23);
            this.buttonCidade02.TabIndex = 10;
            this.buttonCidade02.Text = "EXE";
            this.buttonCidade02.UseVisualStyleBackColor = true;
            this.buttonCidade02.Click += new System.EventHandler(this.buttonCidade02_Click);
            // 
            // dataGridViewPessoa02
            // 
            this.dataGridViewPessoa02.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPessoa02.Location = new System.Drawing.Point(90, 422);
            this.dataGridViewPessoa02.Name = "dataGridViewPessoa02";
            this.dataGridViewPessoa02.Size = new System.Drawing.Size(494, 150);
            this.dataGridViewPessoa02.TabIndex = 9;
            this.dataGridViewPessoa02.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPessoa02_CellContentClick);
            // 
            // comboBoxCidade02
            // 
            this.comboBoxCidade02.FormattingEnabled = true;
            this.comboBoxCidade02.Location = new System.Drawing.Point(90, 322);
            this.comboBoxCidade02.Name = "comboBoxCidade02";
            this.comboBoxCidade02.Size = new System.Drawing.Size(494, 21);
            this.comboBoxCidade02.TabIndex = 8;
            this.comboBoxCidade02.SelectedIndexChanged += new System.EventHandler(this.comboBoxCidade02_SelectedIndexChanged);
            // 
            // labelPessoa02
            // 
            this.labelPessoa02.AutoSize = true;
            this.labelPessoa02.Location = new System.Drawing.Point(16, 422);
            this.labelPessoa02.Name = "labelPessoa02";
            this.labelPessoa02.Size = new System.Drawing.Size(42, 13);
            this.labelPessoa02.TabIndex = 7;
            this.labelPessoa02.Text = "Pessoa";
            this.labelPessoa02.Click += new System.EventHandler(this.labelPessoa02_Click);
            // 
            // labelCidade02
            // 
            this.labelCidade02.AutoSize = true;
            this.labelCidade02.Location = new System.Drawing.Point(16, 322);
            this.labelCidade02.Name = "labelCidade02";
            this.labelCidade02.Size = new System.Drawing.Size(40, 13);
            this.labelCidade02.TabIndex = 6;
            this.labelCidade02.Text = "Cidade";
            this.labelCidade02.Click += new System.EventHandler(this.labelCidade02_Click);
            // 
            // buttonEstadoCivil01
            // 
            this.buttonEstadoCivil01.Location = new System.Drawing.Point(609, 366);
            this.buttonEstadoCivil01.Name = "buttonEstadoCivil01";
            this.buttonEstadoCivil01.Size = new System.Drawing.Size(75, 23);
            this.buttonEstadoCivil01.TabIndex = 14;
            this.buttonEstadoCivil01.Text = "EXE";
            this.buttonEstadoCivil01.UseVisualStyleBackColor = true;
            this.buttonEstadoCivil01.Click += new System.EventHandler(this.buttonEstadoCivil01_Click);
            // 
            // comboBoxEstadoCivil01
            // 
            this.comboBoxEstadoCivil01.FormattingEnabled = true;
            this.comboBoxEstadoCivil01.Location = new System.Drawing.Point(90, 366);
            this.comboBoxEstadoCivil01.Name = "comboBoxEstadoCivil01";
            this.comboBoxEstadoCivil01.Size = new System.Drawing.Size(494, 21);
            this.comboBoxEstadoCivil01.TabIndex = 13;
            this.comboBoxEstadoCivil01.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstadoCivil01_SelectedIndexChanged);
            // 
            // labelEstadoCivil01
            // 
            this.labelEstadoCivil01.AutoSize = true;
            this.labelEstadoCivil01.Location = new System.Drawing.Point(16, 369);
            this.labelEstadoCivil01.Name = "labelEstadoCivil01";
            this.labelEstadoCivil01.Size = new System.Drawing.Size(62, 13);
            this.labelEstadoCivil01.TabIndex = 12;
            this.labelEstadoCivil01.Text = "Estado Civil";
            this.labelEstadoCivil01.Click += new System.EventHandler(this.labelEstadoCivil01_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 617);
            this.Controls.Add(this.buttonEstadoCivil01);
            this.Controls.Add(this.comboBoxEstadoCivil01);
            this.Controls.Add(this.labelEstadoCivil01);
            this.Controls.Add(this.buttonPessoa02);
            this.Controls.Add(this.buttonCidade02);
            this.Controls.Add(this.dataGridViewPessoa02);
            this.Controls.Add(this.comboBoxCidade02);
            this.Controls.Add(this.labelPessoa02);
            this.Controls.Add(this.labelCidade02);
            this.Controls.Add(this.buttonPessoa01);
            this.Controls.Add(this.buttonCidade01);
            this.Controls.Add(this.dataGridViewPessoa01);
            this.Controls.Add(this.comboBoxCidade01);
            this.Controls.Add(this.labelPessoa01);
            this.Controls.Add(this.labelCidade01);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoa01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoa02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCidade01;
        private System.Windows.Forms.Label labelPessoa01;
        private System.Windows.Forms.ComboBox comboBoxCidade01;
        private System.Windows.Forms.DataGridView dataGridViewPessoa01;
        private System.Windows.Forms.Button buttonCidade01;
        private System.Windows.Forms.Button buttonPessoa01;
        private System.Windows.Forms.Button buttonPessoa02;
        private System.Windows.Forms.Button buttonCidade02;
        private System.Windows.Forms.DataGridView dataGridViewPessoa02;
        private System.Windows.Forms.ComboBox comboBoxCidade02;
        private System.Windows.Forms.Label labelPessoa02;
        private System.Windows.Forms.Label labelCidade02;
        private System.Windows.Forms.Button buttonEstadoCivil01;
        private System.Windows.Forms.ComboBox comboBoxEstadoCivil01;
        private System.Windows.Forms.Label labelEstadoCivil01;
    }
}

