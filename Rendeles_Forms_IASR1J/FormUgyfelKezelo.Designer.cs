namespace Rendeles_Forms_IASR1J
{
    partial class FormUgyfelKezelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ugyfelIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonszamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lakcimIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lakcimDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rendelesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ugyfelBindingSource = new BindingSource(components);
            buttonUjUgyfelHozzaadasa = new Button();
            buttonUgyfelModositasa = new Button();
            buttonUgyfelTorlese = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ugyfelIdDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telefonszamDataGridViewTextBoxColumn, lakcimIdDataGridViewTextBoxColumn, lakcimDataGridViewTextBoxColumn, rendelesDataGridViewTextBoxColumn });
            dataGridView1.DataSource = ugyfelBindingSource;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 368);
            dataGridView1.TabIndex = 1;
            // 
            // ugyfelIdDataGridViewTextBoxColumn
            // 
            ugyfelIdDataGridViewTextBoxColumn.DataPropertyName = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.HeaderText = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.Name = "ugyfelIdDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefonszamDataGridViewTextBoxColumn
            // 
            telefonszamDataGridViewTextBoxColumn.DataPropertyName = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.HeaderText = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.Name = "telefonszamDataGridViewTextBoxColumn";
            // 
            // lakcimIdDataGridViewTextBoxColumn
            // 
            lakcimIdDataGridViewTextBoxColumn.DataPropertyName = "LakcimId";
            lakcimIdDataGridViewTextBoxColumn.HeaderText = "LakcimId";
            lakcimIdDataGridViewTextBoxColumn.Name = "lakcimIdDataGridViewTextBoxColumn";
            // 
            // lakcimDataGridViewTextBoxColumn
            // 
            lakcimDataGridViewTextBoxColumn.DataPropertyName = "Lakcim";
            lakcimDataGridViewTextBoxColumn.HeaderText = "Lakcim";
            lakcimDataGridViewTextBoxColumn.Name = "lakcimDataGridViewTextBoxColumn";
            // 
            // rendelesDataGridViewTextBoxColumn
            // 
            rendelesDataGridViewTextBoxColumn.DataPropertyName = "Rendeles";
            rendelesDataGridViewTextBoxColumn.HeaderText = "Rendeles";
            rendelesDataGridViewTextBoxColumn.Name = "rendelesDataGridViewTextBoxColumn";
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // buttonUjUgyfelHozzaadasa
            // 
            buttonUjUgyfelHozzaadasa.Location = new Point(12, 415);
            buttonUjUgyfelHozzaadasa.Name = "buttonUjUgyfelHozzaadasa";
            buttonUjUgyfelHozzaadasa.Size = new Size(128, 23);
            buttonUjUgyfelHozzaadasa.TabIndex = 2;
            buttonUjUgyfelHozzaadasa.Text = "Uj Ugyfel Hozzaadasa";
            buttonUjUgyfelHozzaadasa.UseVisualStyleBackColor = true;
            buttonUjUgyfelHozzaadasa.Click += buttonUjUgyfelHozzaadasa_Click;
            // 
            // buttonUgyfelModositasa
            // 
            buttonUgyfelModositasa.Location = new Point(146, 415);
            buttonUgyfelModositasa.Name = "buttonUgyfelModositasa";
            buttonUgyfelModositasa.Size = new Size(113, 23);
            buttonUgyfelModositasa.TabIndex = 3;
            buttonUgyfelModositasa.Text = "Ugyfel Modositasa";
            buttonUgyfelModositasa.UseVisualStyleBackColor = true;
            buttonUgyfelModositasa.Click += buttonUgyfelModositasa_Click;
            // 
            // buttonUgyfelTorlese
            // 
            buttonUgyfelTorlese.Location = new Point(265, 415);
            buttonUgyfelTorlese.Name = "buttonUgyfelTorlese";
            buttonUgyfelTorlese.Size = new Size(93, 23);
            buttonUgyfelTorlese.TabIndex = 4;
            buttonUgyfelTorlese.Text = "Ugyfel Torlese";
            buttonUgyfelTorlese.UseVisualStyleBackColor = true;
            buttonUgyfelTorlese.Click += buttonUgyfelTorlese_Click;
            // 
            // FormUgyfelKezelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonUgyfelTorlese);
            Controls.Add(buttonUgyfelModositasa);
            Controls.Add(buttonUjUgyfelHozzaadasa);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Name = "FormUgyfelKezelo";
            Text = "FormUgyfelKezelo";
            Load += FormUgyfelKezelo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button buttonUjUgyfelHozzaadasa;
        private Button buttonUgyfelModositasa;
        private Button buttonUgyfelTorlese;
        private DataGridViewTextBoxColumn ugyfelIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonszamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lakcimIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lakcimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rendelesDataGridViewTextBoxColumn;
        private BindingSource ugyfelBindingSource;
    }
}