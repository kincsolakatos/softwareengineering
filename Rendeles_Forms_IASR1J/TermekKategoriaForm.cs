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

namespace Rendeles_Forms_IASR1J
{
    public partial class TermekKategoriaForm : Form
    {
        private RendelesDbContext _context;
        public TermekKategoriaForm()
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

        private void TermekKategoriaForm_Load(object sender, EventArgs e)
        {

        }

        private void treeViewKategoriak_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node?.Tag is TermekKategoria selectedKategoria)
            {
                textBoxNev.Text = selectedKategoria.Nev;
                textBoxLeiras.Text = selectedKategoria.Leiras;
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
        TermekKategoria newKategoria;
        bool isNewItem;
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
            foreach ( var child in childrenToDelete )
            {
                DeleteKategoriaAndChildren(child);
            }
            _context.TermekKategoria.Remove(kategoria);
        }
    }
}
