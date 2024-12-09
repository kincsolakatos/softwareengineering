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
    public partial class UserControlUsers : UserControl
    {
        CarSharingDbContext context = new CarSharingDbContext();
        public UserControlUsers()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void UserControlUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void LoadUsers()
        {
            var users = from u in context.Users
                        where u.UserName.Contains(textBoxUser.Text)
                        select u;
            usersBindingSource.DataSource = users.ToList();
            listBoxUsers.DataSource = usersBindingSource;
        }
    }
}
