using CherryPickingZHApp.Data;
using CherryPickingZHApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CherryPickingZHApp
{
    public partial class FormAddRide : Form
    {
        CarSharingDbContext context = new CarSharingDbContext();
        public FormAddRide()
        {
            InitializeComponent();
            comboBoxUserName.DataSource = context.Users.ToList();
        }

        private void buttonAddRide_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Biztsoan hozzaadod?", "megerosites szukseges", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;
            var newRide = new Rides()
            {
                UserId = (int)comboBoxUserName.SelectedValue,
                StartLocation = textBoxStartLocation.Text,
                EndLocation = textBoxEndLocation.Text,
                RideDate = dateTimePickerRideDate.Value,
                DistanceKm = decimal.Parse(textBoxDistanceKm.Text)
            };
            context.Rides.Add(newRide);
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
