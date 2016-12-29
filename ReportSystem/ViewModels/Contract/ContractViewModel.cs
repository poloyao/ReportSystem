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
        public virtual ContractItemModel Content { get; set; } = ContractItemModel.Create();

        public virtual WarranteeItemModel MainWarrantee { get; set; } = WarranteeItemModel.Create();

        public virtual ObservableCollection<WarranteeItemModel> ItemSource { get; set; } = new ObservableCollection<WarranteeItemModel>();

        public virtual WarranteeItemModel SelectItem { get; set; }

        private INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        protected IDocumentManagerService documentManagerService { get { return this.GetService<IDocumentManagerService>(); } }

        public virtual bool AllowEdit { get;  set; } = true;

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
            if (parameter != null)
            {
                this.Content = base.ContentBase;                
                this.IsReadOnly = true;
                //根据传回来的值判断是否可以删除
                AllowEdit = Content.AllowEdit;
                if (Content.WarranteeItems != null)
                {
                    this.MainWarrantee = Content.WarranteeItems.SingleOrDefault(x => x.IsMain == true);
                    this.ItemSource = new ObservableCollection<WarranteeItemModel>(Content.WarranteeItems);
                }
            }
        }

        

        public void GoBack()
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();
        }

        public void SelectRow(object id)
        {
            IDocument doc = documentManagerService.CreateDocument("WarranteeView", id, this);
            doc.Id = documentManagerService.Documents.Count();
            doc.Title = SelectItem.Name;
            var docVM = (WarranteeViewModel)doc.Content;
            if (AllowEdit)
                docVM.IsRead = false;
            else
                docVM.IsRead = true;

            if (SelectItem.IsMain)
                docVM.IsMain = true;
            else
            {
                var Main = Content.WarranteeItems.SingleOrDefault(x => x.IsMain == true);
                if (Main != null)
                    docVM.IsMain = false;
                else
                    docVM.IsMain = true;
            }
            
            

            doc.Show();
            if (docVM.IsChange)
            {
                var query = Content.WarranteeItems.Single(x => x.ID == docVM.Content.ID);
                Content.WarranteeItems.Remove(query);
                Content.WarranteeItems.Add(docVM.Content);
                //query = docVM.Content;
                var querySource = ItemSource.Single(x => x.ID == docVM.Content.ID);
                ItemSource.Remove(querySource);
                ItemSource.Add(docVM.Content);
            }
        }

        public void AddItem()
        {
            IDocument doc = documentManagerService.CreateDocument("WarranteeView", null, this);
            doc.Id = documentManagerService.Documents.Count();
            doc.Title = "新增被担保人信息";
            var docVM = (WarranteeViewModel)doc.Content;
            docVM.IsRead = false;
            var Main = Content.WarranteeItems.SingleOrDefault(x => x.IsMain == true);
            if (Main != null)
                docVM.IsMain = false;
            else
                docVM.IsMain = true;

            doc.Show();
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

        public void Delece()
        {
            if (DevExpress.Xpf.Core.DXMessageBox.Show("确认要删除此合同信息？", "删除", System.Windows.MessageBoxButton.YesNo) == System.Windows.MessageBoxResult.Yes)
            {
                if (Content == null || Content.ID == Guid.Empty)
                {

                    DevExpress.Xpf.Core.DXMessageBox.Show("数据已删除");
                    GoBack();
                }
                else
                {
                    if (base.DeleteItem(Content))
                    {
                        DevExpress.Xpf.Core.DXMessageBox.Show("数据已成功删除");
                        GoBack();
                    }
                    else
                    {
                        DevExpress.Xpf.Core.DXMessageBox.Show("数据删除失败");
                    }
                }
            }
        }


    }
}