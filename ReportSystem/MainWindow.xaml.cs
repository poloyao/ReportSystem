using DevExpress.Xpf.Ribbon;
using DevExpress.Xpf.WindowsUI;
using DevExpress.Xpf.WindowsUI.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ReportSystem
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : DXRibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            if (Height > SystemParameters.VirtualScreenHeight || Width > SystemParameters.VirtualScreenWidth)
                WindowState = WindowState.Maximized;
            DevExpress.Utils.About.UAlgo.Default.DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWPF, this);
        }

        private void navPanelView_NavPaneExpandedChanged(object sender, DevExpress.Xpf.NavBar.NavPaneExpandedChangedEventArgs e)
        {
            layoutPanel.ItemWidth = GridLength.Auto;
        }

        private void navPanelView_NavPaneExpandedChanging(object sender, DevExpress.Xpf.NavBar.NavPaneExpandedChangingEventArgs e)
        {
            navPanelView.Expander.MaxWidth = e.IsExpanded ? Double.PositiveInfinity : navPanelView.Expander.ActualWidth;
        }

        void OnDocumentFrameNavigating(object sender, NavigatingEventArgs e)
        {
            if (e.Cancel) return;
            NavigationFrame frame = (NavigationFrame)sender;
            FrameworkElement oldContent = (FrameworkElement)frame.Content;
            if (oldContent != null)
            {
                RibbonMergingHelper.SetMergeWith(oldContent, null);
                RibbonMergingHelper.SetMergeStatusBarWith(oldContent, null);
            }
        }
        void OnDocumentFrameNavigated(object sender, NavigationEventArgs e)
        {
            FrameworkElement newContent = (FrameworkElement)e.Content;
            if (newContent != null)
            {
                RibbonMergingHelper.SetMergeWith(newContent, ribbon);
               // RibbonMergingHelper.SetMergeStatusBarWith(newContent, statusBar);
            }
        }
    }
}
