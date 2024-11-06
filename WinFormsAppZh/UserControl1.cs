using WinFormsAppZh.Data;

namespace WinFormsAppZh
{
    public partial class UserControl1 : UserControl
    {
        RendelesDbContext context;
        public UserControl1()
        {
            InitializeComponent();
            using var context = new RendelesDbContext();
            dataGridView1.DataSource = context.Rendeles.Select(r => new
            {
                r.RendelesId,
                Ugyfel = r.Ugyfel.Nev,
                SzallitasiCim = $"{r.SzallitasiCim.Varos}, {r.SzallitasiCim.Utca} {r.SzallitasiCim.Hazszam}, {r.SzallitasiCim.Iranyitoszam}, {r.SzallitasiCim.Orszag}",
                r.RendelesDatum,
                r.Statusz,
                r.Kedvezmeny,
                r.Vegosszeg
            }).ToList();
        }
    }
}
