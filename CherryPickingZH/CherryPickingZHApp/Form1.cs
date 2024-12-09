namespace CherryPickingZHApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel.ContextMenuStrip = contextMenuStripAddRide;
        }
        private void buttonLoadUsers_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            UserControlLoadUsers userControlLoadUsers = new UserControlLoadUsers();
            userControlLoadUsers.Dock = DockStyle.Fill;
            panel.Controls.Add(userControlLoadUsers);
        }
        private void buttonLoadRides_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            UserControlLoadRides userControlLoadRides = new UserControlLoadRides();
            userControlLoadRides.Dock = DockStyle.Fill;
            panel.Controls.Add(userControlLoadRides);
        }

        private void addRideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddRide formAddRide = new FormAddRide();
            formAddRide.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Biztosan ki szeretnel lepni?", "Megerosites szukseges", MessageBoxButtons.YesNo);
            if (result == DialogResult. No)
                e.Cancel = true;
        }
    }
}
