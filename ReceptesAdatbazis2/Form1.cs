using ReceptesAdatbazis2.Models;

namespace ReceptesAdatbazis2
{
    public partial class Form1 : Form
    {
        public ReceptContext context = new ReceptContext();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNyersanyagok();
            LoadFogasok();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            LoadNyersanyagok();
        }
        private void LoadNyersanyagok()
        {
            listBox2.DataSource = nyersanyagokBindingSource;
            var nyersanyagok = context.Nyersanyagok.Where(ny => ny.NyersanyagNev.Contains(textBox2.Text)).ToList();
            nyersanyagokBindingSource.DataSource = nyersanyagok;
            listBox2.DisplayMember = "NyersanyagNev";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadFogasok();
        }
        private void LoadFogasok()
        {
            listBox1.DataSource = fogasokBindingSource;
            var fogasok = context.Fogasok.Where(f => f.FogasNev.Contains(textBox1.Text)).ToList();
            fogasokBindingSource.DataSource = fogasok;
            listBox1.DisplayMember = "FogasNev";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedNyersanyag = listBox2.SelectedItem as Nyersanyagok;
            var mennyisegiEgyseg = context.MennyisegiEgysegek
                .Where(me => me.MennyisegiEgysegId == selectedNyersanyag.MennyisegiEgysegId)
                .Select(me => me.EgysegNev)
                .FirstOrDefault();
            label1.Text = mennyisegiEgyseg;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHozzavalok();
        }
        private void LoadHozzavalok()
        {
            dataGridView1.DataSource = hozzavalokBindingSource;
            var selectedFogas = listBox1.SelectedItem as Fogasok;
            var hozzavalok = context.Receptek
                .Where(r => r.FogasId == selectedFogas.FogasId)
                .Select(r => new Hozzavalok
                {
                    ReceptId = r.ReceptId,
                    FogasNev = r.Fogas.FogasNev,
                    NyersanyagNev = r.Nyersanyag.NyersanyagNev,
                    Mennyiseg4fo = r.Mennyiseg4fo,
                    MennyisegiEgyseg = r.Nyersanyag.MennyisegiEgyseg.EgysegNev,
                    Egysegar = r.Nyersanyag.Egysegar,
                    Ar = r.Mennyiseg4fo * (double?)r.Nyersanyag.Egysegar
                }).ToList();
            hozzavalokBindingSource.DataSource = hozzavalok;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Receptek ujHozzavalo = new Receptek();
            ujHozzavalo.FogasId = ((Fogasok)listBox1.SelectedItem).FogasId;
            ujHozzavalo.NyersanyagId = ((Nyersanyagok)listBox2.SelectedItem).NyersanyagId;
            double m;
            if (!double.TryParse(textBox3.Text, out m)) return;
            ujHozzavalo.Mennyiseg4fo = m;
            context.Receptek.Add(ujHozzavalo);
            context.SaveChanges();
            LoadHozzavalok();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var torlendoHozzavalo = context.Receptek
                .Where(th => th.ReceptId == ((Hozzavalok)hozzavalokBindingSource.Current).ReceptId)
                .FirstOrDefault();
            context.Receptek.Remove(torlendoHozzavalo);
            context.SaveChanges();
            LoadHozzavalok();
        }
    }
}
