namespace CherryPickingZH
{
    partial class UserControlRides
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
            dataGridViewRides = new DataGridView();
            listBox1 = new ListBox();
            usersBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRides).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRides
            // 
            dataGridViewRides.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRides.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRides.Location = new Point(159, 3);
            dataGridViewRides.Name = "dataGridViewRides";
            dataGridViewRides.RowHeadersWidth = 51;
            dataGridViewRides.Size = new Size(659, 490);
            dataGridViewRides.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.DataSource = usersBindingSource;
            listBox1.DisplayMember = "UserName";
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 484);
            listBox1.TabIndex = 1;
            listBox1.ValueMember = "UserId";
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // usersBindingSource
            // 
            usersBindingSource.DataSource = typeof(Models.Users);
            // 
            // UserControlRides
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox1);
            Controls.Add(dataGridViewRides);
            Name = "UserControlRides";
            Size = new Size(821, 496);
            Load += UserControlRides_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRides).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewRides;
        private ListBox listBox1;
        private BindingSource usersBindingSource;
    }
}
