namespace Rendeles_Forms_IASR1J
{
    partial class FormTermekKategoria
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
            treeViewKategoriak = new TreeView();
            contextMenuStripKategoria = new ContextMenuStrip(components);
            atnevezesToolStripMenuItem = new ToolStripMenuItem();
            ujFokategoriaToolStripMenuItem = new ToolStripMenuItem();
            ujAlkategoriaToolStripMenuItem = new ToolStripMenuItem();
            torlesToolStripMenuItem = new ToolStripMenuItem();
            frissitesToolStripMenuItem = new ToolStripMenuItem();
            mentesToolStripMenuItem = new ToolStripMenuItem();
            buttonMentes = new Button();
            buttonUjTestverKategoria = new Button();
            buttonUjGyermekKategoria = new Button();
            buttonTorles = new Button();
            labelNev = new Label();
            textBoxNev = new TextBox();
            textBoxLeiras = new TextBox();
            labelLeiras = new Label();
            contextMenuStripKategoria.SuspendLayout();
            SuspendLayout();
            // 
            // treeViewKategoriak
            // 
            treeViewKategoriak.ContextMenuStrip = contextMenuStripKategoria;
            treeViewKategoriak.LabelEdit = true;
            treeViewKategoriak.Location = new Point(12, 12);
            treeViewKategoriak.Name = "treeViewKategoriak";
            treeViewKategoriak.Size = new Size(405, 426);
            treeViewKategoriak.TabIndex = 0;
            treeViewKategoriak.AfterSelect += treeViewKategoriak_AfterSelect;
            // 
            // contextMenuStripKategoria
            // 
            contextMenuStripKategoria.Items.AddRange(new ToolStripItem[] { atnevezesToolStripMenuItem, ujFokategoriaToolStripMenuItem, ujAlkategoriaToolStripMenuItem, torlesToolStripMenuItem, frissitesToolStripMenuItem, mentesToolStripMenuItem });
            contextMenuStripKategoria.Name = "contextMenuStripKategoria";
            contextMenuStripKategoria.Size = new Size(151, 136);
            // 
            // atnevezesToolStripMenuItem
            // 
            atnevezesToolStripMenuItem.Name = "atnevezesToolStripMenuItem";
            atnevezesToolStripMenuItem.Size = new Size(150, 22);
            atnevezesToolStripMenuItem.Text = "Atnevezes";
            atnevezesToolStripMenuItem.Click += atnevezesToolStripMenuItem_Click;
            // 
            // ujFokategoriaToolStripMenuItem
            // 
            ujFokategoriaToolStripMenuItem.Name = "ujFokategoriaToolStripMenuItem";
            ujFokategoriaToolStripMenuItem.Size = new Size(150, 22);
            ujFokategoriaToolStripMenuItem.Text = "Uj Fokategoria";
            ujFokategoriaToolStripMenuItem.Click += ujFokategoriaToolStripMenuItem_Click;
            // 
            // ujAlkategoriaToolStripMenuItem
            // 
            ujAlkategoriaToolStripMenuItem.Name = "ujAlkategoriaToolStripMenuItem";
            ujAlkategoriaToolStripMenuItem.Size = new Size(150, 22);
            ujAlkategoriaToolStripMenuItem.Text = "Uj Alkategoria";
            ujAlkategoriaToolStripMenuItem.Click += ujAlkategoriaToolStripMenuItem_Click;
            // 
            // torlesToolStripMenuItem
            // 
            torlesToolStripMenuItem.Name = "torlesToolStripMenuItem";
            torlesToolStripMenuItem.Size = new Size(150, 22);
            torlesToolStripMenuItem.Text = "Torles";
            torlesToolStripMenuItem.Click += torlesToolStripMenuItem_Click;
            // 
            // frissitesToolStripMenuItem
            // 
            frissitesToolStripMenuItem.Name = "frissitesToolStripMenuItem";
            frissitesToolStripMenuItem.Size = new Size(150, 22);
            frissitesToolStripMenuItem.Text = "Frissites";
            frissitesToolStripMenuItem.Click += frissitesToolStripMenuItem_Click;
            // 
            // mentesToolStripMenuItem
            // 
            mentesToolStripMenuItem.Name = "mentesToolStripMenuItem";
            mentesToolStripMenuItem.Size = new Size(150, 22);
            mentesToolStripMenuItem.Text = "Mentes";
            mentesToolStripMenuItem.Click += mentesToolStripMenuItem_Click;
            // 
            // buttonMentes
            // 
            buttonMentes.Location = new Point(733, 415);
            buttonMentes.Name = "buttonMentes";
            buttonMentes.Size = new Size(55, 23);
            buttonMentes.TabIndex = 1;
            buttonMentes.Text = "Mentes";
            buttonMentes.UseVisualStyleBackColor = true;
            buttonMentes.Click += buttonMentes_Click;
            // 
            // buttonUjTestverKategoria
            // 
            buttonUjTestverKategoria.Location = new Point(609, 415);
            buttonUjTestverKategoria.Name = "buttonUjTestverKategoria";
            buttonUjTestverKategoria.Size = new Size(118, 23);
            buttonUjTestverKategoria.TabIndex = 2;
            buttonUjTestverKategoria.Text = "Uj Testver Kategoria";
            buttonUjTestverKategoria.UseVisualStyleBackColor = true;
            buttonUjTestverKategoria.Click += buttonUjTestverKategoria_Click;
            // 
            // buttonUjGyermekKategoria
            // 
            buttonUjGyermekKategoria.Location = new Point(474, 415);
            buttonUjGyermekKategoria.Name = "buttonUjGyermekKategoria";
            buttonUjGyermekKategoria.Size = new Size(129, 23);
            buttonUjGyermekKategoria.TabIndex = 3;
            buttonUjGyermekKategoria.Text = "Uj Gyermek Kategoria";
            buttonUjGyermekKategoria.UseVisualStyleBackColor = true;
            buttonUjGyermekKategoria.Click += buttonUjGyermekKategoria_Click;
            // 
            // buttonTorles
            // 
            buttonTorles.Location = new Point(423, 415);
            buttonTorles.Name = "buttonTorles";
            buttonTorles.Size = new Size(45, 23);
            buttonTorles.TabIndex = 4;
            buttonTorles.Text = "Torles";
            buttonTorles.UseVisualStyleBackColor = true;
            buttonTorles.Click += buttonTorles_Click;
            // 
            // labelNev
            // 
            labelNev.AutoSize = true;
            labelNev.Location = new Point(432, 15);
            labelNev.Name = "labelNev";
            labelNev.Size = new Size(31, 15);
            labelNev.TabIndex = 5;
            labelNev.Text = "Nev:";
            // 
            // textBoxNev
            // 
            textBoxNev.Location = new Point(469, 12);
            textBoxNev.Name = "textBoxNev";
            textBoxNev.Size = new Size(319, 23);
            textBoxNev.TabIndex = 6;
            // 
            // textBoxLeiras
            // 
            textBoxLeiras.Location = new Point(469, 41);
            textBoxLeiras.Name = "textBoxLeiras";
            textBoxLeiras.Size = new Size(319, 23);
            textBoxLeiras.TabIndex = 7;
            // 
            // labelLeiras
            // 
            labelLeiras.AutoSize = true;
            labelLeiras.Location = new Point(423, 44);
            labelLeiras.Name = "labelLeiras";
            labelLeiras.Size = new Size(40, 15);
            labelLeiras.TabIndex = 8;
            labelLeiras.Text = "Leiras:";
            // 
            // FormTermekKategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelLeiras);
            Controls.Add(textBoxLeiras);
            Controls.Add(textBoxNev);
            Controls.Add(labelNev);
            Controls.Add(buttonTorles);
            Controls.Add(buttonUjGyermekKategoria);
            Controls.Add(buttonUjTestverKategoria);
            Controls.Add(buttonMentes);
            Controls.Add(treeViewKategoriak);
            Name = "FormTermekKategoria";
            Text = "FormTermekKategoria";
            Load += FormTermekKategoria_Load;
            contextMenuStripKategoria.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewKategoriak;
        private Button buttonMentes;
        private Button buttonUjTestverKategoria;
        private Button buttonUjGyermekKategoria;
        private Button buttonTorles;
        private Label labelNev;
        private TextBox textBoxNev;
        private TextBox textBoxLeiras;
        private Label labelLeiras;
        private ContextMenuStrip contextMenuStripKategoria;
        private ToolStripMenuItem atnevezesToolStripMenuItem;
        private ToolStripMenuItem ujFokategoriaToolStripMenuItem;
        private ToolStripMenuItem ujAlkategoriaToolStripMenuItem;
        private ToolStripMenuItem torlesToolStripMenuItem;
        private ToolStripMenuItem frissitesToolStripMenuItem;
        private ToolStripMenuItem mentesToolStripMenuItem;
    }
}