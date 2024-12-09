namespace CherryPickingZH
{
    partial class AddRide
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
            comboBoxUserId = new ComboBox();
            textBoxStartLocation = new TextBox();
            textBoxEndLocation = new TextBox();
            dateTimePickerRideDate = new DateTimePicker();
            textBoxDistanceKm = new TextBox();
            buttonAdd = new Button();
            usersBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboBoxUserId
            // 
            comboBoxUserId.DataSource = usersBindingSource;
            comboBoxUserId.DisplayMember = "UserName";
            comboBoxUserId.FormattingEnabled = true;
            comboBoxUserId.Location = new Point(12, 12);
            comboBoxUserId.Name = "comboBoxUserId";
            comboBoxUserId.Size = new Size(250, 28);
            comboBoxUserId.TabIndex = 0;
            comboBoxUserId.ValueMember = "UserId";
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
            // dateTimePickerRideDate
            // 
            dateTimePickerRideDate.Location = new Point(12, 112);
            dateTimePickerRideDate.Name = "dateTimePickerRideDate";
            dateTimePickerRideDate.Size = new Size(250, 27);
            dateTimePickerRideDate.TabIndex = 3;
            // 
            // textBoxDistanceKm
            // 
            textBoxDistanceKm.Location = new Point(12, 145);
            textBoxDistanceKm.Name = "textBoxDistanceKm";
            textBoxDistanceKm.Size = new Size(250, 27);
            textBoxDistanceKm.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 178);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // usersBindingSource
            // 
            usersBindingSource.DataSource = typeof(Models.Users);
            // 
            // AddRide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxDistanceKm);
            Controls.Add(dateTimePickerRideDate);
            Controls.Add(textBoxEndLocation);
            Controls.Add(textBoxStartLocation);
            Controls.Add(comboBoxUserId);
            Name = "AddRide";
            Text = "AddRide";
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxUserId;
        private TextBox textBoxStartLocation;
        private TextBox textBoxEndLocation;
        private DateTimePicker dateTimePickerRideDate;
        private TextBox textBoxDistanceKm;
        private Button buttonAdd;
        private BindingSource usersBindingSource;
    }
}