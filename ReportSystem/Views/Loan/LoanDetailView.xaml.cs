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
    /// Interaction logic for LoanDetailView.xaml
    /// </summary>
    public partial class LoanDetailView : UserControl
    {
        public LoanDetailView()
        {
            InitializeComponent();
        }

        private void GridControl_CustomColumnDisplayText(object sender, DevExpress.Xpf.Grid.CustomColumnDisplayTextEventArgs e)
        {
            //gridDetail
            if (e.Column.FieldName == "RelieveType")
            {
                e.DisplayText = Common.Data.SingleTypeCode.GetInstance().GetCommonCode(e.Value.ToString()).Name;
            }
        }

        private void grid_CustomColumnDisplayText(object sender, DevExpress.Xpf.Grid.CustomColumnDisplayTextEventArgs e)
        {
            if (this.grid.Columns.GetColumnByFieldName("LoanStatus").CellTemplate == null)
            {
                this.grid.Columns.GetColumnByFieldName("LoanStatus").CellTemplate = (DataTemplate)Resources["LoanStatusCellTemplate"];
            }
        }
    }
}
