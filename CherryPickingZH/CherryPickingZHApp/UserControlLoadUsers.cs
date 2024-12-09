using CherryPickingZHApp.Data;
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
    public partial class UserControlLoadUsers : UserControl
    {
        CarSharingDbContext context = new CarSharingDbContext();
        public UserControlLoadUsers()
        {
            InitializeComponent();
            listBoxUsers.DisplayMember = "UserName";
            listBoxUsers.ValueMember = "UserId";
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
            var users = (from u in context.Users
                         where u.UserName.Contains(textBoxUser.Text)
                         select u).ToList();
            usersBindingSource.DataSource = users;
            listBoxUsers.DataSource = usersBindingSource;
        }
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Biztosan torloni szeretne?", "megerosites szukseges", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;
            if (listBoxUsers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nincs kivalasztva felhasznalo");
                return;
            }
            var selectedUser = (from u in context.Users
                                where u.UserId == (int)listBoxUsers.SelectedValue
                                select u).FirstOrDefault();
            context.Users.Remove(selectedUser);
            context.SaveChanges();
            LoadUsers();
        }

        
    }
}
