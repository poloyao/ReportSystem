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
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using System.Reflection;

namespace ReportSystem
{
    /// <summary>
    /// Interaction logic for SplashScreenWindow.xaml
    /// </summary>
    public partial class SplashScreenWindow : Window,ISplashScreen
    {
        public SplashScreenWindow()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            AssemblyCopyrightAttribute asmCioyright = (AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(asm, typeof(AssemblyCopyrightAttribute));
            Copyright = asmCioyright.Copyright;
            //Copyright = AssemblyInfo.AssemblyCopyright;
            InitializeComponent();
            this.board.Completed += OnAnimationCompleted;
        }

        public string Copyright { get; set; }

        #region ISplashScreen
        void ISplashScreen.Progress(double value)
        {
            progressBar.Value = value;
        }
        void ISplashScreen.CloseSplashScreen()
        {
            this.board.Begin(this);
            //this.Close();
        }
        void ISplashScreen.SetProgressState(bool isIndeterminate)
        {
            progressBar.IsIndeterminate = isIndeterminate;
        }
        #endregion

        #region Event Handlers
        void OnAnimationCompleted(object sender, EventArgs e)
        {
            this.board.Completed -= OnAnimationCompleted;
            this.Close();
        }
        #endregion
    }
}
