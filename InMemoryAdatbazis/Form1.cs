using InMemoryAdatbazis.Models;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
namespace InMemoryAdatbazis
{
    public partial class Form1 : Form
    {
        BindingList<Student> students = new();
        public Form1()
        {
            InitializeComponent();
            studentBindingSource.DataSource = students;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            students.Add(new Student { Name = "Lakatos Kincsõ", Neptun = "IASR1J", IsActive = true });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Filter = "CSV fájlok (*.csv)|*.csv",
                DefaultExt = "csv",
                AddExtension = true
            };
            if (sfd.ShowDialog() != DialogResult.OK) return;
            using StreamWriter sw = new(sfd.FileName, false, Encoding.UTF8);
            foreach (var s in students)
            {
                sw.WriteLine($"{s.Neptun};{s.Name};{s.BirthDate};{s.AverageGrade};{s.IsActive}");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath,
                Filter = "CSV fájlok (*.csv)|*.csv",
                DefaultExt = "csv",
                AddExtension = true
            };
            if (ofd.ShowDialog() != DialogResult.OK) return;
            using StreamReader sr = new(ofd.FileName, Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                var data = sr.ReadLine().Split(';');
                students.Add(new Student
                {
                    Neptun = data[0],
                    Name = data[1],
                    BirthDate = DateTime.TryParse(data[2], out var date) ? date : (DateTime?)null,
                    AverageGrade = decimal.TryParse(data[3], out var grade) ? grade : (decimal?)null,
                    IsActive = bool.TryParse(data[4], out var active) && active
                });
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            using FormNewUser formNewUser = new();
            MessageBox.Show(formNewUser.ShowDialog() == DialogResult.OK ? "OK-val zárult" : "Nem OK-val zárult");
        }
    }
}