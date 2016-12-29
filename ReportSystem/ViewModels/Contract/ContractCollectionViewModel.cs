using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;
using System.Collections.Generic;
using ReportSystem.Models.Query;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class ContractCollectionViewModel: CollectionQueryViewModel<ContractItemModel, QueryContractModel>
    {

        private INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
        
        public virtual ContractItemModel SelectItem { get; set; }

        public virtual bool IsDataPaneVisible { get; set; } = true;
        public void lala()
        {
            IsDataPaneVisible = !IsDataPaneVisible;
        }


        public void Nav(object obj)
        {
            NavigationService.Navigate("ContractView", obj, this);
        }


        public void AddItem()
        {
            NavigationService.Navigate("ContractView", null, this);
        }

        public void OnShowPanel()
        {
            IsDataPaneVisible = true;
        }

        public void OnClosePanel()
        {
            IsDataPaneVisible = false;
        }


    }
}