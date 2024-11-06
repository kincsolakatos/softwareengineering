using Rendeles_Forms_IASR1J.Data;
using Rendeles_Forms_IASR1J.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace Rendeles_Forms_IASR1J
{
    public partial class FormTermekKategoria : Form
    {
        private RendelesDbContext _context;
        private TermekKategoria _ujKategoria;
        private bool _ujKategoriaE;
        public FormTermekKategoria()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            KategoriakBetoltese();
        }
        private void KategoriakBetoltese()
        {
            var kategoriak = _context.TermekKategoria.ToList();
            treeViewKategoriak.Nodes.Clear();
            var fokategoriak = kategoriak.Where(c => c.SzuloKategoriaId == null);
            foreach (var kategoria in fokategoriak)
            {
                treeViewKategoriak.Nodes.Add(TreeNodeLetrehozasa(kategoria, kategoriak));
            }
        }
        private TreeNode TreeNodeLetrehozasa(TermekKategoria kategoria, List<TermekKategoria> osszesKategoria)
        {
            var node = new TreeNode(kategoria.Nev) { Tag = kategoria };
            var alkategoriak = osszesKategoria.Where(ok => ok.SzuloKategoriaId == kategoria.KategoriaId);
            foreach (var alkategoria in alkategoriak)
            {
                node.Nodes.Add(TreeNodeLetrehozasa(alkategoria, osszesKategoria));
            }
            return node;
        }
        private void treeViewKategoriak_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node?.Tag is TermekKategoria selectedCategory)
            {
                textBoxNev.Text = selectedCategory.Nev;
                textBoxLeiras.Text = selectedCategory.Leiras;
            }
        }
        private void buttonMentes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNev.Text))
            {
                MessageBox.Show("A nev mezo nem lehet ures!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (_ujKategoriaE)
                {
                    _ujKategoria.Nev = textBoxNev.Text;
                    _ujKategoria.Leiras = textBoxLeiras.Text;
                    _context.TermekKategoria.Add(_ujKategoria);
                }
                else if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria kivalasztottKategoria)
                {
                    kivalasztottKategoria.Nev = textBoxNev.Text;
                    kivalasztottKategoria.Leiras = textBoxLeiras.Text;
                }
                _context.SaveChanges();
                MessageBox.Show("A valtoztatasok sikeresen mentve", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KategoriakBetoltese();
                _ujKategoriaE = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba tortent a mentes soran: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonUjTestverKategoria_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria kivalasztottKategoria)
            {
                _ujKategoria = new TermekKategoria { SzuloKategoriaId = kivalasztottKategoria.SzuloKategoriaId };
                KategoriaBemenetekTorlese();
                _ujKategoriaE = true;
            }
        }
        private void buttonUjGyermekKategoria_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedCategory)
            {
                _ujKategoria = new TermekKategoria { SzuloKategoriaId = selectedCategory.KategoriaId };
                KategoriaBemenetekTorlese();
                _ujKategoriaE = true;
            }
        }
        private void KategoriaBemenetekTorlese()
        {
            textBoxNev.Clear();
            textBoxLeiras.Clear();
        }
        private void buttonTorles_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria kivalasztottKategoria)
            {
                var result = MessageBox.Show($"Biztosan torolni szeretne a(z) '{kivalasztottKategoria.Nev}' kategoriat es annak osszes alkategoriajat?", "Torles megerositese", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        KategoriaTorleseGyermekekkel(kivalasztottKategoria);
                        _context.SaveChanges();
                        MessageBox.Show("A kategoria es alkategoriai sikeresen torolve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KategoriakBetoltese();
                        KategoriaBemenetekTorlese();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hiba tortent a torles soran: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Kerjuk, valasszon ki egy kategoriat a torleshez!", "Figyelmeztetes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void KategoriaTorleseGyermekekkel(TermekKategoria kategoria)
        {
            var gyermekek = _context.TermekKategoria.Where(k => k.SzuloKategoriaId == kategoria.KategoriaId).ToList();
            foreach (var gyermek in gyermekek)
            {
                KategoriaTorleseGyermekekkel(gyermek);
            }
            _context.TermekKategoria.Remove(kategoria);
        }
        private void atnevezesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode != null) treeViewKategoriak.SelectedNode.BeginEdit();
        }
        private void treeViewKategoriak_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Label))
            {
                var atnevezettKategoria = (TermekKategoria)e.Node.Tag;
                atnevezettKategoria.Nev = e.Label;
                _context.SaveChanges();
            }
        }
        private void ujFokategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var kategoria = new TermekKategoria { Nev = "Uj Kategoria" };
            _context.TermekKategoria.Add(kategoria);
            _context.SaveChanges();
            var ujTreeNode = new TreeNode(kategoria.Nev) { Tag = kategoria };
            treeViewKategoriak.Nodes.Add(ujTreeNode);
            ujTreeNode.BeginEdit();
        }
        private void ujAlkategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode != null)
            {
                var szuloKategoria = (TermekKategoria)treeViewKategoriak.SelectedNode.Tag;
                var kategoria = new TermekKategoria { Nev = "Uj Kategoria", SzuloKategoriaId = szuloKategoria.SzuloKategoriaId };
                _context.TermekKategoria.Add(kategoria);
                _context.SaveChanges();
                var ujTreeNode = new TreeNode(kategoria.Nev) { Tag = kategoria };
                treeViewKategoriak.SelectedNode.Nodes.Add(ujTreeNode);
                ujTreeNode.BeginEdit();
            }
        }
        private void frissitesToolStripMenuItem_Click(object sender, EventArgs e) => KategoriakBetoltese();
        private void torlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode == null) return;
            if (treeViewKategoriak.SelectedNode.Nodes.Count > 0)
            {
                MessageBox.Show("A termeknek alkategoriai vannak, nem torolheto.");
                return;
            }
            var torles = MessageBox.Show("Biztosan torolni szeretne?", "Torles megerositese", MessageBoxButtons.YesNo);
            if (torles == DialogResult.Yes)
            {
                var kategoria = (TermekKategoria)treeViewKategoriak.SelectedNode.Tag;
                _context.TermekKategoria.Remove(kategoria);
                _context.SaveChanges();
                treeViewKategoriak.Nodes.Remove(treeViewKategoriak.SelectedNode);
            }
        }
        private void treeViewKategoriak_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeViewKategoriak.SelectedNode = e.Node;
                contextMenuStripKategoria.Show(treeViewKategoriak, e.Location);
            }
        }
        private void mentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog { Filter = "XML files (*.xml)|*.xml", Title = "Kategóriák mentése XML fájlba" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var xDocument = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));
                        var gyoker = new XElement("Kategoriak");
                        var kategoriak = _context.TermekKategoria.ToList();
                        foreach (var kategoria in kategoriak.Where(k => k.SzuloKategoriaId == null))
                        {
                            gyoker.Add(CreateCategoryElement(kategoria, kategoriak));
                        }
                        xDocument.Add(gyoker);
                        xDocument.Save(saveFileDialog.FileName);
                        MessageBox.Show("A kategóriák sikeresen mentésre kerültek!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hiba történt a mentés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private XElement CreateCategoryElement(TermekKategoria kategoria, List<TermekKategoria> osszesKategoria)
        {
            var szulo = new XElement("Kategoria",
                new XAttribute("KategoriaId", kategoria.KategoriaId),
                new XAttribute("Nev", kategoria.Nev)
            );
            var alkategoriak = osszesKategoria.Where(c => c.SzuloKategoriaId == kategoria.KategoriaId).ToList();
            foreach (var alkategoria in alkategoriak)
            {
                szulo.Add(CreateCategoryElement(alkategoria, osszesKategoria));
            }
            return szulo;
        }

        private void FormTermekKategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
