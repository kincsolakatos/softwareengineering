namespace CherryPickingZHApp
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
            buttonLoadUsers = new Button();
            buttonLoadRides = new Button();
            panel = new Panel();
            contextMenuStripAddRide = new ContextMenuStrip(components);
            addRideToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStripAddRide.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLoadUsers
            // 
            buttonLoadUsers.Location = new Point(12, 12);
            buttonLoadUsers.Name = "buttonLoadUsers";
            buttonLoadUsers.Size = new Size(94, 29);
            buttonLoadUsers.TabIndex = 0;
            buttonLoadUsers.Text = "Load Users";
            buttonLoadUsers.UseVisualStyleBackColor = true;
            buttonLoadUsers.Click += buttonLoadUsers_Click;
            // 
            // buttonLoadRides
            // 
            buttonLoadRides.Location = new Point(12, 47);
            buttonLoadRides.Name = "buttonLoadRides";
            buttonLoadRides.Size = new Size(94, 29);
            buttonLoadRides.TabIndex = 1;
            buttonLoadRides.Text = "Load Rides";
            buttonLoadRides.UseVisualStyleBackColor = true;
            buttonLoadRides.Click += buttonLoadRides_Click;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.Location = new Point(112, 12);
            panel.Name = "panel";
            panel.Size = new Size(676, 426);
            panel.TabIndex = 2;
            // 
            // contextMenuStripAddRide
            // 
            contextMenuStripAddRide.ImageScalingSize = new Size(20, 20);
            contextMenuStripAddRide.Items.AddRange(new ToolStripItem[] { addRideToolStripMenuItem });
            contextMenuStripAddRide.Name = "contextMenuStripAddRide";
            contextMenuStripAddRide.Size = new Size(141, 28);
            // 
            // addRideToolStripMenuItem
            // 
            addRideToolStripMenuItem.Name = "addRideToolStripMenuItem";
            addRideToolStripMenuItem.Size = new Size(140, 24);
            addRideToolStripMenuItem.Text = "Add Ride";
            addRideToolStripMenuItem.Click += addRideToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel);
            Controls.Add(buttonLoadRides);
            Controls.Add(buttonLoadUsers);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            contextMenuStripAddRide.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLoadUsers;
        private Button buttonLoadRides;
        private Panel panel;
        private ContextMenuStrip contextMenuStripAddRide;
        private ToolStripMenuItem addRideToolStripMenuItem;
    }
}
