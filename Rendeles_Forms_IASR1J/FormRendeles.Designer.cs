namespace Rendeles_Forms_IASR1J
{
    partial class FormRendeles
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
            labelUgyfelekSzurese = new Label();
            textBoxUgyfelekSzurese = new TextBox();
            labelUgyfelek = new Label();
            listBoxUgyfelek = new ListBox();
            ugyfelBindingSource = new BindingSource(components);
            listBoxRendelesek = new ListBox();
            rendelesBindingSource = new BindingSource(components);
            labelRendelesek = new Label();
            buttonUjRendeles = new Button();
            listBoxTermekek = new ListBox();
            termekBindingSource = new BindingSource(components);
            dataGridViewRendeltTetelek = new DataGridView();
            labelRendeletTetelek = new Label();
            comboBoxRendelesCime = new ComboBox();
            labelRendelesCime = new Label();
            textBoxKedvezmeny = new TextBox();
            labelKedvezmeny = new Label();
            comboBoxStatusz = new ComboBox();
            labelStatusz = new Label();
            labelTermekek = new Label();
            textBoxMennyiseg = new TextBox();
            labelMennyiseg = new Label();
            buttonMentes = new Button();
            buttonExcelExport = new Button();
            buttonTetelTorles = new Button();
            buttonTetelHozzaadas = new Button();
            labelARendelesTeljesErteke = new Label();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRendeltTetelek).BeginInit();
            SuspendLayout();
            // 
            // labelUgyfelekSzurese
            // 
            labelUgyfelekSzurese.AutoSize = true;
            labelUgyfelekSzurese.Location = new Point(12, 9);
            labelUgyfelekSzurese.Name = "labelUgyfelekSzurese";
            labelUgyfelekSzurese.Size = new Size(95, 15);
            labelUgyfelekSzurese.TabIndex = 0;
            labelUgyfelekSzurese.Text = "Ugyfelek Szurese";
            // 
            // textBoxUgyfelekSzurese
            // 
            textBoxUgyfelekSzurese.Location = new Point(12, 27);
            textBoxUgyfelekSzurese.Name = "textBoxUgyfelekSzurese";
            textBoxUgyfelekSzurese.Size = new Size(120, 23);
            textBoxUgyfelekSzurese.TabIndex = 1;
            textBoxUgyfelekSzurese.TextChanged += textBoxUgyfelekSzurese_TextChanged;
            // 
            // labelUgyfelek
            // 
            labelUgyfelek.AutoSize = true;
            labelUgyfelek.Location = new Point(12, 53);
            labelUgyfelek.Name = "labelUgyfelek";
            labelUgyfelek.Size = new Size(53, 15);
            labelUgyfelek.TabIndex = 2;
            labelUgyfelek.Text = "Ugyfelek";
            // 
            // listBoxUgyfelek
            // 
            listBoxUgyfelek.DataSource = ugyfelBindingSource;
            listBoxUgyfelek.DisplayMember = "Nev";
            listBoxUgyfelek.FormattingEnabled = true;
            listBoxUgyfelek.ItemHeight = 15;
            listBoxUgyfelek.Location = new Point(12, 71);
            listBoxUgyfelek.Name = "listBoxUgyfelek";
            listBoxUgyfelek.Size = new Size(120, 334);
            listBoxUgyfelek.TabIndex = 3;
            listBoxUgyfelek.ValueMember = "UgyfelId";
            listBoxUgyfelek.SelectedIndexChanged += listBoxUgyfelek_SelectedIndexChanged;
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // listBoxRendelesek
            // 
            listBoxRendelesek.DataSource = rendelesBindingSource;
            listBoxRendelesek.DisplayMember = "RendelesDatum";
            listBoxRendelesek.FormattingEnabled = true;
            listBoxRendelesek.ItemHeight = 15;
            listBoxRendelesek.Location = new Point(138, 71);
            listBoxRendelesek.Name = "listBoxRendelesek";
            listBoxRendelesek.Size = new Size(120, 334);
            listBoxRendelesek.TabIndex = 4;
            listBoxRendelesek.ValueMember = "RendelesId";
            listBoxRendelesek.SelectedIndexChanged += listBoxRendelesek_SelectedIndexChanged;
            // 
            // rendelesBindingSource
            // 
            rendelesBindingSource.DataSource = typeof(Models.Rendeles);
            // 
            // labelRendelesek
            // 
            labelRendelesek.AutoSize = true;
            labelRendelesek.Location = new Point(138, 53);
            labelRendelesek.Name = "labelRendelesek";
            labelRendelesek.Size = new Size(66, 15);
            labelRendelesek.TabIndex = 5;
            labelRendelesek.Text = "Rendelesek";
            // 
            // buttonUjRendeles
            // 
            buttonUjRendeles.Location = new Point(12, 415);
            buttonUjRendeles.Name = "buttonUjRendeles";
            buttonUjRendeles.Size = new Size(120, 23);
            buttonUjRendeles.TabIndex = 6;
            buttonUjRendeles.Text = "Uj Rendeles";
            buttonUjRendeles.UseVisualStyleBackColor = true;
            buttonUjRendeles.Click += buttonUjRendeles_Click;
            // 
            // listBoxTermekek
            // 
            listBoxTermekek.DataSource = termekBindingSource;
            listBoxTermekek.DisplayMember = "Nev";
            listBoxTermekek.FormattingEnabled = true;
            listBoxTermekek.ItemHeight = 15;
            listBoxTermekek.Location = new Point(668, 71);
            listBoxTermekek.Name = "listBoxTermekek";
            listBoxTermekek.Size = new Size(120, 334);
            listBoxTermekek.TabIndex = 7;
            listBoxTermekek.ValueMember = "TermekId";
            // 
            // termekBindingSource
            // 
            termekBindingSource.DataSource = typeof(Models.Termek);
            // 
            // dataGridViewRendeltTetelek
            // 
            dataGridViewRendeltTetelek.AllowUserToAddRows = false;
            dataGridViewRendeltTetelek.AllowUserToDeleteRows = false;
            dataGridViewRendeltTetelek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRendeltTetelek.Location = new Point(264, 71);
            dataGridViewRendeltTetelek.Name = "dataGridViewRendeltTetelek";
            dataGridViewRendeltTetelek.ReadOnly = true;
            dataGridViewRendeltTetelek.RowTemplate.Height = 25;
            dataGridViewRendeltTetelek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRendeltTetelek.Size = new Size(272, 334);
            dataGridViewRendeltTetelek.TabIndex = 8;
            // 
            // labelRendeletTetelek
            // 
            labelRendeletTetelek.AutoSize = true;
            labelRendeletTetelek.Location = new Point(264, 53);
            labelRendeletTetelek.Name = "labelRendeletTetelek";
            labelRendeletTetelek.Size = new Size(92, 15);
            labelRendeletTetelek.TabIndex = 9;
            labelRendeletTetelek.Text = "Rendelet Tetelek";
            // 
            // comboBoxRendelesCime
            // 
            comboBoxRendelesCime.DataBindings.Add(new Binding("SelectedValue", rendelesBindingSource, "SzallitasiCimId", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBoxRendelesCime.FormattingEnabled = true;
            comboBoxRendelesCime.Location = new Point(264, 27);
            comboBoxRendelesCime.Name = "comboBoxRendelesCime";
            comboBoxRendelesCime.Size = new Size(272, 23);
            comboBoxRendelesCime.TabIndex = 10;
            // 
            // labelRendelesCime
            // 
            labelRendelesCime.AutoSize = true;
            labelRendelesCime.Location = new Point(264, 9);
            labelRendelesCime.Name = "labelRendelesCime";
            labelRendelesCime.Size = new Size(85, 15);
            labelRendelesCime.TabIndex = 11;
            labelRendelesCime.Text = "Rendeles Cime";
            // 
            // textBoxKedvezmeny
            // 
            textBoxKedvezmeny.DataBindings.Add(new Binding("Text", rendelesBindingSource, "Kedvezmeny", true, DataSourceUpdateMode.OnPropertyChanged, "0", "0.00%"));
            textBoxKedvezmeny.Location = new Point(542, 27);
            textBoxKedvezmeny.Name = "textBoxKedvezmeny";
            textBoxKedvezmeny.Size = new Size(122, 23);
            textBoxKedvezmeny.TabIndex = 12;
            // 
            // labelKedvezmeny
            // 
            labelKedvezmeny.AutoSize = true;
            labelKedvezmeny.Location = new Point(542, 9);
            labelKedvezmeny.Name = "labelKedvezmeny";
            labelKedvezmeny.Size = new Size(74, 15);
            labelKedvezmeny.TabIndex = 13;
            labelKedvezmeny.Text = "Kedvezmeny";
            // 
            // comboBoxStatusz
            // 
            comboBoxStatusz.DataBindings.Add(new Binding("Text", rendelesBindingSource, "Statusz", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBoxStatusz.FormattingEnabled = true;
            comboBoxStatusz.Items.AddRange(new object[] { "\"Feldolgozás alatt\"", "\"Szállítás\"", "\"Kiszállítva\"", "\"Törölve\"" });
            comboBoxStatusz.Location = new Point(668, 27);
            comboBoxStatusz.Name = "comboBoxStatusz";
            comboBoxStatusz.Size = new Size(120, 23);
            comboBoxStatusz.TabIndex = 14;
            // 
            // labelStatusz
            // 
            labelStatusz.AutoSize = true;
            labelStatusz.Location = new Point(668, 9);
            labelStatusz.Name = "labelStatusz";
            labelStatusz.Size = new Size(44, 15);
            labelStatusz.TabIndex = 15;
            labelStatusz.Text = "Statusz";
            // 
            // labelTermekek
            // 
            labelTermekek.AutoSize = true;
            labelTermekek.Location = new Point(668, 53);
            labelTermekek.Name = "labelTermekek";
            labelTermekek.Size = new Size(57, 15);
            labelTermekek.TabIndex = 16;
            labelTermekek.Text = "Termekek";
            // 
            // textBoxMennyiseg
            // 
            textBoxMennyiseg.Location = new Point(542, 89);
            textBoxMennyiseg.Name = "textBoxMennyiseg";
            textBoxMennyiseg.Size = new Size(120, 23);
            textBoxMennyiseg.TabIndex = 17;
            // 
            // labelMennyiseg
            // 
            labelMennyiseg.AutoSize = true;
            labelMennyiseg.Location = new Point(542, 71);
            labelMennyiseg.Name = "labelMennyiseg";
            labelMennyiseg.Size = new Size(65, 15);
            labelMennyiseg.TabIndex = 18;
            labelMennyiseg.Text = "Mennyiseg";
            // 
            // buttonMentes
            // 
            buttonMentes.Location = new Point(542, 415);
            buttonMentes.Name = "buttonMentes";
            buttonMentes.Size = new Size(118, 23);
            buttonMentes.TabIndex = 19;
            buttonMentes.Text = "Mentes";
            buttonMentes.UseVisualStyleBackColor = true;
            // 
            // buttonExcelExport
            // 
            buttonExcelExport.Location = new Point(668, 415);
            buttonExcelExport.Name = "buttonExcelExport";
            buttonExcelExport.Size = new Size(122, 23);
            buttonExcelExport.TabIndex = 20;
            buttonExcelExport.Text = "Excel Export";
            buttonExcelExport.UseVisualStyleBackColor = true;
            // 
            // buttonTetelTorles
            // 
            buttonTetelTorles.Location = new Point(542, 147);
            buttonTetelTorles.Name = "buttonTetelTorles";
            buttonTetelTorles.Size = new Size(120, 23);
            buttonTetelTorles.TabIndex = 21;
            buttonTetelTorles.Text = "Tetel Torles";
            buttonTetelTorles.UseVisualStyleBackColor = true;
            buttonTetelTorles.Click += buttonTetelTorles_Click;
            // 
            // buttonTetelHozzaadas
            // 
            buttonTetelHozzaadas.Location = new Point(542, 118);
            buttonTetelHozzaadas.Name = "buttonTetelHozzaadas";
            buttonTetelHozzaadas.Size = new Size(120, 23);
            buttonTetelHozzaadas.TabIndex = 22;
            buttonTetelHozzaadas.Text = "Tetel Hozzaadas";
            buttonTetelHozzaadas.UseVisualStyleBackColor = true;
            buttonTetelHozzaadas.Click += buttonTetelHozzaadas_Click;
            // 
            // labelARendelesTeljesErteke
            // 
            labelARendelesTeljesErteke.AutoSize = true;
            labelARendelesTeljesErteke.Location = new Point(138, 419);
            labelARendelesTeljesErteke.Name = "labelARendelesTeljesErteke";
            labelARendelesTeljesErteke.Size = new Size(38, 15);
            labelARendelesTeljesErteke.TabIndex = 23;
            labelARendelesTeljesErteke.Text = "label1";
            // 
            // FormRendeles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelARendelesTeljesErteke);
            Controls.Add(buttonTetelHozzaadas);
            Controls.Add(buttonTetelTorles);
            Controls.Add(buttonExcelExport);
            Controls.Add(buttonMentes);
            Controls.Add(labelMennyiseg);
            Controls.Add(textBoxMennyiseg);
            Controls.Add(labelTermekek);
            Controls.Add(labelStatusz);
            Controls.Add(comboBoxStatusz);
            Controls.Add(labelKedvezmeny);
            Controls.Add(textBoxKedvezmeny);
            Controls.Add(labelRendelesCime);
            Controls.Add(comboBoxRendelesCime);
            Controls.Add(labelRendeletTetelek);
            Controls.Add(dataGridViewRendeltTetelek);
            Controls.Add(listBoxTermekek);
            Controls.Add(buttonUjRendeles);
            Controls.Add(labelRendelesek);
            Controls.Add(listBoxRendelesek);
            Controls.Add(listBoxUgyfelek);
            Controls.Add(labelUgyfelek);
            Controls.Add(textBoxUgyfelekSzurese);
            Controls.Add(labelUgyfelekSzurese);
            Name = "FormRendeles";
            Text = "FormRendeles";
            Load += FormRendeles_Load;
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRendeltTetelek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUgyfelekSzurese;
        private TextBox textBoxUgyfelekSzurese;
        private Label labelUgyfelek;
        private ListBox listBoxUgyfelek;
        private ListBox listBoxRendelesek;
        private Label labelRendelesek;
        private Button buttonUjRendeles;
        private ListBox listBoxTermekek;
        private DataGridView dataGridViewRendeltTetelek;
        private Label labelRendeletTetelek;
        private ComboBox comboBoxRendelesCime;
        private Label labelRendelesCime;
        private TextBox textBoxKedvezmeny;
        private Label labelKedvezmeny;
        private ComboBox comboBoxStatusz;
        private Label labelStatusz;
        private Label labelTermekek;
        private TextBox textBoxMennyiseg;
        private Label labelMennyiseg;
        private Button buttonMentes;
        private Button buttonExcelExport;
        private Button buttonTetelTorles;
        private Button buttonTetelHozzaadas;
        private BindingSource ugyfelBindingSource;
        private BindingSource termekBindingSource;
        private BindingSource rendelesBindingSource;
        private Label labelARendelesTeljesErteke;
    }
}