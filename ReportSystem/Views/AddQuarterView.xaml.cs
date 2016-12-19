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
            if (e.RowIndex != 7)
            {
                e.Cell.Value = e.OldValue;
            }

        }

        private void ShowAs_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
