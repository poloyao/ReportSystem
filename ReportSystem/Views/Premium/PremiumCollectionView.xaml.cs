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
    /// Interaction logic for PremiumCollectionView.xaml
    /// </summary>
    public partial class PremiumCollectionView : UserControl
    {
        public PremiumCollectionView()
        {
            InitializeComponent();
        }

        private void grid_CustomColumnDisplayText(object sender, DevExpress.Xpf.Grid.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "PremiumStatus")
            {
                e.DisplayText = Common.Data.SingleTypeCode.GetInstance().GetCommonCode(e.Value.ToString()).Name;
            }
        }

        private void Preview_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {

        }

        private void ToExcel_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {

        }
    }
}
