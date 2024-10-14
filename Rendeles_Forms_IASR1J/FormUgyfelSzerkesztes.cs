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
        public Ugyfel SzerkesztettUgyfel
        {
            get;
            set;
        }
        public Cim SzerkesztettCim
        {
            get;
            set;
        }
        private RendelesDbContext _context;
        public FormUgyfelSzerkesztes(Ugyfel ugyfel = null, Cim cim = null)
        {
            InitializeComponent();
            _context = new RendelesDbContext();
            this.SzerkesztettUgyfel = ugyfel ?? new Ugyfel();
            ugyfelBindingSource.DataSource = SzerkesztettUgyfel;
            this.SzerkesztettCim = cim ?? new Cim();
            cimBindingSource.DataSource = SzerkesztettCim;

        }

        private void FormUgyfelSzerkesztes_Load(object sender, EventArgs e)
        {
            CimekBetoltese();
        }

        private void buttonMegse_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonUjElemHozzaadasa_Click(object sender, EventArgs e)
        {
            bool valid = this.ValidateChildren();
            if (valid)
            {
                Cim ujCim = new Cim();
                if (radioButtonUjCimBeallitasa.Checked)
                {
                    ujCim = new Cim
                    {
                        Utca = textBoxUtca.Text,
                        Hazszam = textBoxHazszam.Text,
                        Varos = textBoxVaros.Text,
                        Iranyitoszam = textBoxIranyitoszam.Text,
                        Orszag = textBoxOrszag.Text,
                    };
                    _context.Cim.Add(ujCim);
                    _context.SaveChanges();
                    this.SzerkesztettCim = ujCim;
                }
                else if (radioButtonLetezoCimBeallitasa.Checked)
                {
                    var cimId = (int)comboBoxLetezoCimBeallitasa.SelectedValue;
                    this.SzerkesztettCim = _context.Cim.Find(cimId);
                }
                ugyfelBindingSource.EndEdit();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Kerjuk, javitsa a hibas mezoket!");
                return;
            }
        }

        ErrorProvider errorProvider = new ErrorProvider();
        private void textBoxNev_Validating(object sender, CancelEventArgs e)
        {
            Regex regexNev = new Regex(@"^[\p{L} .'-]+$");
            if (string.IsNullOrWhiteSpace(textBoxNev.Text) || !regexNev.IsMatch(textBoxNev.Text))
            {
                errorProvider.SetError(textBoxNev, "A nev csak kis es nagybetuket jelenithet meg.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBoxNev, "");
            }
        }
        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex regexEmail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) || !regexEmail.IsMatch(textBoxEmail.Text))
            {
                errorProvider.SetError(textBoxEmail, "Kerjuk, adjon meg egy ervenyes email cimet.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBoxEmail, "");
            }
        }
        private void textBoxTelefonszam_Validating(object sender, CancelEventArgs e)
        {
            Regex regexTelefonszam = new Regex(@"^\+36(?:20|30|31|50|70)(\d{7})$");
            if (string.IsNullOrWhiteSpace(textBoxTelefonszam.Text) || !regexTelefonszam.IsMatch(textBoxTelefonszam.Text))
            {
                errorProvider.SetError(textBoxTelefonszam, "Kerjuk, adjon meg egy ervenyes magyar mobilszamot.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBoxTelefonszam, "");
            }
        }
        private void CimekBetoltese()
        {
            var cimek = _context.Cim.Select(c => new
            {
                c.CimId,
                TeljesCim = c.Varos + " " + c.Utca + " " + c.Hazszam + ". " + c.Iranyitoszam + ", " + c.Orszag
            }).ToList();
            comboBoxLetezoCimBeallitasa.DataSource = cimek;
            comboBoxLetezoCimBeallitasa.DisplayMember = "TeljesCim";
            comboBoxLetezoCimBeallitasa.ValueMember = "CimId";
        }

        private void radioButtonLetezoCimBeallitasa_CheckedChanged(object sender, EventArgs e)
        {
            bool letezoCim = radioButtonLetezoCimBeallitasa.Checked;

            comboBoxLetezoCimBeallitasa.Enabled = letezoCim;
            textBoxOrszag.Enabled = !letezoCim;
            textBoxIranyitoszam.Enabled = !letezoCim;
            textBoxVaros.Enabled = !letezoCim;
            textBoxUtca.Enabled = !letezoCim;
            textBoxHazszam.Enabled = !letezoCim;
        }
        private void radioButtonUjCimBeallitasa_CheckedChanged(object sender, EventArgs e)
        {
            bool ujCim = radioButtonUjCimBeallitasa.Checked;
            textBoxOrszag.Enabled = ujCim;
            textBoxIranyitoszam.Enabled = ujCim;
            textBoxVaros.Enabled = ujCim;
            textBoxUtca.Enabled = ujCim;
            textBoxHazszam.Enabled = ujCim;
            comboBoxLetezoCimBeallitasa.Enabled = !ujCim;
        }
        private void textBoxUtca_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUtca.Text))
            {
                errorProvider.SetError(textBoxUtca, "Az utca mező kitöltése kötelező.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBoxUtca, "");
            }
        }

        private void textBoxHazszam_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxHazszam.Text))
            {
                errorProvider.SetError(textBoxHazszam, "A házszám mező kitöltése kötelező.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBoxHazszam, "");
            }
        }

        private void textBoxVaros_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxVaros.Text))
            {
                errorProvider.SetError(textBoxVaros, "A város mező kitöltése kötelező.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBoxVaros, "");
            }
        }

        private void textBoxIranyitoszam_Validating(object sender, CancelEventArgs e)
        {
            Regex regexIranyitoszam = new Regex(@"^\d{4}$");
            if (string.IsNullOrWhiteSpace(textBoxIranyitoszam.Text) || !regexIranyitoszam.IsMatch(textBoxIranyitoszam.Text))
            {
                errorProvider.SetError(textBoxIranyitoszam, "Kérjük, adjon meg egy érvényes irányítószámot (4 számjegy).");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBoxIranyitoszam, "");
            }
        }

        private void textBoxOrszag_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxOrszag.Text))
            {
                errorProvider.SetError(textBoxOrszag, "Az ország mező kitöltése kötelező.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBoxOrszag, "");
            }
        }
        
        
    }
}
