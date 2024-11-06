using WinFormsAppZh.Data;
using WinFormsAppZh.Models;

namespace WinFormsAppZh
{
    public partial class UserControl2 : UserControl
    {
        RendelesDbContext context;
        public UserControl2()
        {
            InitializeComponent();
            LoadUgyfelek();
        }

        private void LoadUgyfelek()
        {
            using var context = new RendelesDbContext();
            listBox1.DataSource = context.Ugyfel
                .Where(u => u.Nev.Contains(textBox1.Text))
                .Select(u => u.Nev)
                .ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) => LoadUgyfelek();

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text)) return;

            using var context = new RendelesDbContext();
            context.Ugyfel.Add(new Ugyfel { Nev = textBox2.Text, Email = $"{textBox2.Text}@gmail.com" });
            SaveChanges(context);
            LoadUgyfelek();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            using var context = new RendelesDbContext();
            var ugyfel = context.Ugyfel.FirstOrDefault(h => h.Nev == listBox1.SelectedItem.ToString());
            if (ugyfel != null)
            {
                context.Ugyfel.Remove(ugyfel);
                SaveChanges(context);
                LoadUgyfelek();
            }
        }

        private void SaveChanges(RendelesDbContext context)
        {
            try { context.SaveChanges(); }
            catch (Exception ex) { MessageBox.Show($"Hiba történt: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}