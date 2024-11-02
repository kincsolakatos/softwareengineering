namespace Rendeles_Forms_IASR1J
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
            buttonTermekKategoriakKezelese = new Button();
            buttonUgyfelLista = new Button();
            buttonRendelesek = new Button();
            SuspendLayout();
            // 
            // buttonTermekKategoriakKezelese
            // 
            buttonTermekKategoriakKezelese.Location = new Point(12, 12);
            buttonTermekKategoriakKezelese.Name = "buttonTermekKategoriakKezelese";
            buttonTermekKategoriakKezelese.Size = new Size(160, 23);
            buttonTermekKategoriakKezelese.TabIndex = 0;
            buttonTermekKategoriakKezelese.Text = "Termek Kategoriak Kezelese";
            buttonTermekKategoriakKezelese.UseVisualStyleBackColor = true;
            buttonTermekKategoriakKezelese.Click += buttonTermekKategoriakKezelese_Click;
            // 
            // buttonUgyfelLista
            // 
            buttonUgyfelLista.Location = new Point(178, 12);
            buttonUgyfelLista.Name = "buttonUgyfelLista";
            buttonUgyfelLista.Size = new Size(76, 23);
            buttonUgyfelLista.TabIndex = 1;
            buttonUgyfelLista.Text = "Ugyfel Lista";
            buttonUgyfelLista.UseVisualStyleBackColor = true;
            buttonUgyfelLista.Click += buttonUgyfelLista_Click;
            // 
            // buttonRendelesek
            // 
            buttonRendelesek.Location = new Point(260, 12);
            buttonRendelesek.Name = "buttonRendelesek";
            buttonRendelesek.Size = new Size(75, 23);
            buttonRendelesek.TabIndex = 2;
            buttonRendelesek.Text = "Rendelesek";
            buttonRendelesek.UseVisualStyleBackColor = true;
            buttonRendelesek.Click += buttonRendelesek_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRendelesek);
            Controls.Add(buttonUgyfelLista);
            Controls.Add(buttonTermekKategoriakKezelese);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonTermekKategoriakKezelese;
        private Button buttonUgyfelLista;
        private Button buttonRendelesek;
    }
}