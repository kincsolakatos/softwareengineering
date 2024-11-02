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
        private Excel.Application xlApp;
        private Excel.Workbook xlWB;
        private Excel.Worksheet xlRendelesSheet;
        private RendelesDbContext _context;
        public ExcelExport()
        {
            _context = new RendelesDbContext();
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
                MessageBox.Show($"Error: {ex.Message}\nSource: {ex.Source}", "Error");
                xlWB?.Close(false);
                xlApp?.Quit();
            }
        }
        public void CreateTable()
        {
            try
            {
                string[] fejlecek = { "ID", "Ugyfel", "Iranyitoszam", "Varos", "Utca", "Hazszam", "Rendeles datum", "Statusz", "Kedvezmeny", "Vegosszeg" };
                for (int i = 0; i < fejlecek.Length; i++)
                {
                    xlRendelesSheet.Cells[1, i + 1] = fejlecek[i];
                }
                var rendelesek = _context.Rendeles
                    .Include(x => x.SzallitasiCim)
                    .Include(x => x.Ugyfel)
                    .ToList();
                object[,] adatTomb = new object[rendelesek.Count, fejlecek.Length];
                for (int i = 0; i < rendelesek.Count; i++)
                {
                    var rendeles = rendelesek[i];
                    adatTomb[i, 0] = rendeles.RendelesId;
                    adatTomb[i, 1] = rendeles.Ugyfel?.Nev ?? "N/A";
                    adatTomb[i, 2] = rendeles.SzallitasiCim?.Iranyitoszam ?? "N/A";
                    adatTomb[i, 3] = rendeles.SzallitasiCim?.Varos ?? "N/A";
                    adatTomb[i, 4] = rendeles.SzallitasiCim?.Utca ?? "N/A";
                    adatTomb[i, 5] = rendeles.SzallitasiCim?.Hazszam ?? "N/A";
                    adatTomb[i, 6] = rendeles.RendelesDatum.ToString("yyyy-MM-dd HH:mm:ss");
                    adatTomb[i, 7] = rendeles.Statusz;
                    adatTomb[i, 8] = rendeles.Kedvezmeny.ToString("P");
                    adatTomb[i, 9] = rendeles.Vegosszeg.ToString("C0");
                }
                int sorokSzama = adatTomb.GetLength(0);
                int oszlopokSzama = adatTomb.GetLength(1);
                Excel.Range adatRange = xlRendelesSheet.Range["A2"].Resize[rendelesek.Count, fejlecek.Length];
                adatRange.Value2 = adatTomb;
                adatRange.Columns.AutoFit();
                FormatTable(rendelesek.Count, fejlecek.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in CreateTable: {ex.Message}");
            }
        }
        private void FormatTable(int sorokSzama, int oszlopokSzama)
        {
            Excel.Range fejlecRange = xlRendelesSheet.Range["A1"].Resize[1, oszlopokSzama];
            fejlecRange.Font.Bold = true;
            fejlecRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            fejlecRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            fejlecRange.EntireColumn.AutoFit();
            fejlecRange.RowHeight = 40;
            fejlecRange.Interior.Color = Color.Fuchsia;
            fejlecRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
            Excel.Range teljesRange = xlRendelesSheet.Range["A1", GetCell(sorokSzama + 1, oszlopokSzama)];
            teljesRange.BorderAround2(XlLineStyle.xlContinuous, XlBorderWeight.xlThick);
            Excel.Range elsoOszlop = xlRendelesSheet.Range["A2", GetCell(sorokSzama + 1, 1)];
            elsoOszlop.Font.Bold = true;
            elsoOszlop.Interior.Color = Color.LightYellow;
            Excel.Range vegosszegOszlop = xlRendelesSheet.Range[GetCell(2, oszlopokSzama), GetCell(sorokSzama + 1, oszlopokSzama)];
            vegosszegOszlop.Interior.Color = Color.LightSeaGreen;
            vegosszegOszlop.NumberFormat = "#,##0.00";
        }
        private string GetCell(int row, int col)
        {
            string cell = "";
            int dividend = col;
            while(dividend > 0)
            {
                int modulo = (dividend - 1) % 26;
                cell = Convert.ToChar(65 + modulo).ToString() + cell;
                dividend = (dividend - modulo) / 26;
            }
            return cell + row;
        }
    }
}
