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
    /// Interaction logic for AddYearView.xaml
    /// </summary>
    public partial class AddYearView : UserControl
    {
        public AddYearView()
        {
            InitializeComponent();
            var workbook = spreadsheet.Document;
            workbook.LoadDocument("Documents\\Year.xls");
            Worksheet worksheet = workbook.Worksheets[0];
            workbook.Worksheets.ActiveWorksheet = worksheet;
            spreadsheet.CellValueChanged += Spreadsheet_CellValueChanged;

            
        }

        private void Spreadsheet_CellValueChanged(object sender, DevExpress.XtraSpreadsheet.SpreadsheetCellEventArgs e)
        {
            
        }

        private void Open1Task_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {

        }
    }
}
