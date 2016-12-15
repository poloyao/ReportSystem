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
    /// Interaction logic for CompanyStockholderView.xaml
    /// </summary>
    public partial class CompanyStockholderView : UserControl
    {
        public CompanyStockholderView()
        {
            InitializeComponent();
        }

        private void TableView_InitNewRow(object sender, DevExpress.Xpf.Grid.InitNewRowEventArgs e)
        {
            grid.SetCellValue(e.RowHandle, "Info1", "123123");
        }
    }
}
