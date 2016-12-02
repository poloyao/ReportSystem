using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;
using DevExpress.Mvvm.POCO;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class ProjectCollectionViewModel: CollectionViewModel<ProjectItemModel>
    {
        private INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        public ProjectCollectionViewModel() { }

        public ProjectCollectionViewModel(object obj)
        {
        }

        [Command(true)]
        public void asdas(object obj)
        {
            //NavigationService.Navigate(new ProjectSingleViewModel(), null, this);
            // var frame = DevExpress.Xpf.Core.Native.LayoutHelper.FindParentObject<DevExpress.Xpf.WindowsUI.NavigationFrame>((System.Windows.DependencyObject)obj);
            //ISupportServices sup = (ISupportServices)this;
            //INavigationService navigationService = sup.GetRequiredService<INavigationService>();
            //navigationService.Navigate("ProjectSingleView", null, this);
            //NavigationService.Navigate("ProjectSingleView", obj, this);
            //NavigationService.Navigate("ProjectSingleView", new ProjectSingleViewModel(), obj, this,true);
            NavigationService.Navigate("ProjectSingleView", obj, this, true);
        }
    }
}