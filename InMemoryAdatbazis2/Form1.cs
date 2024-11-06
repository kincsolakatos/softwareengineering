using InMemoryAdatbazis2.Models;
using System.ComponentModel;

namespace InMemoryAdatbazis2
{
    public partial class Form1 : Form
    {
        BindingList<Models.Students> students = new BindingList<Models.Students>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = studentsBindingSource;
            studentsBindingSource.DataSource = students;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
            foreach (var student in students)
            {
                streamWriter.WriteLine($"{student.Neptun};{student.Name};{student.BirthDate};{student.AverageGrade};{student.IsActive}");
            }
            streamWriter.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            StreamReader streamReader = new StreamReader(openFileDialog.FileName);
            while (!streamReader.EndOfStream)
            {
                Students s = new Students();
                string[] sor = streamReader.ReadLine().Split(';');
                s.Neptun = sor[0];
                s.Name = sor[1];
                try
                {
                    s.BirthDate = Convert.ToDateTime(sor[2]);
                }
                catch { }
                try
                {
                    s.AverageGrade = decimal.Parse(sor[3]);
                }
                catch { }
                s.IsActive = bool.Parse(sor[4]);
                students.Add(s);
            }
        }
    }
}
