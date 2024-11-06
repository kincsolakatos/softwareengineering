namespace WinFormsAppZh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 userControl1 = new UserControl1();
            userControl1.Dock = DockStyle.Fill;
            panel1.Controls.Add(userControl1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 userControl2 = new UserControl2();
            userControl2.Dock = DockStyle.Fill;
            panel1.Controls.Add(userControl2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 userControl3 = new UserControl3();
            userControl3.Dock = DockStyle.Fill;
            panel1.Controls.Add(userControl3);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan ki szeretne lépni?", "Megerõsítés", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;

            base.OnFormClosing(e);
        }
    }
}