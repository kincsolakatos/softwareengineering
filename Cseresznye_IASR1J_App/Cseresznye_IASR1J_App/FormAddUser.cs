using Cseresznye_IASR1J_App.Data;
using Cseresznye_IASR1J_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cseresznye_IASR1J_App
{
    public partial class FormAddUser : Form
    {
        CarSharingDbContext carSharingDbContext = new CarSharingDbContext();
        public FormAddUser()
        {
            InitializeComponent();
            usersBindingSource.DataSource = carSharingDbContext.Users.ToList();
            comboBoxUsers.DataSource = usersBindingSource;
        }

        private void buttonAddRide_Click(object sender, EventArgs e)
        {
            var newRide = new Rides
            {
                UserId = (int)comboBoxUsers.SelectedValue,
                StartLocation = textBoxStartLocation.Text,
                EndLocation = textBoxEnLocation.Text,
                RideDate = dateTimePickerRideDate.Value,
                DistanceKm = decimal.Parse(textBoxDistanceKm.Text)
            };
            carSharingDbContext.Add(newRide);
            try
            {
                carSharingDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
