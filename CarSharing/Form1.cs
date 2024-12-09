namespace CarSharing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            UserControlUsers users = new UserControlUsers();
            users.Dock = DockStyle.Fill;
            panel.Controls.Add(users);
        }

        private void buttonRides_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            UserControlRides rides = new UserControlRides();
            rides.Dock = DockStyle.Fill;
            panel.Controls.Add(rides);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Biztosan ki szeretne lepni?", "Megerosites szukseges", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
