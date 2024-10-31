using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using Rendeles_Forms_IASR1J.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Excel;

namespace Rendeles_Forms_IASR1J
{
    public class ExcelExport
    {
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlRendelesSheet;
        RendelesDbContext _context;
        public ExcelExport()
        {
            this._context = new RendelesDbContext();
    }
        public void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlRendelesSheet = xlWB.ActiveSheet;
                CreateTable();
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }
        public void CreateTable()
        {
            string[] fejlecek = new string[]
            {
                "ID",
                "Ugyfel",
                "Iranyitoszam",
                "Varos",
                "Utca",
                "Hazszam",
                "Rendeles datum",
                "Statusz",
                "Kedvezmeny",
                "Vegosszeg"
            };
            for (int i = 0; i < fejlecek.Length; i++)
            {
                xlRendelesSheet.Cells[1, 1] = fejlecek[0];
            }
            var rendelesek = _context.Rendeles
                .Include(x => x.SzallitasiCim)
                .Include(x => x.Ugyfel)
                .ToList();
            object[,] adatTomb = new object[rendelesek.Count(), fejlecek.Count()];
            for (int i = 0; i < rendelesek.Count;  i++)
            {
                adatTomb[i, 0] = rendelesek[i].RendelesId;
                adatTomb[i, 1] = rendelesek[i].Ugyfel.Nev;
                adatTomb[i, 2] = rendelesek[i].SzallitasiCim.Iranyitoszam;
                adatTomb[i, 3] = rendelesek[i].SzallitasiCim.Varos;
                adatTomb[i, 4] = rendelesek[i].SzallitasiCim.Utca;
                adatTomb[i, 5] = rendelesek[i].SzallitasiCim.Hazszam;
                adatTomb[i, 6] = rendelesek[i].RendelesDatum.ToString("yyyy-MM-dd HH:mm:ss");
                adatTomb[i, 7] = rendelesek[i].Statusz;
                adatTomb[i, 8] = rendelesek[i].Kedvezmeny.ToString("P");
                adatTomb[i, 9] = rendelesek[i].Vegosszeg.ToString("C0");
            }
            int sorokSzama = adatTomb.GetLength(0);
            int oszlopokSzama = adatTomb.GetLength(1);
            Excel.Range adatRange = xlRendelesSheet.get_Range("A2", Type.Missing).get_Resize(sorokSzama, oszlopokSzama);
            adatRange.Value2 = adatTomb;
            adatRange.Columns.AutoFit();
            FormatTable();
            void FormatTable()
            {
                Excel.Range fejlecRange = xlRendelesSheet.get_Range("A1", Type.Missing).get_Resize(1, 10);
                fejlecRange.Font.Bold = true;
                fejlecRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                fejlecRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                fejlecRange.EntireColumn.AutoFit();
                fejlecRange.RowHeight = 40;
                fejlecRange.Interior.Color = Color.Fuchsia;
                fejlecRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
                Excel.Range teljesRange = xlRendelesSheet.get_Range("A1", GetCell(sorokSzama + 1, oszlopokSzama));
                teljesRange.BorderAround2(XlLineStyle.xlContinuous, XlBorderWeight.xlThick);
                Excel.Range elsoOszlop = xlRendelesSheet.get_Range("A2", GetCell(sorokSzama + 1, 1));
                elsoOszlop.Font.Bold = true;
                elsoOszlop.Interior.Color = Color.LightYellow;
                Excel.Range vegosszegOszlop = xlRendelesSheet.get_Range(GetCell(2, 10), GetCell(sorokSzama + 1, 10));
                vegosszegOszlop.Interior.Color = Color.LightSeaGreen;
                vegosszegOszlop.NumberFormat = "#,##0.00";
            }
        }
        
        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;
            while(dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();
            return ExcelCoordinate;
        }
    }
    
}
