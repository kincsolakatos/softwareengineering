using System.Xml.Linq;
using WinFormsAppZh.Data;

namespace WinFormsAppZh
{
    public partial class UserControl3 : UserControl
    {
        RendelesDbContext context;
        public UserControl3()
        {
            InitializeComponent();
            LoadKategoriak();
        }
        private void LoadKategoriak()
        {
            using var context = new RendelesDbContext();
            listBox1.DataSource = context.TermekKategoria.Select(tk => tk.Nev).ToList();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            using var context = new RendelesDbContext();
            var kategoriak = context.Termek
                .Where(t => t.Kategoria.Nev == listBox1.SelectedItem.ToString())
                .Select(t => new { t.TermekId, t.Nev, t.Leiras, t.AktualisAr, t.Keszlet, Kategoria = t.Kategoria.Nev })
                .ToList();
            dataGridView1.DataSource = kategoriak;
            if (kategoriak.Any())
            {
                label1.Text = context.Termek
                .Where(t => t.Kategoria.Nev == listBox1.SelectedItem.ToString())
                .Average(t => t.AktualisAr)
                .ToString();
                label2.Text = kategoriak.Count.ToString();
            }
            else
            {
                label1.Text = "N/A";
                label2.Text = "N/A";
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using var context = new RendelesDbContext();
            var termekKategoriak = context.TermekKategoria.ToList();
            var xDocument = new XDocument(
                new XElement("Kategoriak", termekKategoriak.Select(tk =>
                    new XElement("Kategoria", new XAttribute("KategoriaId", tk.KategoriaId), new XAttribute("Nev", tk.Nev)))
                ));
            using var saveFileDialog = new SaveFileDialog { Filter = "XML files (*.xml)|*.xml", Title = "Mentés XML fájlként", FileName = "kategoriak.xml" };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                xDocument.Save(saveFileDialog.FileName);
                MessageBox.Show("A kategóriák sikeresen mentésre kerültek.", "Mentés kész", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}