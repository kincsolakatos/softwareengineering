namespace Cseresznye_IASR1J_App
{
    partial class UserControlLoadUsers
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
            buttonDeleteUser = new Button();
            usersBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxUser
            // 
            textBoxUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUser.Location = new Point(13, 3);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(100, 23);
            textBoxUser.TabIndex = 0;
            textBoxUser.TextChanged += textBoxUser_TextChanged;
            // 
            // listBoxUsers
            // 
            listBoxUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxUsers.DataSource = usersBindingSource;
            listBoxUsers.DisplayMember = "UserName";
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.ItemHeight = 15;
            listBoxUsers.Location = new Point(3, 32);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(120, 94);
            listBoxUsers.TabIndex = 1;
            listBoxUsers.ValueMember = "UserId";
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDeleteUser.Location = new Point(28, 132);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(75, 23);
            buttonDeleteUser.TabIndex = 2;
            buttonDeleteUser.Text = "Delete User";
            buttonDeleteUser.UseVisualStyleBackColor = true;
            buttonDeleteUser.Click += buttonDeleteUser_Click;
            // 
            // usersBindingSource
            // 
            usersBindingSource.DataSource = typeof(Models.Users);
            // 
            // UserControlLoadUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDeleteUser);
            Controls.Add(listBoxUsers);
            Controls.Add(textBoxUser);
            Name = "UserControlLoadUsers";
            Size = new Size(127, 159);
            Load += UserControlLoadUsers_Load;
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUser;
        private ListBox listBoxUsers;
        private Button buttonDeleteUser;
        private BindingSource usersBindingSource;
    }
}
