namespace Rendeles_Forms_IASR1J
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonTermekKategoriakKezelese_Click(object sender, EventArgs e)
        {
            FormTermekKategoria formTermekKategoria = new FormTermekKategoria();
            formTermekKategoria.ShowDialog();
        }
    }
}