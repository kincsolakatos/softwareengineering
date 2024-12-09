using CherryPickingZH.Data;
using CherryPickingZH.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CherryPickingZH
{
    public partial class AddRide : Form
    {
        CarSharingDbContext context = new CarSharingDbContext();
        public AddRide()
        {
            InitializeComponent();
            comboBoxUserId.DataSource = context.Users.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Hozzaadas", "Megerosites", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
                return;
            var newRide = new Rides()
            {
                UserId = comboBoxUserId.SelectedIndex,
                StartLocation = textBoxStartLocation.Text,
                EndLocation = textBoxEndLocation.Text,
                RideDate = dateTimePickerRideDate.Value,
                DistanceKm = decimal.Parse(textBoxDistanceKm.Text),
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
