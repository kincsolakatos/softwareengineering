namespace Rendeles_Forms_IASR1J
{
    partial class TermekKategoriaForm
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
            buttonTorles = new Button();
            buttonMentes = new Button();
            buttonUjGyermekKategoria = new Button();
            buttonUjTestverKategoria = new Button();
            textBoxNev = new TextBox();
            textBoxLeiras = new TextBox();
            labelNev = new Label();
            labelLeiras = new Label();
            treeViewKategoriak = new TreeView();
            SuspendLayout();
            // 
            // buttonTorles
            // 
            buttonTorles.Location = new Point(713, 415);
            buttonTorles.Name = "buttonTorles";
            buttonTorles.Size = new Size(75, 23);
            buttonTorles.TabIndex = 0;
            buttonTorles.Text = "Torles";
            buttonTorles.UseVisualStyleBackColor = true;
            buttonTorles.Click += buttonTorles_Click;
            // 
            // buttonMentes
            // 
            buttonMentes.Location = new Point(632, 415);
            buttonMentes.Name = "buttonMentes";
            buttonMentes.Size = new Size(75, 23);
            buttonMentes.TabIndex = 1;
            buttonMentes.Text = "Mentes";
            buttonMentes.UseVisualStyleBackColor = true;
            buttonMentes.Click += buttonMentes_Click;
            // 
            // buttonUjGyermekKategoria
            // 
            buttonUjGyermekKategoria.Location = new Point(499, 415);
            buttonUjGyermekKategoria.Name = "buttonUjGyermekKategoria";
            buttonUjGyermekKategoria.Size = new Size(127, 23);
            buttonUjGyermekKategoria.TabIndex = 2;
            buttonUjGyermekKategoria.Text = "Uj gyermek kategoria";
            buttonUjGyermekKategoria.UseVisualStyleBackColor = true;
            buttonUjGyermekKategoria.Click += buttonUjGyermekKategoria_Click;
            // 
            // buttonUjTestverKategoria
            // 
            buttonUjTestverKategoria.Location = new Point(377, 415);
            buttonUjTestverKategoria.Name = "buttonUjTestverKategoria";
            buttonUjTestverKategoria.Size = new Size(116, 23);
            buttonUjTestverKategoria.TabIndex = 3;
            buttonUjTestverKategoria.Text = "Uj testver kategoria";
            buttonUjTestverKategoria.UseVisualStyleBackColor = true;
            buttonUjTestverKategoria.Click += buttonUjTestverKategoria_Click;
            // 
            // textBoxNev
            // 
            textBoxNev.Location = new Point(377, 12);
            textBoxNev.Name = "textBoxNev";
            textBoxNev.Size = new Size(411, 23);
            textBoxNev.TabIndex = 4;
            // 
            // textBoxLeiras
            // 
            textBoxLeiras.Location = new Point(377, 41);
            textBoxLeiras.Name = "textBoxLeiras";
            textBoxLeiras.Size = new Size(411, 23);
            textBoxLeiras.TabIndex = 5;
            // 
            // labelNev
            // 
            labelNev.AutoSize = true;
            labelNev.Location = new Point(340, 15);
            labelNev.Name = "labelNev";
            labelNev.Size = new Size(31, 15);
            labelNev.TabIndex = 6;
            labelNev.Text = "Nev:";
            // 
            // labelLeiras
            // 
            labelLeiras.AutoSize = true;
            labelLeiras.Location = new Point(331, 44);
            labelLeiras.Name = "labelLeiras";
            labelLeiras.Size = new Size(40, 15);
            labelLeiras.TabIndex = 7;
            labelLeiras.Text = "Leiras:";
            // 
            // treeViewKategoriak
            // 
            treeViewKategoriak.Location = new Point(12, 12);
            treeViewKategoriak.Name = "treeViewKategoriak";
            treeViewKategoriak.Size = new Size(313, 426);
            treeViewKategoriak.TabIndex = 8;
            treeViewKategoriak.AfterSelect += treeViewKategoriak_AfterSelect;
            // 
            // TermekKategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(treeViewKategoriak);
            Controls.Add(labelLeiras);
            Controls.Add(labelNev);
            Controls.Add(textBoxLeiras);
            Controls.Add(textBoxNev);
            Controls.Add(buttonUjTestverKategoria);
            Controls.Add(buttonUjGyermekKategoria);
            Controls.Add(buttonMentes);
            Controls.Add(buttonTorles);
            Name = "TermekKategoriaForm";
            Text = "TermekKategoriaForm";
            Load += TermekKategoriaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTorles;
        private Button buttonMentes;
        private Button buttonUjGyermekKategoria;
        private Button buttonUjTestverKategoria;
        private TextBox textBoxNev;
        private TextBox textBoxLeiras;
        private Label labelNev;
        private Label labelLeiras;
        private TreeView treeViewKategoriak;
    }
}