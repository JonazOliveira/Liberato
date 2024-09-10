namespace AulaForAninhado
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            ColumnHeader = new ColumnHeader();
            button1 = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { ColumnHeader });
            listView1.Location = new Point(170, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(169, 426);
            listView1.TabIndex = 0;
            listView1.TabStop = false;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // ColumnHeader
            // 
            ColumnHeader.Text = "===TABUADA===";
            ColumnHeader.Width = 165;
            // 
            // button1
            // 
            button1.Location = new Point(12, 284);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Exexutar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 43);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 2;
            label1.Text = "Ver tabuada de 1 a 10";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "TODAS", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            listBox1.Location = new Point(12, 106);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 169);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 4;
            label2.Text = "Escolha a tabuada";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 450);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TABUADA";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private Label label1;
        private ColumnHeader ColumnHeader;
        private ListBox listBox1;
        private Label label2;
    }
}
