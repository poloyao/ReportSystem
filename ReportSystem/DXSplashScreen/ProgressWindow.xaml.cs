using DevExpress.Xpf.Core;
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

namespace ReportSystem.DXSplashScreen
{
    /// <summary>
    /// ProgressWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ProgressWindow : Window, ISplashScreen
    {
        public ProgressWindow()
        {
            InitializeComponent();
        }

        void ISplashScreen.CloseSplashScreen()
        {
            this.board.Begin(this);
            this.Close();
        }

        void ISplashScreen.Progress(double value)
        {
        }

        void ISplashScreen.SetProgressState(bool isIndeterminate)
        {
        }
        #region Event Handlers
        void OnAnimationCompleted(object sender, EventArgs e)
        {
            this.board.Completed -= OnAnimationCompleted;
            this.Close();
        }
        #endregion
    }
}
