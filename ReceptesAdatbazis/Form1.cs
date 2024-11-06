using ReceptesAdatbazis.Models;
namespace ReceptesAdatbazis
{
    public partial class Form1 : Form
    {
        private readonly ReceptContext _context = new();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateNyersanyagList();
            UpdateFogasList();
        }
        private void UpdateNyersanyagList()
        {
            listBox2.DataSource = nyersanyagokBindingSource;
            nyersanyagokBindingSource.DataSource = _context.Nyersanyagok
                .Where(ny => ny.NyersanyagNev.Contains(textBox2.Text))
                .ToList();
            listBox2.DisplayMember = "NyersanyagNev";
        }
        private void UpdateFogasList()
        {
            listBox1.DataSource = fogasokBindingSource;
            fogasokBindingSource.DataSource = _context.Fogasok
                .Where(f => f.FogasNev.Contains(textBox1.Text))
                .ToList();
            listBox1.DisplayMember = "FogasNev";
        }
        private void textBox2_TextChanged(object sender, EventArgs e) => UpdateNyersanyagList();
        private void textBox1_TextChanged(object sender, EventArgs e) => UpdateFogasList();
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedNyersanyag = listBox2.SelectedItem as Nyersanyagok;
            label1.Text = selectedNyersanyag != null
                ? _context.MennyisegiEgysegek.Find(selectedNyersanyag.MennyisegiEgysegId)?.EgysegNev ?? "Nincs megadva"
                : "Nincs kiválasztott nyersanyag";
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) => UpdateHozzavaloList();
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Fogasok selectedFogas &&
                listBox2.SelectedItem is Nyersanyagok selectedNyersanyag &&
                double.TryParse(textBox3.Text, out double mennyiseg))
            {
                _context.Receptek.Add(new Receptek
                {
                    NyersanyagId = selectedNyersanyag.NyersanyagId,
                    FogasId = selectedFogas.FogasId,
                    Mennyiseg4fo = mennyiseg
                });
                _context.SaveChanges();
                UpdateHozzavaloList();
            }
        }
        private void UpdateHozzavaloList()
        {
            if (listBox1.SelectedItem is not Fogasok selectedFogas) return;
            hozzavalokBindingSource.DataSource = _context.Receptek
                .Where(r => r.FogasId == selectedFogas.FogasId)
                .Select(r => new Hozzavalok
                {
                    ReceptID = r.ReceptId,
                    FogasID = r.FogasId,
                    NyersanyagNev = r.Nyersanyag.NyersanyagNev,
                    Mennyiseg_4fo = r.Mennyiseg4fo ?? 0,
                    EgysegNev = r.Nyersanyag.MennyisegiEgyseg.EgysegNev,
                    Ár = (r.Mennyiseg4fo ?? 0) * (double?)r.Nyersanyag.Egysegar
                }).ToList();
            dataGridView1.DataSource = hozzavalokBindingSource;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (hozzavalokBindingSource.Current is not Hozzavalok selectedHozzavalo) return;
            using var _context = new ReceptContext();
            var recept = _context.Receptek
                .SingleOrDefault(r => r.ReceptId == selectedHozzavalo.ReceptID);
            if (recept == null) return;
            _context.Receptek.Remove(recept);
            _context.SaveChanges();
            UpdateHozzavaloList();
        }
    }
}
