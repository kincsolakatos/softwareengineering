namespace CarSharing
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
            ridesBindingSource = new BindingSource(components);
            rideIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startLocationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endLocationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rideDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            distanceKmDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRides).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ridesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRides
            // 
            dataGridViewRides.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRides.AutoGenerateColumns = false;
            dataGridViewRides.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRides.Columns.AddRange(new DataGridViewColumn[] { rideIdDataGridViewTextBoxColumn, userIdDataGridViewTextBoxColumn, startLocationDataGridViewTextBoxColumn, endLocationDataGridViewTextBoxColumn, rideDateDataGridViewTextBoxColumn, distanceKmDataGridViewTextBoxColumn, userDataGridViewTextBoxColumn });
            dataGridViewRides.DataSource = ridesBindingSource;
            dataGridViewRides.Location = new Point(3, 3);
            dataGridViewRides.Name = "dataGridViewRides";
            dataGridViewRides.RowHeadersWidth = 51;
            dataGridViewRides.Size = new Size(300, 188);
            dataGridViewRides.TabIndex = 0;
            // 
            // ridesBindingSource
            // 
            ridesBindingSource.DataSource = typeof(Models.Rides);
            // 
            // rideIdDataGridViewTextBoxColumn
            // 
            rideIdDataGridViewTextBoxColumn.DataPropertyName = "RideId";
            rideIdDataGridViewTextBoxColumn.HeaderText = "RideId";
            rideIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            rideIdDataGridViewTextBoxColumn.Name = "rideIdDataGridViewTextBoxColumn";
            rideIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // startLocationDataGridViewTextBoxColumn
            // 
            startLocationDataGridViewTextBoxColumn.DataPropertyName = "StartLocation";
            startLocationDataGridViewTextBoxColumn.HeaderText = "StartLocation";
            startLocationDataGridViewTextBoxColumn.MinimumWidth = 6;
            startLocationDataGridViewTextBoxColumn.Name = "startLocationDataGridViewTextBoxColumn";
            startLocationDataGridViewTextBoxColumn.Width = 125;
            // 
            // endLocationDataGridViewTextBoxColumn
            // 
            endLocationDataGridViewTextBoxColumn.DataPropertyName = "EndLocation";
            endLocationDataGridViewTextBoxColumn.HeaderText = "EndLocation";
            endLocationDataGridViewTextBoxColumn.MinimumWidth = 6;
            endLocationDataGridViewTextBoxColumn.Name = "endLocationDataGridViewTextBoxColumn";
            endLocationDataGridViewTextBoxColumn.Width = 125;
            // 
            // rideDateDataGridViewTextBoxColumn
            // 
            rideDateDataGridViewTextBoxColumn.DataPropertyName = "RideDate";
            rideDateDataGridViewTextBoxColumn.HeaderText = "RideDate";
            rideDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            rideDateDataGridViewTextBoxColumn.Name = "rideDateDataGridViewTextBoxColumn";
            rideDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // distanceKmDataGridViewTextBoxColumn
            // 
            distanceKmDataGridViewTextBoxColumn.DataPropertyName = "DistanceKm";
            distanceKmDataGridViewTextBoxColumn.HeaderText = "DistanceKm";
            distanceKmDataGridViewTextBoxColumn.MinimumWidth = 6;
            distanceKmDataGridViewTextBoxColumn.Name = "distanceKmDataGridViewTextBoxColumn";
            distanceKmDataGridViewTextBoxColumn.Width = 125;
            // 
            // userDataGridViewTextBoxColumn
            // 
            userDataGridViewTextBoxColumn.DataPropertyName = "User";
            userDataGridViewTextBoxColumn.HeaderText = "User";
            userDataGridViewTextBoxColumn.MinimumWidth = 6;
            userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            userDataGridViewTextBoxColumn.Width = 125;
            // 
            // UserControlRides
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewRides);
            Name = "UserControlRides";
            Size = new Size(308, 192);
            Load += UserControlRides_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRides).EndInit();
            ((System.ComponentModel.ISupportInitialize)ridesBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewRides;
        private DataGridViewTextBoxColumn rideIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startLocationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endLocationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rideDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn distanceKmDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private BindingSource ridesBindingSource;
    }
}
