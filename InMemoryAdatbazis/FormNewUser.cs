using System.ComponentModel;
using System.Text.RegularExpressions;
namespace InMemoryAdatbazis
{
    public partial class FormNewUser : Form
    {
        public FormNewUser() => InitializeComponent();
        private bool IsValidName(string name) => !string.IsNullOrWhiteSpace(name);
        private bool IsValidNeptun(string neptun) => Regex.IsMatch(neptun, "^[A-Z0-9]{6}$");
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !IsValidName(textBox1.Text);
            errorProvider1.SetError(textBox1, e.Cancel ? "A név nem lehet üres" : "");
        }
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !IsValidNeptun(textBox2.Text);
            errorProvider1.SetError(textBox2, e.Cancel ? "Érvénytelen Neptun kód" : "");
        }
    }
}