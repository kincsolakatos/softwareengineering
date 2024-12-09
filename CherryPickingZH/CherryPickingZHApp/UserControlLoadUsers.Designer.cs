namespace CherryPickingZHApp
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
            usersBindingSource = new BindingSource(components);
            buttonDeleteUser = new Button();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxUser
            // 
            textBoxUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUser.Location = new Point(3, 3);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(149, 27);
            textBoxUser.TabIndex = 0;
            textBoxUser.TextChanged += textBoxUser_TextChanged;
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
            // buttonDeleteUser
            // 
            buttonDeleteUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDeleteUser.Location = new Point(3, 146);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(149, 29);
            buttonDeleteUser.TabIndex = 2;
            buttonDeleteUser.Text = "Delete User";
            buttonDeleteUser.UseVisualStyleBackColor = true;
            buttonDeleteUser.Click += buttonDeleteUser_Click;
            // 
            // UserControlLoadUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDeleteUser);
            Controls.Add(listBoxUsers);
            Controls.Add(textBoxUser);
            Name = "UserControlLoadUsers";
            Size = new Size(155, 179);
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
