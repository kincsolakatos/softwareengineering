namespace cpza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucu ucu = new ucu();
            panel1.Controls.Clear();
            ucu.Dock = DockStyle.Fill;
            panel1.Controls.Add(ucu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucr ucr = new ucr();
            panel1.Controls.Clear();
            ucr.Dock = DockStyle.Fill;
            panel1.Controls.Add(ucr);
        }

        private void auToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fau fau = new Fau();
            fau.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var r = MessageBox.Show("b?", "m", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
