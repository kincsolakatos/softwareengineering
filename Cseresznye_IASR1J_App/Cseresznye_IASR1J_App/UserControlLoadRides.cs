using Cseresznye_IASR1J_App.Data;
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
    public partial class UserControlLoadRides : UserControl
    {
        CarSharingDbContext carSharingDbContext = new CarSharingDbContext();
        public UserControlLoadRides()
        {
            InitializeComponent();
            usersBindingSource.DataSource = carSharingDbContext.Users.ToList();
            listBoxUsers.DataSource = usersBindingSource;
        }

        private void UserControlLoadRides_Load(object sender, EventArgs e)
        {
            LoadRides();
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRides();
        }
        private void LoadRides()
        {
            var rides = (from r in carSharingDbContext.Rides
                         where r.UserId == (int)listBoxUsers.SelectedValue
                         select new ClassRidesDTO
                         {
                             RideId = r.RideId,
                             UserName = r.User.UserName,
                             StartLocation = r.StartLocation,
                             EndLocation = r.EndLocation,
                             RideDate = r.RideDate,
                             DistanceKm = r.DistanceKm
                         }).ToList();
            dataGridViewRides.DataSource = rides;
        }
    }
}
