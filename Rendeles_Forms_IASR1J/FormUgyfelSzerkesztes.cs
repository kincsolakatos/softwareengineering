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
    public partial class FormUgyfelSzerkesztes : Form
    {
        public Ugyfel SzerkesztettUgyfel
        {
            get;
            set;
        }
        public FormUgyfelSzerkesztes(Ugyfel ugyfel = null)
        {
            InitializeComponent();
            this.SzerkesztettUgyfel = ugyfel ?? new Ugyfel();
            ugyfelBindingSource.DataSource = SzerkesztettUgyfel;

        }

        private void FormUgyfelSzerkesztes_Load(object sender, EventArgs e)
        {

        }

        private void buttonMegse_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonUjElemHozzaadasa_Click(object sender, EventArgs e)
        {
            ugyfelBindingSource.EndEdit();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
