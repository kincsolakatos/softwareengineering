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
        private TermekKategoria _newCategory;
        private bool _isNewCategory;
        public FormTermekKategoria()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            LoadCategories();
        }
        private void LoadCategories()
        {
            var categories = _context.TermekKategoria.ToList();
            treeViewKategoriak.Nodes.Clear();
            var maincategories = categories.Where(c => c.SzuloKategoriaId == null);
            foreach (var category in maincategories)
            {
                treeViewKategoriak.Nodes.Add(CreateTreeNode(category, categories));
            }
        }
        private TreeNode CreateTreeNode(TermekKategoria category, List<TermekKategoria> allCategories)
        {
            var node = new TreeNode(category.Nev) { Tag = category };
            var subcategories = allCategories.Where(c => c.SzuloKategoriaId == category.KategoriaId);
            foreach (var subcategory in subcategories)
            {
                node.Nodes.Add(CreateTreeNode(subcategory, allCategories));
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
                if (_isNewCategory)
                {
                    _newCategory.Nev = textBoxNev.Text;
                    _newCategory.Leiras = textBoxLeiras.Text;
                    _context.TermekKategoria.Add(_newCategory);
                }
                else if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedCategory)
                {
                    selectedCategory.Nev = textBoxNev.Text;
                    selectedCategory.Leiras = textBoxLeiras.Text;
                }
                _context.SaveChanges();
                MessageBox.Show("A valtoztatasok sikeresen mentve", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategories();
                _isNewCategory = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba tortent a mentes soran: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonUjTestverKategoria_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedCategory)
            {
                _newCategory = new TermekKategoria { SzuloKategoriaId = selectedCategory.SzuloKategoriaId };
                ClearCategoryInputs();
                _isNewCategory = true;
            }
        }
        private void buttonUjGyermekKategoria_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedCategory)
            {
                _newCategory = new TermekKategoria { SzuloKategoriaId = selectedCategory.KategoriaId };
                ClearCategoryInputs();
                _isNewCategory = true;
            }
        }
        private void ClearCategoryInputs()
        {
            textBoxNev.Clear();
            textBoxLeiras.Clear();
        }
        private void buttonTorles_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode?.Tag is TermekKategoria selectedCategory)
            {
                var result = MessageBox.Show($"Biztosan torolni szeretne a(z) '{selectedCategory.Nev}' kategoriat es annak osszes alkategoriajat?", "Torles megerositese", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DeleteCategoryWithChildren(selectedCategory);
                        _context.SaveChanges();
                        MessageBox.Show("A kategoria es alkategoriai sikeresen torolve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCategories();
                        ClearCategoryInputs();
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
        private void DeleteCategoryWithChildren(TermekKategoria category)
        {
            var children = _context.TermekKategoria.Where(c => c.SzuloKategoriaId == category.KategoriaId).ToList();
            foreach (var child in children)
            {
                DeleteCategoryWithChildren(child);
            }
            _context.TermekKategoria.Remove(category);
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
        private void frissitesToolStripMenuItem_Click(object sender, EventArgs e) => LoadCategories();
        private void torlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewKategoriak.SelectedNode == null) return;
            if (treeViewKategoriak.SelectedNode.Nodes.Count > 0)
            {
                MessageBox.Show("A termeknek alkategoriai vannak, nem torolheto.");
                return;
            }
            var confirmDelete = MessageBox.Show("Biztosan torolni szeretne?", "Torles megerositese", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
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
                        var xdoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));
                        var root = new XElement("Kategoriak");
                        var categories = _context.TermekKategoria.ToList();
                        foreach (var category in categories.Where(c => c.SzuloKategoriaId == null))
                        {
                            root.Add(CreateCategoryElement(category, categories));
                        }
                        xdoc.Add(root);
                        xdoc.Save(saveFileDialog.FileName);
                        MessageBox.Show("A kategóriák sikeresen mentésre kerültek!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hiba történt a mentés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private XElement CreateCategoryElement(TermekKategoria category, List<TermekKategoria> allCategories)
        {
            var element = new XElement( "Kategoria",
                                        new XAttribute("KategoriaId", category.KategoriaId),
                                        new XAttribute("Nev", category.Nev)
            );
            var subcategories = allCategories.Where(c => c.SzuloKategoriaId == category.KategoriaId).ToList();
            foreach (var subcategory in subcategories)
            {
                element.Add(CreateCategoryElement(subcategory, allCategories));
            }
            return element;
        }
    }
}
