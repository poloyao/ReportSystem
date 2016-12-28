using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;
using System.Collections.Generic;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class ContractCollectionViewModel: CollectionViewModel<ContractItemModel>
    {

        private INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        //查询用

        public virtual string QProjectNo { get; set; }
        public virtual string QWaranteeMan { get; set; }

        public void Nav(object obj)
        {
            NavigationService.Navigate("ContractView", obj, this);
        }


        public void AddItem()
        {
            NavigationService.Navigate("ContractView", null, this);
        }
        
        public void QueryItems()
        {
            //Dictionary<>
        }

        public void QueryClear()
        {
            this.QProjectNo = string.Empty;
            this.QWaranteeMan = string.Empty;
        }
    }
}