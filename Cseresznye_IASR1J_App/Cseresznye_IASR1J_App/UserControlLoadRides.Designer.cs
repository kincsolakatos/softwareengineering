namespace Cseresznye_IASR1J_App
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
            dataGridViewRides = new DataGridView();
            usersBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRides).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // listBoxUsers
            // 
            listBoxUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxUsers.DataSource = usersBindingSource;
            listBoxUsers.DisplayMember = "UserName";
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.ItemHeight = 15;
            listBoxUsers.Location = new Point(3, 32);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(120, 94);
            listBoxUsers.TabIndex = 0;
            listBoxUsers.ValueMember = "UserId";
            listBoxUsers.SelectedIndexChanged += listBoxUsers_SelectedIndexChanged;
            // 
            // dataGridViewRides
            // 
            dataGridViewRides.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRides.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRides.Location = new Point(129, 3);
            dataGridViewRides.Name = "dataGridViewRides";
            dataGridViewRides.RowTemplate.Height = 25;
            dataGridViewRides.Size = new Size(240, 150);
            dataGridViewRides.TabIndex = 1;
            // 
            // usersBindingSource
            // 
            usersBindingSource.DataSource = typeof(Models.Users);
            // 
            // UserControlLoadRides
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewRides);
            Controls.Add(listBoxUsers);
            Name = "UserControlLoadRides";
            Size = new Size(373, 158);
            Load += UserControlLoadRides_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRides).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxUsers;
        private BindingSource usersBindingSource;
        private DataGridView dataGridViewRides;
    }
}
