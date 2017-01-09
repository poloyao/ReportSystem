using DevExpress.Xpf.Core.Native;
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
    /// Interaction logic for ContractCollectionView.xaml
    /// </summary>
    public partial class ContractCollectionView : UserControl
    {
        public ContractCollectionView()
        {
            InitializeComponent();
        }

        private void ToExcel_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            ReportSystem.Common.Core.CreateTableViewToXlsx(this.tableView, Common.Core.FileOutputType.Contract);
        }

        private void ToWord_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {

        }

        private void Preview_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            string name = Common.Core.GetFileName(Common.Core.FileOutputType.Contract);
            DevExpress.Xpf.Printing.PrintableControlLink link = Common.Core.GetPrintableLink(this.tableView);
            link.ShowPrintPreviewDialog(LayoutHelper.FindParentObject<Window>(this));

            //Window owner = LayoutHelper.FindParentObject<Window>(this);
            //DevExpress.Xpf.Grid.Printing.PrintHelper.ShowPrintPreviewDialog(owner, this.tableView);
        }


    }
}
