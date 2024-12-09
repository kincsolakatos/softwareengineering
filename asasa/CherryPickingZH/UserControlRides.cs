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
    public partial class UserControlRides : UserControl
    {
        CarSharingDbContext context = new CarSharingDbContext();
        public UserControlRides()
        {
            InitializeComponent();
            usersBindingSource.DataSource = context.Users.ToList();
            listBox1.DataSource = usersBindingSource;
            listBox1.DisplayMember = "UserName";
        }

        private void UserControlRides_Load(object sender, EventArgs e)
        {
            LoadRides();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRides();
        }
        private void LoadRides()
        {
            var selectedUser = usersBindingSource.Current as Users;
            if (selectedUser == null)
                return;
            var rides = from r in context.Rides
                        where r.UserId == selectedUser.UserId
                        select new RidesDTO
                        {
                            RideId = r.RideId,
                            UserName = r.User.UserName,
                            StartLocation = r.StartLocation,
                            EndLocation = r.EndLocation,
                            RideDate = r.RideDate,
                            DistanceKm = r.DistanceKm
                        };
            dataGridViewRides.DataSource = rides.ToList();
        }
    }
}
