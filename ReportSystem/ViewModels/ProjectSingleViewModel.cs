using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class ProjectSingleViewModel
    {
        private INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
        public ProjectSingleViewModel()
        {
            var ssss = NavigationService.GetParentViewModel<ProjectCollectionViewModel>();
            var dddd = ssss.SelectedItem;
        }

        public ProjectSingleViewModel(object ds)
        {

        }
    }
}