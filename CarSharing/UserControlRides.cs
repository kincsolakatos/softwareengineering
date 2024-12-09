using CarSharing.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSharing
{
    public partial class UserControlRides : UserControl
    {
        CarSharingDbContext context = new CarSharingDbContext();
        public UserControlRides()
        {
            InitializeComponent();
            ridesBindingSource.DataSource = context.Rides.ToList();
            dataGridViewRides.DataSource = ridesBindingSource;
        }

        private void UserControlRides_Load(object sender, EventArgs e)
        {

        }
    }
}
