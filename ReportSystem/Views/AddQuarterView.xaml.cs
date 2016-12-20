using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReportSystem.Views
{
    /// <summary>
    /// Interaction logic for AddQuarterView.xaml
    /// </summary>
    public partial class AddQuarterView : UserControl
    {
        public AddQuarterView()
        {
            InitializeComponent();
            var workbook = spreadsheet.Document;
            workbook.LoadDocument("Documents\\Quarter.xls");
            Worksheet worksheet = workbook.Worksheets[0];
            workbook.Worksheets.ActiveWorksheet = worksheet;
            spreadsheet.CellValueChanged += Spreadsheet_CellValueChanged;



        }

        private void Spreadsheet_CellValueChanged(object sender, DevExpress.XtraSpreadsheet.SpreadsheetCellEventArgs e)
        {
            if (e.Worksheet.Index == 0 && e.RowIndex == 7)
                return;
            else if (e.Worksheet.Index == 1 && e.RowIndex == 8)
                return;
            else if (e.Worksheet.Index == 2 && e.OldValue.ToString() != "——" && e.ColumnIndex > 1 && e.ColumnIndex < 6 && e.RowIndex > 7 && e.RowIndex < 31)
                return;
            e.Cell.Value = e.OldValue;

        }

        private void ShowAs_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Open1Task_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            var workbook = spreadsheet.Document;
            workbook.Worksheets.ActiveWorksheet = workbook.Worksheets[0]; ;
        }

        private void Open2Task_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            var workbook = spreadsheet.Document;
            workbook.Worksheets.ActiveWorksheet = workbook.Worksheets[1]; ;
        }

        private void Open3Task_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            var workbook = spreadsheet.Document;
            workbook.Worksheets.ActiveWorksheet = workbook.Worksheets[2]; ;
        }
    }
}
