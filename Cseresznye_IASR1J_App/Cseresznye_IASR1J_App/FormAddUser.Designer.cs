namespace Cseresznye_IASR1J_App
{
    partial class FormAddUser
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            comboBoxUsers = new ComboBox();
            textBoxStartLocation = new TextBox();
            textBoxEnLocation = new TextBox();
            dateTimePickerRideDate = new DateTimePicker();
            textBoxDistanceKm = new TextBox();
            buttonAddRide = new Button();
            usersBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboBoxUsers
            // 
            comboBoxUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxUsers.DataSource = usersBindingSource;
            comboBoxUsers.DisplayMember = "UserName";
            comboBoxUsers.FormattingEnabled = true;
            comboBoxUsers.Location = new Point(47, 12);
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(121, 23);
            comboBoxUsers.TabIndex = 0;
            comboBoxUsers.ValueMember = "UserId";
            // 
            // textBoxStartLocation
            // 
            textBoxStartLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxStartLocation.Location = new Point(56, 41);
            textBoxStartLocation.Name = "textBoxStartLocation";
            textBoxStartLocation.Size = new Size(100, 23);
            textBoxStartLocation.TabIndex = 1;
            // 
            // textBoxEnLocation
            // 
            textBoxEnLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEnLocation.Location = new Point(56, 70);
            textBoxEnLocation.Name = "textBoxEnLocation";
            textBoxEnLocation.Size = new Size(100, 23);
            textBoxEnLocation.TabIndex = 2;
            // 
            // dateTimePickerRideDate
            // 
            dateTimePickerRideDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerRideDate.Location = new Point(12, 99);
            dateTimePickerRideDate.Name = "dateTimePickerRideDate";
            dateTimePickerRideDate.Size = new Size(200, 23);
            dateTimePickerRideDate.TabIndex = 3;
            // 
            // textBoxDistanceKm
            // 
            textBoxDistanceKm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDistanceKm.Location = new Point(56, 128);
            textBoxDistanceKm.Name = "textBoxDistanceKm";
            textBoxDistanceKm.Size = new Size(100, 23);
            textBoxDistanceKm.TabIndex = 4;
            // 
            // buttonAddRide
            // 
            buttonAddRide.Location = new Point(67, 157);
            buttonAddRide.Name = "buttonAddRide";
            buttonAddRide.Size = new Size(75, 23);
            buttonAddRide.TabIndex = 5;
            buttonAddRide.Text = "Add Ride";
            buttonAddRide.UseVisualStyleBackColor = true;
            buttonAddRide.Click += buttonAddRide_Click;
            // 
            // usersBindingSource
            // 
            usersBindingSource.DataSource = typeof(Models.Users);
            // 
            // FormAddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(223, 190);
            Controls.Add(buttonAddRide);
            Controls.Add(textBoxDistanceKm);
            Controls.Add(dateTimePickerRideDate);
            Controls.Add(textBoxEnLocation);
            Controls.Add(textBoxStartLocation);
            Controls.Add(comboBoxUsers);
            Name = "FormAddUser";
            Text = "FormAddUser";
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxUsers;
        private TextBox textBoxStartLocation;
        private TextBox textBoxEnLocation;
        private DateTimePicker dateTimePickerRideDate;
        private TextBox textBoxDistanceKm;
        private Button buttonAddRide;
        private BindingSource usersBindingSource;
    }
}