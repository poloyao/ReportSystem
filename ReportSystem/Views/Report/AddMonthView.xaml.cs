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
using DevExpress.Xpf.LayoutControl;
using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet;

namespace ReportSystem.Views
{
    /// <summary>
    /// Interaction logic for AddMonthView.xaml
    /// </summary>
    public partial class AddMonthView : UserControl
    {
        public AddMonthView()
        {
            InitializeComponent();
            var workbook = spreadsheet.Document;
            workbook.LoadDocument("Documents\\Month.xls");
            Worksheet worksheet = workbook.Worksheets[0];
            workbook.Worksheets.ActiveWorksheet = worksheet;
            spreadsheet.CellValueChanged += Spreadsheet_CellValueChanged;
        }

        private void Spreadsheet_CellValueChanged(object sender, SpreadsheetCellEventArgs e)
        {
            if ( e.RowIndex == 7)
                return;
            e.Cell.Value = e.OldValue;
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

        private void Open4Task_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            var workbook = spreadsheet.Document;
            workbook.Worksheets.ActiveWorksheet = workbook.Worksheets[3]; ;
        }






        //private void ShowAs_Checked(object sender, RoutedEventArgs e)
        //{
        //    if (groupContainer == null)
        //        return;
        //    LayoutGroupView containerView, childView;
        //    if (sender == checkShowAsGroupBoxes)
        //    {
        //        containerView = LayoutGroupView.GroupBox;
        //        childView = LayoutGroupView.GroupBox;
        //    }
        //    else
        //        if (sender == checkShowAsTabs)
        //    {
        //        containerView = LayoutGroupView.Tabs;
        //        childView = LayoutGroupView.Group;
        //    }
        //    else
        //        return;
        //    groupContainer.View = containerView;
        //    foreach (FrameworkElement child in groupContainer.GetLogicalChildren(false))
        //        if (child is LayoutGroup)
        //            ((LayoutGroup)child).View = childView;
        //}
    }
}
