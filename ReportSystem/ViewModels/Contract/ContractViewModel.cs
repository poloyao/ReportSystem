using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;
using DevExpress.Mvvm.POCO;
using System.Linq;
using System.Collections.ObjectModel;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class ContractViewModel: SingleViewModel<ContractItemModel>
    {
        public virtual ContractItemModel Content { get; set; }

        public virtual WarranteeItemModel MainWarrantee { get; set; }

        public virtual ObservableCollection<WarranteeItemModel> ItemSource { get; set; } = new ObservableCollection<WarranteeItemModel>();

        public virtual WarranteeItemModel SelectItem { get; set; }

        private INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }


        public virtual bool IsReadOnly { get; set; } = false;

        public static ContractViewModel Create()
        {
            return ViewModelSource.Create(() => new ContractViewModel());
        }

        protected ContractViewModel() 
        {

        }

        protected override void OnParameterChanged(object parameter)
        {
            base.OnParameterChanged(parameter);
            this.Content = base.ContentBase;
            if (Content != null && Content.WarranteeItems != null)
            {
                this.MainWarrantee = Content.WarranteeItems.SingleOrDefault(x => x.IsMain == true);
                this.ItemSource = new ObservableCollection<WarranteeItemModel>(Content.WarranteeItems);
                this.IsReadOnly = true;
            }
        }

        public void SelectRow(object id)
        {

        }

        public void GoBack()
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();
        }

    }
}