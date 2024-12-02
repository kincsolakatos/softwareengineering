using Microsoft.Identity.Client;
using Rendeles_Forms_IASR1J.Data;
using Rendeles_Forms_IASR1J.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Rendeles_Forms_IASR1J
{
    public partial class FormUgyfelSzerkesztes : Form
    {
        public Ugyfel SzerkesztettUgyfel { get; set; }
        public Cim SzerkesztettCim { get;  set; }
        private RendelesDbContext _context;
        private ErrorProvider _errorProvider;
        public FormUgyfelSzerkesztes(Ugyfel ugyfel = null, Cim cim = null)
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            SzerkesztettUgyfel = ugyfel ?? new Ugyfel();
            SzerkesztettCim = cim ?? new Cim();
            ugyfelBindingSource.DataSource = SzerkesztettUgyfel;
            cimBindingSource.DataSource = SzerkesztettCim;
            _errorProvider = new ErrorProvider();
        }
        private void FormUgyfelSzerkesztes_Load(object sender, EventArgs e)
        {
            CimekBetoltese();
            FrissitCimMezoElerhetoseget();
        }
        private void CimekBetoltese()
        {
            comboBoxLetezoCimBeallitasa.DataSource = _context.Cim
                .Select(c => new { c.CimId, TeljesCim = $"{c.Varos} {c.Utca} {c.Hazszam}, {c.Iranyitoszam}, {c.Orszag}" })
                .ToList();
            comboBoxLetezoCimBeallitasa.DisplayMember = "TeljesCim";
            comboBoxLetezoCimBeallitasa.ValueMember = "CimId";
        }
        private void FrissitCimMezoElerhetoseget()
        {
            bool ujCim = radioButtonUjCimBeallitasa.Checked;
            textBoxOrszag.Enabled = ujCim;
            textBoxIranyitoszam.Enabled = ujCim;
            textBoxVaros.Enabled = ujCim;
            textBoxUtca.Enabled = ujCim;
            textBoxHazszam.Enabled = ujCim;
            comboBoxLetezoCimBeallitasa.Enabled = !ujCim;
        }
        private void buttonMegse_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void buttonUjElemHozzaadasa_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;
            if (radioButtonUjCimBeallitasa.Checked)
            {
                SzerkesztettCim = new Cim
                {
                    Orszag = textBoxOrszag.Text,
                    Iranyitoszam = textBoxIranyitoszam.Text,
                    Varos = textBoxVaros.Text,
                    Utca = textBoxUtca.Text,
                    Hazszam = textBoxHazszam.Text
                };
                _context.Cim.Add(SzerkesztettCim);
            }
            else if (radioButtonLetezoCimBeallitasa.Checked)
            {
                int cimId = (int)comboBoxLetezoCimBeallitasa.SelectedValue;
                SzerkesztettCim = _context.Cim.Find(cimId);
            }
            ugyfelBindingSource.EndEdit();
            _context.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void radioButtonLetezoCimBeallitasa_CheckedChanged(object sender, EventArgs e)
        {
            FrissitCimMezoElerhetoseget();
        }
        private void radioButtonUjCimBeallitasa_CheckedChanged(object sender, EventArgs e)
        {
            FrissitCimMezoElerhetoseget();
        }
        private void textBoxNev_Validating(object sender, CancelEventArgs e)
        {
            ValidalTextBox(textBoxNev, @"^[\p{L} .'-]+$", "A név csak betűket tartalmazhat.", e);
        }
        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidalTextBox(textBoxEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", "Kérjük, adjon meg egy érvényes email címet.", e);
        }
        private void textBoxTelefonszam_Validating(object sender, CancelEventArgs e)
        {
            ValidalTextBox(textBoxTelefonszam, @"^\+36(?:20|30|31|50|70)(\d{7})$", "Kérjük, adjon meg egy érvényes magyar mobilszámot.", e);
        }
        private void textBoxIranyitoszam_Validating(object sender, CancelEventArgs e)
        {
            ValidalTextBox(textBoxIranyitoszam, @"^\d{4}$", "Kérjük, adjon meg egy 4 számjegyű irányítószámot.", e);
        }
        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                _errorProvider.SetError(tb, "Ez a mező kötelező.");
                e.Cancel = true;
            }
            else
            {
                _errorProvider.SetError(tb, "");
            }
        }
        private void ValidalTextBox(TextBox textBox, string pattern, string errorMessage, CancelEventArgs e)
        {
            Regex regex = new Regex(pattern);
            if (string.IsNullOrEmpty(textBox.Text) || !regex.IsMatch(textBox.Text))
            {
                _errorProvider.SetError(textBox, errorMessage);
                e.Cancel = true;
            }
            else
            {
                _errorProvider.SetError(textBox, "");
            }
        }
    }
}
