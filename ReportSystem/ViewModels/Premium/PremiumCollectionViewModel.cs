using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class PremiumCollectionViewModel : CollectionViewModel<PremiumCollectionItemModel>
    {
        private INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        public void Nav(object obj)
        {
            NavigationService.Navigate("PremiumView", obj, this);
        }

    }
}