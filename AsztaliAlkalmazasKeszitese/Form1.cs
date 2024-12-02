using AsztaliAlkalmazasKeszitese.BookModels;
namespace AsztaliAlkalmazasKeszitese
{
    public partial class Form1 : Form
    {
        FunnyDatabaseContext context = new FunnyDatabaseContext();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bookBindingSource.DataSource = context.Books.ToList();
            dataGridView1.DataSource = bookBindingSource;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }
    }
}
