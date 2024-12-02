using AsztaliAlkalmazasKeszitese.BookModels;

namespace AsztaliAlkalmazasKeszitese
{
    public partial class Form1 : Form
    {
        FunnyDatabaseContext _context = new FunnyDatabaseContext();
        public Form1()
        {
            InitializeComponent();
            bookBindingSource.DataSource = _context.Books.ToList();
            dataGridView1.DataSource = bookBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
        }
    }
}
