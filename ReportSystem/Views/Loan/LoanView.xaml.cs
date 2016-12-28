using ReportSystem.Models;
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
    /// Interaction logic for LoanView.xaml
    /// </summary>
    public partial class LoanView : UserControl
    {
        public LoanView()
        {
            InitializeComponent();
            this.grid.ItemsSourceChanged += Grid_ItemsSourceChanged;
        }

        private void Grid_ItemsSourceChanged(object sender, DevExpress.Xpf.Grid.ItemsSourceChangedEventArgs e)
        {
            int dataRowCount = ((System.Collections.ObjectModel.ObservableCollection<LoanCreditorItemModel>)e.NewItemsSource).Count();
            for (int rowHandle = 0; rowHandle < dataRowCount; rowHandle++)
                grid.ExpandMasterRow(rowHandle);
            this.grid.ItemsSourceChanged -= Grid_ItemsSourceChanged;
        }

        private void gridDetail_CustomColumnDisplayText(object sender, DevExpress.Xpf.Grid.CustomColumnDisplayTextEventArgs e)
        {
            if (this.gridDetail.Columns.GetColumnByFieldName("LoanStatus").CellTemplate == null)
            {
                this.gridDetail.Columns.GetColumnByFieldName("LoanStatus").CellTemplate = (DataTemplate)Resources["LoanStatusCellTemplate"];
            }
        }
    }
}
