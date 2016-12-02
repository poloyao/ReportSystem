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
    /// Interaction logic for ProjectCollectionView.xaml
    /// </summary>
    public partial class ProjectCollectionView : UserControl
    {
        public ProjectCollectionView()
        {
            InitializeComponent();
        }

        private void tableView_RowDoubleClick(object sender, DevExpress.Xpf.Grid.RowDoubleClickEventArgs e)
        {
            //if (grid.SelectedItem == null)
            //    return;
            //var frame = DevExpress.Xpf.Core.Native.LayoutHelper.FindParentObject<DevExpress.Xpf.WindowsUI.NavigationFrame>(this);
            //ProjectSingleView view = new ProjectSingleView();
            //frame.Navigate(view);
        }
    }
}
