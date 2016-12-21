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


namespace ReportSystem.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : DXWindow
    {
        public LoginWindow()
        {
            InitializeComponent();
            //this.DataContext = new ViewModels.LoginWindowViewModel();
            (this.DataContext as ViewModels.LoginWindowViewModel).LoginSucess += LoginWindowViewModel_LoginSucess;
        }
        
        private void LoginWindowViewModel_LoginSucess(object sender, EventArgs e)
        {
            var win = new MainWindow();
            this.Close();
            win.Show();
        }
    }
}
