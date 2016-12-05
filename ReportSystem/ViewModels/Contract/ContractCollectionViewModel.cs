using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class ContractCollectionViewModel: CollectionViewModel<ContractItemModel>
    {

        private INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        public void Nav(object obj)
        {
            NavigationService.Navigate("ContractView", obj, this);
        }


        public void AddItem()
        {
            NavigationService.Navigate("ContractView", null, this);
        }
    }
}