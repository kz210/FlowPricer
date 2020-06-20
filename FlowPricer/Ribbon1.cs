using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using FlowPricer.Utilities;


namespace FlowPricer
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            Worksheet currentSheet = Globals.ThisAddIn.GetActiveWorksheet();
            currentSheet.Range["A1"].Value = "Hello World";
            currentSheet.Columns.AutoFit();
            double cdsValue = currentSheet.get_Range("B5", "B5").Value2;
            currentSheet.Range["A1"].Value = 2 * cdsValue;
        }

        private void button1_Click_1(object sender, RibbonControlEventArgs e)
        {
            Worksheet currentSheet = Globals.ThisAddIn.GetActiveWorksheet();
            currentSheet.Range["A2"].Value = "100 %";
            Range range = currentSheet.get_Range("A4", currentSheet.get_Range("A4").End[XlDirection.xlDown]);
            double[] ead = range.ToNet1DimArray(x => (double) (x ?? 0d));
            range = currentSheet.get_Range("B2", currentSheet.get_Range("C2").End[XlDirection.xlDown]);
            double[,] SwapRatesCurve = range.ToNet2DimArray(x => (double)(x ?? 0d)); 

            currentSheet.Columns.AutoFit();
        }
    }
}
