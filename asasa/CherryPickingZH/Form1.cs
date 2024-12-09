namespace CherryPickingZH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel.ContextMenuStrip = contextMenuStrip;
        }
        private void buttonUsers_Click(object sender, EventArgs e)
        {
            UserControlUsers userControlUsers = new UserControlUsers();
            panel.Controls.Clear();
            userControlUsers.Dock = DockStyle.Fill;
            panel.Controls.Add(userControlUsers);
        }
        private void buttonRides_Click(object sender, EventArgs e)
        {
            UserControlRides userControlRides = new UserControlRides();
            panel.Controls.Clear();
            userControlRides.Dock = DockStyle.Fill;
            panel.Controls.Add(userControlRides);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Biztosan ki szeretne lépni?", "Kilépés megerõsítése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void addRideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRide addRide = new AddRide();
            addRide.ShowDialog();
        }
    }
}
