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
            buttonTermekkategoriakKezelese = new Button();
            SuspendLayout();
            // 
            // buttonTermekkategoriakKezelese
            // 
            buttonTermekkategoriakKezelese.Location = new Point(12, 12);
            buttonTermekkategoriakKezelese.Name = "buttonTermekkategoriakKezelese";
            buttonTermekkategoriakKezelese.Size = new Size(159, 23);
            buttonTermekkategoriakKezelese.TabIndex = 0;
            buttonTermekkategoriakKezelese.Text = "Termekkategoriak kezelese";
            buttonTermekkategoriakKezelese.UseVisualStyleBackColor = true;
            buttonTermekkategoriakKezelese.Click += buttonTermekkategoriakKezelese_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonTermekkategoriakKezelese);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonTermekkategoriakKezelese;
    }
}
