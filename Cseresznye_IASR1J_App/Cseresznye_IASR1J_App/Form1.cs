namespace Cseresznye_IASR1J_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadUsers_Click(object sender, EventArgs e)
        {
            UserControlLoadUsers userControlLoadUsers = new UserControlLoadUsers();
            panelCseresznye.Controls.Clear();
            userControlLoadUsers.Dock = DockStyle.Fill;
            panelCseresznye.Controls.Add(userControlLoadUsers);
        }

        private void buttonLoadRides_Click(object sender, EventArgs e)
        {
            UserControlLoadRides userControlLoadRides = new UserControlLoadRides();
            panelCseresznye.Controls.Clear();
            userControlLoadRides.Dock = DockStyle.Fill;
            panelCseresznye.Controls.Add(userControlLoadRides);
        }

        private void addRideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUser formAddUser = new FormAddUser();
            formAddUser.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Biztosan ki szeretne lepni?", "Megerosites szukseges", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}