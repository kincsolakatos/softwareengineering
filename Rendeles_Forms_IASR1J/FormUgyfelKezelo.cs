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
            _context.Ugyfel.Load();
            ugyfelBindingList = _context.Ugyfel.Local.ToBindingList();
            ugyfelBindingSource.DataSource = ugyfelBindingList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filterString = textBox1.Text.ToLower();
            ugyfelBindingSource.DataSource =
                from u in ugyfelBindingList
                where u.Nev.ToLower().Contains(filterString) ||
                u.Email.ToLower().Contains(filterString) ||
                (u.Telefonszam != null && u.Telefonszam.ToLower().Contains(filterString))
                orderby u.UgyfelId
                select u;
        }

        private void buttonUjUgyfelHozzaadasa_Click(object sender, EventArgs e)
        {
            FormUgyfelSzerkesztes formUjUgyfel = new FormUgyfelSzerkesztes();
            if (formUjUgyfel.ShowDialog() == DialogResult.OK)
            {
                ugyfelBindingList.Add(formUjUgyfel.SzerkesztettUgyfel);
                Mentes();
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
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUgyfelModositasa_Click(object sender, EventArgs e)
        {
            Ugyfel kivalasztottUgyfel = ugyfelBindingSource.Current as Ugyfel;

            if (kivalasztottUgyfel != null)
            {
                FormUgyfelSzerkesztes formUgyfelSzerkesztes = new FormUgyfelSzerkesztes(kivalasztottUgyfel);
                if (formUgyfelSzerkesztes.ShowDialog() == DialogResult.OK)
                {
                    Mentes();
                }
            }
        }
    }
}
