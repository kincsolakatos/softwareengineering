namespace CherryPickingZH
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
            buttonUsers = new Button();
            buttonRides = new Button();
            panel = new Panel();
            contextMenuStrip = new ContextMenuStrip(components);
            addRideToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // buttonUsers
            // 
            buttonUsers.Location = new Point(12, 12);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(94, 29);
            buttonUsers.TabIndex = 0;
            buttonUsers.Text = "Load Users ";
            buttonUsers.UseVisualStyleBackColor = true;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // buttonRides
            // 
            buttonRides.Location = new Point(12, 47);
            buttonRides.Name = "buttonRides";
            buttonRides.Size = new Size(94, 29);
            buttonRides.TabIndex = 1;
            buttonRides.Text = "Load Rides";
            buttonRides.UseVisualStyleBackColor = true;
            buttonRides.Click += buttonRides_Click;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.Location = new Point(112, 12);
            panel.Name = "panel";
            panel.Size = new Size(676, 426);
            panel.TabIndex = 2;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { addRideToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(211, 56);
            // 
            // addRideToolStripMenuItem
            // 
            addRideToolStripMenuItem.Name = "addRideToolStripMenuItem";
            addRideToolStripMenuItem.Size = new Size(210, 24);
            addRideToolStripMenuItem.Text = "Add Ride";
            addRideToolStripMenuItem.Click += addRideToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel);
            Controls.Add(buttonRides);
            Controls.Add(buttonUsers);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonUsers;
        private Button buttonRides;
        private Panel panel;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem addRideToolStripMenuItem;
    }
}
