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
            contextMenuStripCseresznye = new ContextMenuStrip(components);
            addRideToolStripMenuItem = new ToolStripMenuItem();
            buttonLoadUsers = new Button();
            buttonLoadRides = new Button();
            contextMenuStripCseresznye.SuspendLayout();
            SuspendLayout();
            // 
            // panelCseresznye
            // 
            panelCseresznye.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCseresznye.ContextMenuStrip = contextMenuStripCseresznye;
            panelCseresznye.Location = new Point(128, 16);
            panelCseresznye.Margin = new Padding(3, 4, 3, 4);
            panelCseresznye.Name = "panelCseresznye";
            panelCseresznye.Size = new Size(772, 568);
            panelCseresznye.TabIndex = 0;
            // 
            // contextMenuStripCseresznye
            // 
            contextMenuStripCseresznye.ImageScalingSize = new Size(20, 20);
            contextMenuStripCseresznye.Items.AddRange(new ToolStripItem[] { addRideToolStripMenuItem });
            contextMenuStripCseresznye.Name = "contextMenuStripCseresznye";
            contextMenuStripCseresznye.Size = new Size(141, 28);
            // 
            // addRideToolStripMenuItem
            // 
            addRideToolStripMenuItem.Name = "addRideToolStripMenuItem";
            addRideToolStripMenuItem.Size = new Size(140, 24);
            addRideToolStripMenuItem.Text = "Add Ride";
            addRideToolStripMenuItem.Click += addRideToolStripMenuItem_Click;
            // 
            // buttonLoadUsers
            // 
            buttonLoadUsers.Location = new Point(14, 247);
            buttonLoadUsers.Margin = new Padding(3, 4, 3, 4);
            buttonLoadUsers.Name = "buttonLoadUsers";
            buttonLoadUsers.Size = new Size(108, 31);
            buttonLoadUsers.TabIndex = 1;
            buttonLoadUsers.Text = "Load Users";
            buttonLoadUsers.UseVisualStyleBackColor = true;
            buttonLoadUsers.Click += buttonLoadUsers_Click;
            // 
            // buttonLoadRides
            // 
            buttonLoadRides.Location = new Point(14, 285);
            buttonLoadRides.Margin = new Padding(3, 4, 3, 4);
            buttonLoadRides.Name = "buttonLoadRides";
            buttonLoadRides.Size = new Size(108, 31);
            buttonLoadRides.TabIndex = 2;
            buttonLoadRides.Text = "Load Rides";
            buttonLoadRides.UseVisualStyleBackColor = true;
            buttonLoadRides.Click += buttonLoadRides_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonLoadRides);
            Controls.Add(buttonLoadUsers);
            Controls.Add(panelCseresznye);
            Margin = new Padding(3, 4, 3, 4);
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