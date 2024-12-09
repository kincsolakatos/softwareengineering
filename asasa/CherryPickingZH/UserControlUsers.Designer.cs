namespace CherryPickingZH
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
            textBoxUsers = new TextBox();
            listBoxUsers = new ListBox();
            usersBindingSource = new BindingSource(components);
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBoxUsers
            // 
            textBoxUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsers.Location = new Point(3, 3);
            textBoxUsers.Name = "textBoxUsers";
            textBoxUsers.Size = new Size(150, 27);
            textBoxUsers.TabIndex = 1;
            textBoxUsers.TextChanged += textBoxUsers_TextChanged;
            // 
            // listBoxUsers
            // 
            listBoxUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxUsers.DataBindings.Add(new Binding("DataContext", usersBindingSource, "UserName", true));
            listBoxUsers.DataBindings.Add(new Binding("SelectedIndex", usersBindingSource, "UserName", true));
            listBoxUsers.DataBindings.Add(new Binding("SelectedItem", usersBindingSource, "UserName", true));
            listBoxUsers.DataSource = usersBindingSource;
            listBoxUsers.DisplayMember = "UserName";
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.Location = new Point(3, 36);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(150, 424);
            listBoxUsers.TabIndex = 2;
            listBoxUsers.ValueMember = "UserId";
            // 
            // usersBindingSource
            // 
            usersBindingSource.DataSource = typeof(Models.Users);
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDelete.Location = new Point(3, 462);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 29);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // UserControlUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDelete);
            Controls.Add(listBoxUsers);
            Controls.Add(textBoxUsers);
            Name = "UserControlUsers";
            Size = new Size(158, 494);
            Load += UserControlUsers_Load;
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxUsers;
        private ListBox listBoxUsers;
        private BindingSource usersBindingSource;
        private Button buttonDelete;
    }
}
