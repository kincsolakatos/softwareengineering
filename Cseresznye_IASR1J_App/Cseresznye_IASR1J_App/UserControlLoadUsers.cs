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
    public partial class UserControlLoadUsers : UserControl
    {
        CarSharingDbContext carSharingDbContext = new CarSharingDbContext();
        public UserControlLoadUsers()
        {
            InitializeComponent();
        }
        private void UserControlLoadUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void LoadUsers()
        {
            var users = (from u in carSharingDbContext.Users
                         where u.UserName.Contains(textBoxUser.Text)
                         select u).ToList();
            usersBindingSource.DataSource = users;
            listBoxUsers.DataSource = usersBindingSource;
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Biztosan szeretne torolni?", "Megerosites szukseges", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            if (listBoxUsers.SelectedValue == null)
                return;
            var selectedUser = (from u in carSharingDbContext.Users
                                where u.UserId == (int)listBoxUsers.SelectedValue
                                select u).FirstOrDefault();
            if (selectedUser == null)
                return;
            carSharingDbContext.Users.Remove(selectedUser);
            carSharingDbContext.SaveChanges();
            LoadUsers();
        }
    }
}
