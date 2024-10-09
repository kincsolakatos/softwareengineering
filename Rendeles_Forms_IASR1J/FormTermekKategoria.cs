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
        public FormTermekKategoria()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            LoadKategoriak();
        }
        private void LoadKategoriak()
        {
            var kategoriak =
            (
                from k in _context.TermekKategoria
                select k
            ).ToList();
            treeViewKategoriak.Nodes.Clear();
            var fokategoriak =
                from k in kategoriak
                where k.SzuloKategoriaId == null
                select k;
            foreach (var kategoria in fokategoriak)
            {
                var node = CreateTreeNode(kategoria, kategoriak);
                treeViewKategoriak.Nodes.Add(node);
            }
        }
        private TreeNode CreateTreeNode(TermekKategoria kategoria, List<TermekKategoria> osszesKategoria)
        {
            var node = new TreeNode(kategoria.Nev) { Tag = kategoria };
            var alkategoriak =
                from k in osszesKategoria
                where k.SzuloKategoriaId == kategoria.KategoriaId
                select k;
            foreach (var gyerekKategoria in alkategoriak)
            {
                node.Nodes.Add(CreateTreeNode(gyerekKategoria, osszesKategoria));
            }
            return node;
        }

        private void treeViewKategoriak_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node?.Tag is TermekKategoria selectedKategoria)
            {
                textBoxNev.Text = selectedKategoria.Nev;
                textBoxLeiras.Text = selectedKategoria.Leiras;
            }
        }
        TermekKategoria newKategoria;
        bool isNewItem;
        private void buttonMentes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNev.Text))
            {
                MessageBox.Show("A nev mezo nem lehet ures!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (isNewItem)
                {
                    newKategoria.Nev = textBoxNev.Text;
                    newKategoria.Leiras = textBoxLeiras.Text;
                    _context.TermekKategoria.Add(newKategoria);
                }
                else if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedKategoria)
                {
                    selectedKategoria.Nev = textBoxNev.Text;
                    selectedKategoria.Leiras = textBoxLeiras.Text;
                }
                _context.SaveChanges();
                MessageBox.Show("A valtoztatasok sikeresen mentve", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKategoriak();
                isNewItem = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba tortent a mentes soran: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUjTestverKategoria_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedKategoria)
            {
                newKategoria = new TermekKategoria
                {
                    SzuloKategoriaId = selectedKategoria.SzuloKategoriaId
                };
                textBoxNev.Clear();
                textBoxLeiras.Clear();
                isNewItem = true;
            }
        }

        private void buttonUjGyermekKategoria_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedKategoria)
            {
                newKategoria = new TermekKategoria
                {
                    SzuloKategoriaId = selectedKategoria.KategoriaId
                };
                textBoxNev.Clear();
                textBoxLeiras.Clear();
                isNewItem = true;
            }
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedKategoria)
            {
                var result = MessageBox.Show($"Biztosan torolni szeretne a(z) '{selectedKategoria.Nev}' kategoriat es annak osszes alkategoriajat?", "Torles megerositese", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DeleteKategoriaAndChildren(selectedKategoria);
                        _context.SaveChanges();
                        MessageBox.Show("A kategoria es alkategoriai sikeresen torolve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadKategoriak();
                        textBoxNev.Clear();
                        textBoxLeiras.Clear();
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
        private void DeleteKategoriaAndChildren(TermekKategoria kategoria)
        {
            var childrenToDelete =
            (
                from k in _context.TermekKategoria
                where k.SzuloKategoriaId == kategoria.KategoriaId
                select k
            ).ToList();
            foreach (var child in childrenToDelete)
            {
                DeleteKategoriaAndChildren(child);
            }
            _context.TermekKategoria.Remove(kategoria);
        }

        private void atnevezesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode != null)
            {
                treeViewKategoriak.SelectedNode.BeginEdit();
            }
        }
        private void treeViewKategoriak_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null && e.Label != "")
            {
                TermekKategoria atnevezettKategoria = (TermekKategoria)e.Node.Tag;
                atnevezettKategoria.Nev = e.Label;
                _context.SaveChanges();
            }
        }

        private void ujFokategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TermekKategoria kategoria = new TermekKategoria();
            kategoria.Nev = "Uj Kategoria";
            _context.TermekKategoria.Add(kategoria);
            _context.SaveChanges();
            TreeNode ujTreeNode = new TreeNode(kategoria.Nev);
            ujTreeNode.Tag = kategoria;
            treeViewKategoriak.Nodes.Add(ujTreeNode);
            ujTreeNode.BeginEdit();
        }

        private void ujAlkategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode != null)
            {
                TermekKategoria kategoria = new TermekKategoria();
                kategoria.Nev = "Uj Kategoria";
                kategoria.SzuloKategoriaId = ((TermekKategoria)treeViewKategoriak.SelectedNode.Tag).SzuloKategoriaId;
                _context.TermekKategoria.Add(kategoria);
                _context.SaveChanges();
                TreeNode ujTreeNode = new TreeNode(kategoria.Nev);
                ujTreeNode.Tag = kategoria;
                treeViewKategoriak.SelectedNode.Nodes.Add(ujTreeNode);
                ujTreeNode.BeginEdit();
            }
        }

        private void frissitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadKategoriak();
        }

        private void torlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode != null)
            {
                if (treeViewKategoriak.SelectedNode.Nodes.Count == 0)
                {
                    var result = MessageBox.Show("Biztosan torolni szeretne?", "Torles megerositese", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        TermekKategoria kategoria = (TermekKategoria)treeViewKategoriak.SelectedNode.Tag;
                        _context.TermekKategoria.Remove(kategoria);
                        _context.SaveChanges();
                        treeViewKategoriak.Nodes.Remove(treeViewKategoriak.SelectedNode);
                    }
                }
                else
                {
                    MessageBox.Show("A termeknek alkategoriai vannak, nem torolheto.");
                }
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
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                sfd.Title = "Kategóriák mentése XML fájlba";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XDocument xdoc = new XDocument();
                        XDeclaration xdecl = new XDeclaration("1.0", "utf-8", "yes");
                        xdoc.Declaration = xdecl;
                        XElement root = new XElement("Kategoriak");
                        xdoc.Add(root);
                        var kategoriak = _context.TermekKategoria.ToList();
                        foreach (var kategoria in kategoriak.Where(c => c.SzuloKategoriaId == null))
                        {
                            XElement kategoiaElem = KategoriaElemLetrehozasa(kategoria, kategoriak);
                            root.Add(kategoiaElem);
                        }
                        xdoc.Save(sfd.FileName);
                        MessageBox.Show("A kategóriák sikeresen mentésre kerültek!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hiba történt a mentés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private XElement KategoriaElemLetrehozasa(TermekKategoria kategoria, List<TermekKategoria> osszesKategoria)
        {
            XElement kategoriaElem = new XElement
            (
                "Kategoria",
                new XAttribute("KategoriaId", kategoria.KategoriaId),
                new XAttribute("Nev", kategoria.Nev)
            );
            var alkategoriak = osszesKategoria.Where(c => c.SzuloKategoriaId == kategoria.KategoriaId).ToList();
            foreach (var alkategoria in alkategoriak)
            {
                XElement alkategoriaElem = KategoriaElemLetrehozasa(alkategoria, osszesKategoria);
                kategoriaElem.Add(alkategoriaElem);
            }
            return kategoriaElem;
        }

        private void FormTermekKategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
