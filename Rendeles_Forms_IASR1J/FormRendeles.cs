using Microsoft.EntityFrameworkCore;
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
    public partial class FormRendeles : Form
    {
        private readonly RendelesDbContext _context;
        private BindingSource cimEgybenDTOBindingSource = new BindingSource();
        private const decimal afa = .27m;
        public FormRendeles()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
        }
        private void FormRendeles_Load(object sender, EventArgs e)
        {
            LoadUgyfelek();
            LoadTermekek();
        }
        private void textBoxUgyfelekSzurese_TextChanged(object sender, EventArgs e) => LoadUgyfelek();
        private void LoadUgyfelek()
        {
            ugyfelBindingSource.DataSource = _context.Ugyfel
                .Where(u => u.Nev.Contains(textBoxUgyfelekSzurese.Text) || u.Email.Contains(textBoxUgyfelekSzurese.Text))
                .OrderBy(u => u.Nev)
                .ToList();
            ugyfelBindingSource.ResetBindings(false);
        }
        private void LoadCimek()
        {
            cimEgybenDTOBindingSource.DataSource = _context.Cim
                .Select(c => new CimDTO
                {
                    Id = c.CimId,
                    Cim = $"{c.Iranyitoszam}-{c.Varos}, {c.Orszag}: {c.Utca} {c.Hazszam}"
                })
                .ToList();
            comboBoxRendelesCime.DataSource = cimEgybenDTOBindingSource;
            comboBoxRendelesCime.DisplayMember = "Cim";
            comboBoxRendelesCime.ValueMember = "Id";
        }
        private void LoadRendelesek()
        {
            if (ugyfelBindingSource.Current is not Ugyfel selectedUgyfel) return;
            rendelesBindingSource.DataSource = _context.Rendeles
                .Where(r => r.UgyfelId == selectedUgyfel.UgyfelId)
                .ToList();
            listBoxRendelesek.DataSource = rendelesBindingSource;
            if (listBoxRendelesek.Items.Count > 0) listBoxRendelesek.SelectedIndex = 0;
            ugyfelBindingSource.ResetBindings(false);
        }
        private void listBoxUgyfelek_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRendelesek();
            LoadCimek();
        }
        private void LoadRendelesTetelek()
        {
            if (rendelesBindingSource.Current is not Rendeles selectedRendeles) return;
            dataGridViewRendeltTetelek.DataSource = _context.RendelesTetel
                .Where(rt => rt.RendelesId == selectedRendeles.RendelesId)
                .Select(rt => new RendelesTetelDTO
                {
                    TetelId = rt.TetelId,
                    TermekNev = rt.Termek.Nev,
                    Mennyiseg = rt.Mennyiseg,
                    EgysegAr = rt.EgysegAr,
                    Afa = rt.Afa,
                    NettoAr = rt.NettoAr,
                    BruttoAr = rt.BruttoAr
                })
                .ToList();
        }
        private void listBoxRendelesek_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRendelesTetelek();
            if (rendelesBindingSource.Current is Rendeles selectedRendeles) UpdateTotalOrderValue(selectedRendeles);
        }
        private void buttonUjRendeles_Click(object sender, EventArgs e)
        {
            if (ugyfelBindingSource.Current is not Ugyfel selectedUgyfel) return;
            var cim = selectedUgyfel.Lakcim ?? _context.Cim.FirstOrDefault();
            if (cim == null)
            {
                MessageBox.Show("Nincs cim megadva");
                return;
            }
            var ujRendeles = new Rendeles
            {
                UgyfelId = selectedUgyfel.UgyfelId,
                SzallitasiCimId = cim.CimId,
                RendelesDatum = DateTime.Now,
                Kedvezmeny = 0,
                Vegosszeg = 0,
                Statusz = "Feldolgozás alatt"
            };
            _context.Rendeles.Add(ujRendeles);
            SaveChanges();
            UpdateTotalOrderValue(ujRendeles);
            LoadRendelesek();
            listBoxRendelesek.SelectedItem = ujRendeles;
        }
        private void SaveChanges()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Database update error: " + (ex.InnerException?.Message) ?? ex.Message);
            }
        }
        private void buttonTetelHozzaadas_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxMennyiseg.Text, out int mennyiseg) || mennyiseg <= 0)
            {
                MessageBox.Show("Rossz mennyiseg");
                return;
            }
            if (rendelesBindingSource.Current is not Rendeles selectedRendeles || termekBindingSource.Current is not Termek selectedTermek)
            {
                MessageBox.Show("Nincs kivalasztva rendeles vagy termek");
                return;
            }
            var bruttoAr = selectedTermek.AktualisAr * (1 + afa);
            var ujTetel = new RendelesTetel
            {
                RendelesId = selectedRendeles.RendelesId,
                TermekId = selectedTermek.TermekId,
                Mennyiseg = mennyiseg,
                EgysegAr = selectedTermek.AktualisAr,
                Afa = afa,
                NettoAr = selectedTermek.AktualisAr * mennyiseg,
                BruttoAr = bruttoAr
            };
            _context.RendelesTetel.Add(ujTetel);
            SaveChanges();
            LoadRendelesTetelek();
            UpdateTotalOrderValue(selectedRendeles);
        }

        private void buttonTetelTorles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.No) return;
            if (dataGridViewRendeltTetelek.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nincs kivalasztva tetel");
                return;
            }
            var selectedTetel = dataGridViewRendeltTetelek.SelectedRows[0].DataBoundItem as RendelesTetelDTO;
            var tetel = _context.RendelesTetel.FirstOrDefault(t => t.TetelId == selectedTetel!.TetelId);
            if (tetel != null)
            {
                _context.RendelesTetel.Remove(tetel);
                SaveChanges();
                LoadRendelesTetelek();
                UpdateTotalOrderValue((Rendeles)rendelesBindingSource.Current);
            }
        }
        private void UpdateTotalOrderValue(Rendeles rendeles)
        { 
            var vegosszeg = _context.RendelesTetel
                .Where(rt => rt.RendelesId == rendeles.RendelesId)
                .Sum(rt => rt.Mennyiseg * rt.BruttoAr);
            rendeles.Vegosszeg = decimal.Round(vegosszeg * (1 - rendeles.Kedvezmeny / 100), 2);
            rendeles.Vegosszeg = Math.Max(rendeles.Vegosszeg, 0);
            labelARendelesTeljesErteke.Text = $"A rendeles teljes erteke: {rendeles.Vegosszeg} Ft";
            SaveChanges();
        }
        private void LoadTermekek()
        {
            termekBindingSource.DataSource = _context.Termek.ToList();
        }

        private void buttonExcelExport_Click(object sender, EventArgs e)
        {
            var excelExport = new ExcelExport();
            excelExport.CreateExcel();
        }
    }
}
