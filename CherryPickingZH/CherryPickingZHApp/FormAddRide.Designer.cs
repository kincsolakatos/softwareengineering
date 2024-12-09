namespace CherryPickingZHApp
{
    partial class FormAddRide
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
            comboBoxUserName = new ComboBox();
            textBoxStartLocation = new TextBox();
            textBoxEndLocation = new TextBox();
            textBoxDistanceKm = new TextBox();
            dateTimePickerRideDate = new DateTimePicker();
            buttonAddRide = new Button();
            usersBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboBoxUserName
            // 
            comboBoxUserName.DataSource = usersBindingSource;
            comboBoxUserName.DisplayMember = "UserName";
            comboBoxUserName.FormattingEnabled = true;
            comboBoxUserName.Location = new Point(12, 12);
            comboBoxUserName.Name = "comboBoxUserName";
            comboBoxUserName.Size = new Size(250, 28);
            comboBoxUserName.TabIndex = 0;
            comboBoxUserName.ValueMember = "UserId";
            // 
            // textBoxStartLocation
            // 
            textBoxStartLocation.Location = new Point(12, 46);
            textBoxStartLocation.Name = "textBoxStartLocation";
            textBoxStartLocation.Size = new Size(250, 27);
            textBoxStartLocation.TabIndex = 1;
            // 
            // textBoxEndLocation
            // 
            textBoxEndLocation.Location = new Point(12, 79);
            textBoxEndLocation.Name = "textBoxEndLocation";
            textBoxEndLocation.Size = new Size(250, 27);
            textBoxEndLocation.TabIndex = 2;
            // 
            // textBoxDistanceKm
            // 
            textBoxDistanceKm.Location = new Point(12, 145);
            textBoxDistanceKm.Name = "textBoxDistanceKm";
            textBoxDistanceKm.Size = new Size(250, 27);
            textBoxDistanceKm.TabIndex = 3;
            // 
            // dateTimePickerRideDate
            // 
            dateTimePickerRideDate.Location = new Point(12, 112);
            dateTimePickerRideDate.Name = "dateTimePickerRideDate";
            dateTimePickerRideDate.Size = new Size(250, 27);
            dateTimePickerRideDate.TabIndex = 4;
            // 
            // buttonAddRide
            // 
            buttonAddRide.Location = new Point(12, 178);
            buttonAddRide.Name = "buttonAddRide";
            buttonAddRide.Size = new Size(250, 29);
            buttonAddRide.TabIndex = 5;
            buttonAddRide.Text = "Add Ride";
            buttonAddRide.UseVisualStyleBackColor = true;
            buttonAddRide.Click += buttonAddRide_Click;
            // 
            // usersBindingSource
            // 
            usersBindingSource.DataSource = typeof(Models.Users);
            // 
            // FormAddRide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 215);
            Controls.Add(buttonAddRide);
            Controls.Add(dateTimePickerRideDate);
            Controls.Add(textBoxDistanceKm);
            Controls.Add(textBoxEndLocation);
            Controls.Add(textBoxStartLocation);
            Controls.Add(comboBoxUserName);
            Name = "FormAddRide";
            Text = "FormAddRide";
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxUserName;
        private TextBox textBoxStartLocation;
        private TextBox textBoxEndLocation;
        private TextBox textBoxDistanceKm;
        private DateTimePicker dateTimePickerRideDate;
        private Button buttonAddRide;
        private BindingSource usersBindingSource;
    }
}