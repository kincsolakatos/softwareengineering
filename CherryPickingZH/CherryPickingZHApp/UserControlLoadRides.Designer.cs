namespace CherryPickingZHApp
{
    partial class UserControlLoadRides
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBoxUsers = new ListBox();
            usersBindingSource = new BindingSource(components);
            dataGridViewRides = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRides).BeginInit();
            SuspendLayout();
            // 
            // listBoxUsers
            // 
            listBoxUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxUsers.DataSource = usersBindingSource;
            listBoxUsers.DisplayMember = "UserName";
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.Location = new Point(3, 3);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(150, 184);
            listBoxUsers.TabIndex = 0;
            listBoxUsers.ValueMember = "UserId";
            listBoxUsers.SelectedIndexChanged += listBoxUsers_SelectedIndexChanged;
            // 
            // usersBindingSource
            // 
            usersBindingSource.DataSource = typeof(Models.Users);
            // 
            // dataGridViewRides
            // 
            dataGridViewRides.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRides.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRides.Location = new Point(159, 3);
            dataGridViewRides.Name = "dataGridViewRides";
            dataGridViewRides.RowHeadersWidth = 51;
            dataGridViewRides.Size = new Size(300, 188);
            dataGridViewRides.TabIndex = 1;
            // 
            // UserControlLoadRides
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewRides);
            Controls.Add(listBoxUsers);
            Name = "UserControlLoadRides";
            Size = new Size(463, 195);
            Load += UserControlLoadRides_Load;
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRides).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxUsers;
        private BindingSource usersBindingSource;
        private DataGridView dataGridViewRides;
    }
}
