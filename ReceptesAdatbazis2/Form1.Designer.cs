namespace ReceptesAdatbazis2
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            fogasokBindingSource = new BindingSource(components);
            listBox2 = new ListBox();
            nyersanyagokBindingSource = new BindingSource(components);
            label1 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            receptIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fogasNevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nyersanyagNevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mennyiseg4foDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mennyisegiEgysegDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            egysegarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hozzavalokBindingSource = new BindingSource(components);
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)fogasokBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nyersanyagokBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hozzavalokBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(587, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // listBox1
            // 
            listBox1.DataSource = fogasokBindingSource;
            listBox1.DisplayMember = "FogasNev";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(156, 364);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // fogasokBindingSource
            // 
            fogasokBindingSource.DataSource = typeof(Models.Fogasok);
            // 
            // listBox2
            // 
            listBox2.DataSource = nyersanyagokBindingSource;
            listBox2.DisplayMember = "NyersanyagNev";
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(668, 41);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 364);
            listBox2.TabIndex = 3;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // nyersanyagokBindingSource
            // 
            nyersanyagokBindingSource.DataSource = typeof(Models.Nyersanyagok);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(693, 419);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(587, 416);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(12, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { receptIdDataGridViewTextBoxColumn, fogasNevDataGridViewTextBoxColumn, nyersanyagNevDataGridViewTextBoxColumn, mennyiseg4foDataGridViewTextBoxColumn, mennyisegiEgysegDataGridViewTextBoxColumn, egysegarDataGridViewTextBoxColumn });
            dataGridView1.DataSource = hozzavalokBindingSource;
            dataGridView1.Location = new Point(174, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(407, 427);
            dataGridView1.TabIndex = 8;
            // 
            // receptIdDataGridViewTextBoxColumn
            // 
            receptIdDataGridViewTextBoxColumn.DataPropertyName = "ReceptId";
            receptIdDataGridViewTextBoxColumn.HeaderText = "ReceptId";
            receptIdDataGridViewTextBoxColumn.Name = "receptIdDataGridViewTextBoxColumn";
            // 
            // fogasNevDataGridViewTextBoxColumn
            // 
            fogasNevDataGridViewTextBoxColumn.DataPropertyName = "FogasNev";
            fogasNevDataGridViewTextBoxColumn.HeaderText = "FogasNev";
            fogasNevDataGridViewTextBoxColumn.Name = "fogasNevDataGridViewTextBoxColumn";
            // 
            // nyersanyagNevDataGridViewTextBoxColumn
            // 
            nyersanyagNevDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagNev";
            nyersanyagNevDataGridViewTextBoxColumn.HeaderText = "NyersanyagNev";
            nyersanyagNevDataGridViewTextBoxColumn.Name = "nyersanyagNevDataGridViewTextBoxColumn";
            // 
            // mennyiseg4foDataGridViewTextBoxColumn
            // 
            mennyiseg4foDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg4fo";
            mennyiseg4foDataGridViewTextBoxColumn.HeaderText = "Mennyiseg4fo";
            mennyiseg4foDataGridViewTextBoxColumn.Name = "mennyiseg4foDataGridViewTextBoxColumn";
            // 
            // mennyisegiEgysegDataGridViewTextBoxColumn
            // 
            mennyisegiEgysegDataGridViewTextBoxColumn.DataPropertyName = "MennyisegiEgyseg";
            mennyisegiEgysegDataGridViewTextBoxColumn.HeaderText = "MennyisegiEgyseg";
            mennyisegiEgysegDataGridViewTextBoxColumn.Name = "mennyisegiEgysegDataGridViewTextBoxColumn";
            // 
            // egysegarDataGridViewTextBoxColumn
            // 
            egysegarDataGridViewTextBoxColumn.DataPropertyName = "Egysegar";
            egysegarDataGridViewTextBoxColumn.HeaderText = "Egysegar";
            egysegarDataGridViewTextBoxColumn.Name = "egysegarDataGridViewTextBoxColumn";
            // 
            // hozzavalokBindingSource
            // 
            hozzavalokBindingSource.DataSource = typeof(Models.Hozzavalok);
            // 
            // button3
            // 
            button3.Location = new Point(587, 41);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(587, 70);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fogasokBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)nyersanyagokBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hozzavalokBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private BindingSource nyersanyagokBindingSource;
        private BindingSource fogasokBindingSource;
        private DataGridViewTextBoxColumn receptIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fogasNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nyersanyagNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiseg4foDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyisegiEgysegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egysegarDataGridViewTextBoxColumn;
        private BindingSource hozzavalokBindingSource;
    }
}
