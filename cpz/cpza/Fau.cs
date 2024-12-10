using cpza.Data;
using cpza.Models;
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

namespace cpza
{
    public partial class Fau : Form
    {
        CarSharingDbContext c = new CarSharingDbContext();
        public Fau()
        {
            InitializeComponent();
            usersBindingSource.DataSource = c.Users.ToList();
            comboBox1.DataSource = usersBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("b?", "m", MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
                return;
            if (comboBox1.SelectedValue == null)
                return;
            var rs = new Rides
            {
                UserId = (int)comboBox1.SelectedValue,
                StartLocation = textBox1.Text,
                EndLocation = textBox2.Text,
                RideDate = dateTimePicker1.Value,
                DistanceKm = decimal.Parse(textBox3.Text)
            };
            c.Rides.Add(rs);
            c.SaveChanges();
        }
    }
}
