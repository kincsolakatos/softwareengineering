namespace Rendeles_Forms_IASR1J
{
    partial class FormUgyfelSzerkesztes
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
            textBoxNev = new TextBox();
            ugyfelBindingSource = new BindingSource(components);
            textBoxEmail = new TextBox();
            textBoxTelefonszam = new TextBox();
            radioButtonMeglevoCimBeallitasa = new RadioButton();
            comboBox1 = new ComboBox();
            radioButtonUjCimBeallitasa = new RadioButton();
            textBoxOrszag = new TextBox();
            textBoxIranyitoszam = new TextBox();
            textBoxVaros = new TextBox();
            textBoxUtca = new TextBox();
            textBoxHazszam = new TextBox();
            buttonUjElemHozzaadasa = new Button();
            buttonMegse = new Button();
            labelNev = new Label();
            labelEmail = new Label();
            labelTelefonszam = new Label();
            labelOrszag = new Label();
            labelIranyitoszam = new Label();
            labelVaros = new Label();
            labelUtca = new Label();
            labelHazszam = new Label();
            cimBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cimBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxNev
            // 
            textBoxNev.DataBindings.Add(new Binding("Text", ugyfelBindingSource, "Nev", true));
            textBoxNev.Location = new Point(93, 12);
            textBoxNev.Name = "textBoxNev";
            textBoxNev.Size = new Size(695, 23);
            textBoxNev.TabIndex = 0;
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // textBoxEmail
            // 
            textBoxEmail.DataBindings.Add(new Binding("Text", ugyfelBindingSource, "Email", true));
            textBoxEmail.Location = new Point(93, 41);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(695, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxTelefonszam
            // 
            textBoxTelefonszam.DataBindings.Add(new Binding("Text", ugyfelBindingSource, "Telefonszam", true));
            textBoxTelefonszam.Location = new Point(93, 70);
            textBoxTelefonszam.Name = "textBoxTelefonszam";
            textBoxTelefonszam.Size = new Size(695, 23);
            textBoxTelefonszam.TabIndex = 2;
            // 
            // radioButtonMeglevoCimBeallitasa
            // 
            radioButtonMeglevoCimBeallitasa.AutoSize = true;
            radioButtonMeglevoCimBeallitasa.Location = new Point(12, 99);
            radioButtonMeglevoCimBeallitasa.Name = "radioButtonMeglevoCimBeallitasa";
            radioButtonMeglevoCimBeallitasa.Size = new Size(134, 19);
            radioButtonMeglevoCimBeallitasa.TabIndex = 3;
            radioButtonMeglevoCimBeallitasa.TabStop = true;
            radioButtonMeglevoCimBeallitasa.Text = "Letezo cim beallitasa";
            radioButtonMeglevoCimBeallitasa.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 124);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(776, 23);
            comboBox1.TabIndex = 4;
            // 
            // radioButtonUjCimBeallitasa
            // 
            radioButtonUjCimBeallitasa.AutoSize = true;
            radioButtonUjCimBeallitasa.Location = new Point(12, 153);
            radioButtonUjCimBeallitasa.Name = "radioButtonUjCimBeallitasa";
            radioButtonUjCimBeallitasa.Size = new Size(111, 19);
            radioButtonUjCimBeallitasa.TabIndex = 5;
            radioButtonUjCimBeallitasa.TabStop = true;
            radioButtonUjCimBeallitasa.Text = "Uj cim beallitasa";
            radioButtonUjCimBeallitasa.UseVisualStyleBackColor = true;
            // 
            // textBoxOrszag
            // 
            textBoxOrszag.DataBindings.Add(new Binding("Text", cimBindingSource, "Orszag", true));
            textBoxOrszag.Location = new Point(93, 178);
            textBoxOrszag.Name = "textBoxOrszag";
            textBoxOrszag.Size = new Size(695, 23);
            textBoxOrszag.TabIndex = 6;
            // 
            // textBoxIranyitoszam
            // 
            textBoxIranyitoszam.DataBindings.Add(new Binding("Text", cimBindingSource, "Iranyitoszam", true));
            textBoxIranyitoszam.Location = new Point(93, 207);
            textBoxIranyitoszam.Name = "textBoxIranyitoszam";
            textBoxIranyitoszam.Size = new Size(695, 23);
            textBoxIranyitoszam.TabIndex = 7;
            // 
            // textBoxVaros
            // 
            textBoxVaros.DataBindings.Add(new Binding("Text", cimBindingSource, "Varos", true));
            textBoxVaros.Location = new Point(93, 236);
            textBoxVaros.Name = "textBoxVaros";
            textBoxVaros.Size = new Size(695, 23);
            textBoxVaros.TabIndex = 8;
            // 
            // textBoxUtca
            // 
            textBoxUtca.DataBindings.Add(new Binding("Text", cimBindingSource, "Utca", true));
            textBoxUtca.Location = new Point(93, 265);
            textBoxUtca.Name = "textBoxUtca";
            textBoxUtca.Size = new Size(695, 23);
            textBoxUtca.TabIndex = 9;
            // 
            // textBoxHazszam
            // 
            textBoxHazszam.DataBindings.Add(new Binding("Text", cimBindingSource, "Hazszam", true));
            textBoxHazszam.Location = new Point(93, 294);
            textBoxHazszam.Name = "textBoxHazszam";
            textBoxHazszam.Size = new Size(695, 23);
            textBoxHazszam.TabIndex = 10;
            // 
            // buttonUjElemHozzaadasa
            // 
            buttonUjElemHozzaadasa.Location = new Point(12, 323);
            buttonUjElemHozzaadasa.Name = "buttonUjElemHozzaadasa";
            buttonUjElemHozzaadasa.Size = new Size(770, 23);
            buttonUjElemHozzaadasa.TabIndex = 11;
            buttonUjElemHozzaadasa.Text = "Uj elem hozzaadasa";
            buttonUjElemHozzaadasa.UseVisualStyleBackColor = true;
            buttonUjElemHozzaadasa.Click += buttonUjElemHozzaadasa_Click;
            // 
            // buttonMegse
            // 
            buttonMegse.Location = new Point(12, 352);
            buttonMegse.Name = "buttonMegse";
            buttonMegse.Size = new Size(770, 23);
            buttonMegse.TabIndex = 12;
            buttonMegse.Text = "Megse";
            buttonMegse.UseVisualStyleBackColor = true;
            buttonMegse.Click += buttonMegse_Click;
            // 
            // labelNev
            // 
            labelNev.AutoSize = true;
            labelNev.Location = new Point(56, 15);
            labelNev.Name = "labelNev";
            labelNev.Size = new Size(31, 15);
            labelNev.TabIndex = 13;
            labelNev.Text = "Nev:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(48, 44);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 14;
            labelEmail.Text = "Email:";
            // 
            // labelTelefonszam
            // 
            labelTelefonszam.AutoSize = true;
            labelTelefonszam.Location = new Point(12, 73);
            labelTelefonszam.Name = "labelTelefonszam";
            labelTelefonszam.Size = new Size(75, 15);
            labelTelefonszam.TabIndex = 15;
            labelTelefonszam.Text = "Telefonszam:";
            // 
            // labelOrszag
            // 
            labelOrszag.AutoSize = true;
            labelOrszag.Location = new Point(41, 181);
            labelOrszag.Name = "labelOrszag";
            labelOrszag.Size = new Size(46, 15);
            labelOrszag.TabIndex = 16;
            labelOrszag.Text = "Orszag:";
            // 
            // labelIranyitoszam
            // 
            labelIranyitoszam.AutoSize = true;
            labelIranyitoszam.Location = new Point(10, 210);
            labelIranyitoszam.Name = "labelIranyitoszam";
            labelIranyitoszam.Size = new Size(77, 15);
            labelIranyitoszam.TabIndex = 17;
            labelIranyitoszam.Text = "Iranyitoszam:";
            // 
            // labelVaros
            // 
            labelVaros.AutoSize = true;
            labelVaros.Location = new Point(48, 239);
            labelVaros.Name = "labelVaros";
            labelVaros.Size = new Size(38, 15);
            labelVaros.TabIndex = 18;
            labelVaros.Text = "Varos:";
            // 
            // labelUtca
            // 
            labelUtca.AutoSize = true;
            labelUtca.Location = new Point(53, 268);
            labelUtca.Name = "labelUtca";
            labelUtca.Size = new Size(34, 15);
            labelUtca.TabIndex = 19;
            labelUtca.Text = "Utca:";
            // 
            // labelHazszam
            // 
            labelHazszam.AutoSize = true;
            labelHazszam.Location = new Point(30, 297);
            labelHazszam.Name = "labelHazszam";
            labelHazszam.Size = new Size(57, 15);
            labelHazszam.TabIndex = 20;
            labelHazszam.Text = "Hazszam:";
            // 
            // cimBindingSource
            // 
            cimBindingSource.DataSource = typeof(Models.Cim);
            // 
            // FormUgyfelSzerkesztes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelHazszam);
            Controls.Add(labelUtca);
            Controls.Add(labelVaros);
            Controls.Add(labelIranyitoszam);
            Controls.Add(labelOrszag);
            Controls.Add(labelTelefonszam);
            Controls.Add(labelEmail);
            Controls.Add(labelNev);
            Controls.Add(buttonMegse);
            Controls.Add(buttonUjElemHozzaadasa);
            Controls.Add(textBoxHazszam);
            Controls.Add(textBoxUtca);
            Controls.Add(textBoxVaros);
            Controls.Add(textBoxIranyitoszam);
            Controls.Add(textBoxOrszag);
            Controls.Add(radioButtonUjCimBeallitasa);
            Controls.Add(comboBox1);
            Controls.Add(radioButtonMeglevoCimBeallitasa);
            Controls.Add(textBoxTelefonszam);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNev);
            Name = "FormUgyfelSzerkesztes";
            Text = "FormUgyfelSzerkesztes";
            Load += FormUgyfelSzerkesztes_Load;
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cimBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNev;
        private TextBox textBoxEmail;
        private TextBox textBoxTelefonszam;
        private RadioButton radioButtonMeglevoCimBeallitasa;
        private ComboBox comboBox1;
        private RadioButton radioButtonUjCimBeallitasa;
        private TextBox textBoxOrszag;
        private TextBox textBoxIranyitoszam;
        private TextBox textBoxVaros;
        private TextBox textBoxUtca;
        private TextBox textBoxHazszam;
        private Button buttonUjElemHozzaadasa;
        private Button buttonMegse;
        private Label labelNev;
        private Label labelEmail;
        private Label labelTelefonszam;
        private Label labelOrszag;
        private Label labelIranyitoszam;
        private Label labelVaros;
        private Label labelUtca;
        private Label labelHazszam;
        private BindingSource ugyfelBindingSource;
        private BindingSource cimBindingSource;
    }
}