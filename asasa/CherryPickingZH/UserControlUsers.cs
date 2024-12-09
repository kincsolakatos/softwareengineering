using CherryPickingZH.Data;
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
    public partial class UserControlUsers : UserControl
    {
        CarSharingDbContext context = new CarSharingDbContext();
        public UserControlUsers()
        {
            InitializeComponent();
        }
        private void UserControlUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void textBoxUsers_TextChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void LoadUsers()
        {
            var users = from u in context.Users
                        where u.UserName.Contains(textBoxUsers.Text)
                        select u;
            usersBindingSource.DataSource = users.ToList();
            usersBindingSource.ResetCurrentItem();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Biztosan torolni szeretned?", "Megerosites szukseges", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;
            if (listBoxUsers.SelectedItems.Count == 0) 
            {
                MessageBox.Show("nincs kivalasztva tetel!");
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
