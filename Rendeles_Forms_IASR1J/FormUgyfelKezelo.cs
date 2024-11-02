using Microsoft.EntityFrameworkCore;
using Rendeles_Forms_IASR1J.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rendeles_Forms_IASR1J.Models;
namespace Rendeles_Forms_IASR1J
{
    public partial class FormUgyfelKezelo : Form
    {
        private RendelesDbContext _context;
        private BindingList<Ugyfel> ugyfelBindingList;
        public FormUgyfelKezelo()
        {
            InitializeComponent();
            _context = new RendelesDbContext();
        }
        private void FormUgyfelKezelo_Load(object sender, EventArgs e)
        {
            Betoltes();
        }
        private void Betoltes()
        {
            _context.Ugyfel.Load();
            ugyfelBindingList = _context.Ugyfel.Local.ToBindingList();
            ugyfelBindingSource.DataSource = ugyfelBindingList;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filterString = textBox1.Text.ToLower();
            ugyfelBindingSource.DataSource = ugyfelBindingList
                .Where(u => u.Nev.ToLower().Contains(filterString) ||
                            u.Email.ToLower().Contains(filterString) ||
                            (u.Telefonszam != null && u.Telefonszam.ToLower().Contains(filterString)))
                .OrderBy(u => u.UgyfelId)
                .ToList();
        }
        private void buttonUjUgyfelHozzaadasa_Click(object sender, EventArgs e)
        {
            var formUjUgyfel = new FormUgyfelSzerkesztes();
            if (formUjUgyfel.ShowDialog() == DialogResult.OK)
            {
                ugyfelBindingList.Add(formUjUgyfel.SzerkesztettUgyfel);
                Mentes();
            }
        }
        private void buttonUgyfelModositasa_Click(object sender, EventArgs e)
        {
            if (ugyfelBindingSource.Current is Ugyfel kivalasztottUgyfel)
            {
                var formUgyfelSzerkesztes = new FormUgyfelSzerkesztes(kivalasztottUgyfel);
                if (formUgyfelSzerkesztes.ShowDialog() == DialogResult.OK) Mentes();
                else Betoltes();
            }
            else
            {
                MessageBox.Show("Kerjuk, valasszon ki egy ugyfelet a modositashoz.");
            }
        }
        private void buttonUgyfelTorlese_Click(object sender, EventArgs e)
        {
            if (ugyfelBindingSource.Current is Ugyfel kivalasztottUgyfel)
            {
                var megerosites = MessageBox.Show("Biztos vagy benne, hogy torolni szeretned ezt az ugyfelet?", "Torles megerositese", MessageBoxButtons.YesNo);
                if (megerosites == DialogResult.Yes)
                {
                    ugyfelBindingSource.RemoveCurrent();
                    Mentes();
                }
            }
            else
            {
                MessageBox.Show("Kerjuk, valasszon ki egy ugyfelet a torleshez.");
            }
        }
        void Mentes()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba a mentes soran: {ex.Message}");
            }
        }

    }
}
