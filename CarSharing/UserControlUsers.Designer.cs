namespace CarSharing
{
    partial class UserControlUsers
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
            textBoxUser = new TextBox();
            listBoxUsers = new ListBox();
            usersBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxUser
            // 
            textBoxUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUser.Location = new Point(3, 3);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(150, 27);
            textBoxUser.TabIndex = 0;
            textBoxUser.TextChanged += textBox1_TextChanged;
            // 
            // listBoxUsers
            // 
            listBoxUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxUsers.DataSource = usersBindingSource;
            listBoxUsers.DisplayMember = "UserName";
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.Location = new Point(3, 36);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(150, 104);
            listBoxUsers.TabIndex = 1;
            listBoxUsers.ValueMember = "UserId";
            // 
            // usersBindingSource
            // 
            usersBindingSource.DataSource = typeof(Models.Users);
            // 
            // UserControlUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBoxUsers);
            Controls.Add(textBoxUser);
            Name = "UserControlUsers";
            Size = new Size(156, 150);
            Load += UserControlUsers_Load;
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUser;
        private ListBox listBoxUsers;
        private BindingSource usersBindingSource;
    }
}
