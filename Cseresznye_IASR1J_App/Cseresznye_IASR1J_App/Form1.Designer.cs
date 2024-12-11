namespace Cseresznye_IASR1J_App
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
            panelCseresznye = new Panel();
            buttonLoadUsers = new Button();
            buttonLoadRides = new Button();
            contextMenuStripCseresznye = new ContextMenuStrip(components);
            addRideToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStripCseresznye.SuspendLayout();
            SuspendLayout();
            // 
            // panelCseresznye
            // 
            panelCseresznye.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCseresznye.ContextMenuStrip = contextMenuStripCseresznye;
            panelCseresznye.Location = new Point(93, 12);
            panelCseresznye.Name = "panelCseresznye";
            panelCseresznye.Size = new Size(695, 426);
            panelCseresznye.TabIndex = 0;
            // 
            // buttonLoadUsers
            // 
            buttonLoadUsers.Location = new Point(12, 185);
            buttonLoadUsers.Name = "buttonLoadUsers";
            buttonLoadUsers.Size = new Size(75, 23);
            buttonLoadUsers.TabIndex = 1;
            buttonLoadUsers.Text = "Load Users";
            buttonLoadUsers.UseVisualStyleBackColor = true;
            buttonLoadUsers.Click += buttonLoadUsers_Click;
            // 
            // buttonLoadRides
            // 
            buttonLoadRides.Location = new Point(12, 214);
            buttonLoadRides.Name = "buttonLoadRides";
            buttonLoadRides.Size = new Size(75, 23);
            buttonLoadRides.TabIndex = 2;
            buttonLoadRides.Text = "Load Rides";
            buttonLoadRides.UseVisualStyleBackColor = true;
            buttonLoadRides.Click += buttonLoadRides_Click;
            // 
            // contextMenuStripCseresznye
            // 
            contextMenuStripCseresznye.Items.AddRange(new ToolStripItem[] { addRideToolStripMenuItem });
            contextMenuStripCseresznye.Name = "contextMenuStripCseresznye";
            contextMenuStripCseresznye.Size = new Size(123, 26);
            // 
            // addRideToolStripMenuItem
            // 
            addRideToolStripMenuItem.Name = "addRideToolStripMenuItem";
            addRideToolStripMenuItem.Size = new Size(180, 22);
            addRideToolStripMenuItem.Text = "Add Ride";
            addRideToolStripMenuItem.Click += addRideToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLoadRides);
            Controls.Add(buttonLoadUsers);
            Controls.Add(panelCseresznye);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            contextMenuStripCseresznye.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCseresznye;
        private ContextMenuStrip contextMenuStripCseresznye;
        private ToolStripMenuItem addRideToolStripMenuItem;
        private Button buttonLoadUsers;
        private Button buttonLoadRides;
    }
}