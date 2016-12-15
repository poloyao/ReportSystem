using ReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using ReportSystem.DXSplashScreen;
using System.ComponentModel.DataAnnotations;


namespace ReportSystem.ViewModels
{
    public class MainWindowViewModel
    {

        public MainWindowViewModel()
        {
            SplashScreenType = typeof(SplashScreenWindow);

            List<ModuleInfo> modules = new List<ModuleInfo>()
            {
                 ViewModelSource.Create(()=>new ModuleInfo("ProjectCollectionView",this,"项目列表")).SetIcon("GridContacts"),
                 ViewModelSource.Create(()=>new ModuleInfo("ContractCollectionView",this,"合同列表")).SetIcon("GridContacts"),
                 ViewModelSource.Create(()=>new ModuleInfo("LoanCollocationView",this,"放款")).SetIcon("GridContacts"),
                 ViewModelSource.Create(()=>new ModuleInfo("PremiumCollectionView",this,"保费信息")).SetIcon("GridContacts"),
                 ViewModelSource.Create(()=>new ModuleInfo("ReportCollectionView",this,"报表信息")).SetIcon("GridContacts"),
                 ViewModelSource.Create(()=>new ModuleInfo("CompanySettingView",this,"设置")).SetIcon("GridContacts")

            };
            ModuleGroups = new ModuleGroup[] {
                new ModuleGroup("功能",modules)
            };
        }


        public virtual Type SplashScreenType { get; set; }
        public virtual IEnumerable<ModuleGroup> ModuleGroups { get; protected set; }

        public virtual ModuleInfo SelectedModuleInfo { get; set; }

        //[Required]
        //protected virtual INavigationService NavigationService { get { return null; } }
        [Required]
        protected virtual ICurrentWindowService CurrentWindowService { get { return null; } }

        public virtual int DefaultBackstatgeIndex { get; set; }

        public virtual bool HasPrinting { get; set; }
        public virtual bool IsBackstageOpen { get; set; }


        public void OnModulesLoaded()
        {
            if (SelectedModuleInfo == null)
            {
                SelectedModuleInfo = ModuleGroups.First().ModuleInfos.First();
                SelectedModuleInfo.IsSelected = true;
                SelectedModuleInfo.Show();
            }
            SplashScreenType = typeof(ProgressWindow);

        }

        protected virtual void OnSelectedModuleInfoChanged()
        {
            // PrintingService.PreviewModelAction = null;
        }

        protected virtual void OnIsBackstageOpenChanged()
        {
            // HasPrinting = PrintingService.HasPrinting;
            if (!HasPrinting && DefaultBackstatgeIndex == 1)
                DefaultBackstatgeIndex = 0;
        }
    }
}
