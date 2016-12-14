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

        protected IDocumentManagerService documentManagerService { get { return this.GetService<IDocumentManagerService>(); } }


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

        

        public void GoBack()
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();
        }

        public void SelectRow(object id)
        {
            var vm = WarranteeViewModel.Create();
            IDocument doc = documentManagerService.FindDocument(vm);
            if (doc == null)
            {
                doc = documentManagerService.CreateDocument("WarranteeView", id, vm);
                doc.Id = documentManagerService.Documents.Count();
                doc.Title = "新增被担保人信息";
            }
            //((WarranteeViewModel)doc.Content).IsRead = true;
            doc.Show();
            var docVM = (WarranteeViewModel)doc.Content;
            if (docVM.IsChange)
            {
                var query = Content.WarranteeItems.Single(x => x.ID == docVM.Content.ID);
                query = docVM.Content;
                var querySource = ItemSource.Single(x => x.ID == docVM.Content.ID);
                ItemSource.Remove(querySource);
                ItemSource.Add(docVM.Content);
            }
        }

        public void AddItem()
        {
            var vm = WarranteeViewModel.Create();
            IDocument doc = documentManagerService.FindDocument(vm);
            
            if (doc == null)
            {
                doc = documentManagerService.CreateDocument("WarranteeView", null, vm);
                doc.Id = documentManagerService.Documents.Count();
                doc.Title = "新增被担保人信息";
            }
            doc.Show();
            var docVM = (WarranteeViewModel)doc.Content;
            if (docVM.IsChange)
            {
                Content.WarranteeItems.Add(docVM.Content);
                ItemSource.Add(docVM.Content);
            }
        }


        public void Save()
        {
            if (Content.ID == null || Content.ID == Guid.Empty)
            {
                base.AddItem(Content);Content.BusinessType.RaisePropertiesChanged();
            }
            else
            {
                base.UpdateItem(Content);
            }


        }
        
    }
}