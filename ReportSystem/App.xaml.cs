using DevExpress.Xpf.Core;
using ReportSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ReportSystem
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            ExceptionHelper.Initialize();
            DevExpress.Images.ImagesAssemblyLoader.Load();
            ThemeManager.ApplicationThemeName = Theme.Office2013Name;
        }

        private void OnAppStartup_UpdateThemeName(object sender, StartupEventArgs e)
        {

            DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName();
        }
    }
}
