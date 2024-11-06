using System.Windows.Forms;

namespace Rendeles_Forms_IASR1J
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonTermekKategoriakKezelese_Click(object sender, EventArgs e)
        {
            using (var form = new FormTermekKategoria())
            {
                form.ShowDialog();
            }
        }
        private void buttonUgyfelLista_Click(object sender, EventArgs e)
        {
            using (var form = new FormUgyfelKezelo())
            {
                form.ShowDialog();
            }
        }
        private void buttonRendelesek_Click(object sender, EventArgs e)
        {
            using (var form = new FormRendeles())
            {
                form.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}