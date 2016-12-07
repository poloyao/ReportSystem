using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class LoanCollocationViewModel: CollectionViewModel<LoanItemModel>
    {
        private INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        public void Nav(object obj)
        {
            NavigationService.Navigate("LoanView", obj, this);
        }


        public void AddItem()
        {
            NavigationService.Navigate("LoanView", null, this);
        }
    }
}