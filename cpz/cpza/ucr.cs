using cpza.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cpza
{
    public partial class ucr : UserControl
    {
        CarSharingDbContext c = new CarSharingDbContext();
        public ucr()
        {
            InitializeComponent();
            usersBindingSource.DataSource = c.Users.ToList();
            listBox1.DataSource = usersBindingSource;
        }

        private void ucr_Load(object sender, EventArgs e)
        {
            lr();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lr();
        }
        private void lr()
        {
            var rs = (from r in c.Rides
                      where r.UserId == (int)listBox1.SelectedValue
                      select new Cr
                      {
                          RideId = r.RideId,
                          UserName = r.User.UserName,
                          StartLocation = r.StartLocation,
                          EndLocation = r.EndLocation,
                          RideDate = r.RideDate,
                          DistanceKm = r.DistanceKm
                      }).ToList();
            dataGridView1.DataSource = rs;
        }
    }
}
