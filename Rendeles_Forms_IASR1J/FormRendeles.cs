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
        public FormRendeles()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
        }

        private void FormRendeles_Load(object sender, EventArgs e)
        {
            LoadUgyfelek();
        }

        private void textBoxUgyfelekSzurese_TextChanged(object sender, EventArgs e)
        {
            LoadUgyfelek();
        }
        private void LoadUgyfelek()
        {
            var ugyfelek = from ugyfel in _context.Ugyfel
                           where ugyfel.Nev.Contains(textBoxUgyfelekSzurese.Text) || ugyfel.Email.Contains(textBoxUgyfelekSzurese.Text)
                           orderby ugyfel.Nev
                           select ugyfel;
            ugyfelBindingSource.DataSource = ugyfelek.ToList();
            ugyfelBindingSource.ResetCurrentItem();
            ugyfelBindingSource.ResetBindings(false);
        }
        private void LoadCimek()
        {
            var cimek = from cim in _context.Cim
                        select new CimEgybenDTO
                        {
                            CimId = cim.CimId,
                            CimEgyben = $"{cim.Iranyitoszam}-{cim.Varos}, {cim.Orszag}: {cim.Utca} {cim.Hazszam}"
                        };
            cimEgybenDTOBindingSource.DataSource = cimek.ToList();
            comboBoxRendelesCime.DataSource = cimEgybenDTOBindingSource;
            comboBoxRendelesCime.DisplayMember = "CimEgyben";
            comboBoxRendelesCime.ValueMember = "CimId";
            cimEgybenDTOBindingSource.ResetCurrentItem();
            cimEgybenDTOBindingSource.ResetBindings(false);
        }
        private void LoadRendelesek()
        {
            if (ugyfelBindingSource.Current == null)
            {
                return;
            }
            dataGridViewRendeltTetelek.DataSource = null;
            var rendelesek = from rendeles in _context.Rendeles
                             where rendeles.UgyfelId == ((Ugyfel)ugyfelBindingSource.Current).UgyfelId
                             select rendeles;
            rendelesBindingSource.DataSource = rendelesek.ToList();
            listBoxRendelesek.DataSource = rendelesBindingSource;
            if (listBoxRendelesek.Items.Count > 0)
            {
                listBoxRendelesek.SelectedIndex = 0;
            }
            rendelesBindingSource.ResetCurrentItem();
            ugyfelBindingSource.ResetBindings(false);
        }

        private void listBoxUgyfelek_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRendelesek();
        }
        private void LoadRendelesTetelek()
        {
            if (rendelesBindingSource.Current == null)
            {
                return;
            }
            var rendelesTetelek = from rendelesTetel in _context.RendelesTetel
                                  where rendelesTetel.RendelesId == ((Rendeles)rendelesBindingSource.Current).RendelesId
                                  select new RendelesTetelDTO
                                  {
                                      TetelId = rendelesTetel.TetelId,
                                      TermekNev = rendelesTetel.Termek.Nev,
                                      Mennyiseg = rendelesTetel.Mennyiseg,
                                      EgysegAr = rendelesTetel.EgysegAr,
                                      Afa = rendelesTetel.Afa,
                                      NettoAr = rendelesTetel.NettoAr,
                                      BruttoAr = rendelesTetel.BruttoAr
                                  };
            dataGridViewRendeltTetelek.DataSource = rendelesTetelek.ToList();
        }

        private void listBoxRendelesek_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRendelesTetelek();
        }

        private void buttonUjRendeles_Click(object sender, EventArgs e)
        {
            if (ugyfelBindingSource.Current == null)
            {
                return;
            }
            var cim = ((Ugyfel)ugyfelBindingSource.Current).Lakcim ?? _context.Cim.FirstOrDefault();
            if (cim == null)
            {
                MessageBox.Show("Nincs cim megadva");
                return;
            }
            var ujRendeles = new Rendeles()
            {
                UgyfelId = ((Ugyfel)ugyfelBindingSource.Current).UgyfelId,
                SzallitasiCimId = cim.CimId,
                RendelesDatum = DateTime.Now,
                Kedvezmeny = 0,
                Vegosszeg = 0,
                Statusz = "Feldolgozás alatt"
            };
            _context.Rendeles.Add(ujRendeles);
            Mentes();
            labelARendelesTeljesErteke.Text = $"A rendeles teljes erteke: {ujRendeles.Vegosszeg} Ft";
            LoadRendelesek();
            listBoxRendelesek.SelectedItem = ujRendeles;
            ugyfelBindingSource.ResetBindings(false);
        }
        private void Mentes()
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
        private const decimal afa = .27m;

        private void buttonTetelHozzaadas_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxMennyiseg.Text, out int mennyiseg) || mennyiseg <= 0)
            {
                MessageBox.Show("Rossz mennyiseg");
                return;
            }
            if (rendelesBindingSource.Current == null || termekBindingSource.Current == null)
            {
                MessageBox.Show("Nincs kivalasztva rendeles vagy termek");
                return;
            }
            var kivalasztottTermek = (Termek)termekBindingSource.Current;
            decimal bruttoAr = kivalasztottTermek.AktualisAr * (1 + afa);
            var ujTetel = new RendelesTetel
            {
                RendelesId = ((Rendeles)rendelesBindingSource.Current).RendelesId,
                TermekId = kivalasztottTermek.TermekId,
                Mennyiseg = mennyiseg,
                EgysegAr = kivalasztottTermek.AktualisAr,
                Afa = afa,
                NettoAr = kivalasztottTermek.AktualisAr * mennyiseg,
                BruttoAr = bruttoAr
            };
            _context.RendelesTetel.Add(ujTetel);
            Mentes();
            LoadRendelesTetelek();
            UpdateVegosszeg();
        }

        private void buttonTetelTorles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            if (dataGridViewRendeltTetelek.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nincs kivalasztva tetel");
                return;
            }
            var selectedTetel = dataGridViewRendeltTetelek.SelectedRows[0].DataBoundItem as RendelesTetelDTO;
            var tetelek = 
            (
                from tetel in _context.RendelesTetel
                where tetel.TetelId == selectedTetel!.TetelId
                select tetel
            ).FirstOrDefault();
            if (tetelek != null) 
            {
                _context.RendelesTetel.Remove(tetelek);
                Mentes();
                LoadRendelesTetelek();
                UpdateVegosszeg();
            }
        }
        private void UpdateVegosszeg()
        {
            if (rendelesBindingSource.Current == null)
            {
                return;
            }
            var kivalasztottRendeles = (Rendeles)rendelesBindingSource.Current;
            var vegosszeg = _context.RendelesTetel
                .Where(rendelesTetel => rendelesTetel.RendelesId == kivalasztottRendeles.RendelesId)
                .Sum(rendelesTetel => rendelesTetel.Mennyiseg * rendelesTetel.BruttoAr);
            kivalasztottRendeles.Vegosszeg = decimal.Round(vegosszeg * (1 - kivalasztottRendeles.Kedvezmeny), 2);
            labelARendelesTeljesErteke.Text = $"A rendeles teljes erteke: {kivalasztottRendeles.Vegosszeg} Ft";
            Mentes();
            rendelesBindingSource.ResetBindings(false);
        }
    }
}
