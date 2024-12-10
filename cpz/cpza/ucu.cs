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
    public partial class ucu : UserControl
    {
        CarSharingDbContext c = new CarSharingDbContext();
        public ucu()
        {
            InitializeComponent();
        }

        private void ucu_Load(object sender, EventArgs e)
        {
            lu();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lu();
        }
        private void lu()
        {
            var us = (from u in c.Users
                      where u.UserName.Contains(textBox1.Text)
                      select u).ToList();
            usersBindingSource.DataSource = us;
            listBox1.DataSource = usersBindingSource;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("b?", "m", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                return;
            if (listBox1.SelectedValue == null)
                return;
            var su = (from u in c.Users
                      where u.UserId == (int)listBox1.SelectedValue
                      select u).FirstOrDefault();
            c.Users.Remove(su);
            c.SaveChanges();
            lu();
        }
    }
}
