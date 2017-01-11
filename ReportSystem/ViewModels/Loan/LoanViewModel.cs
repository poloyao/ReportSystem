using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;
using System.Linq;
using System.Collections.ObjectModel;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class LoanViewModel: SingleViewModel<LoanSingleItemlModel>
    {
        private INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        protected IDocumentManagerService documentManagerService { get { return this.GetService<IDocumentManagerService>(); } }

        public virtual LoanSingleItemlModel Content { get; set; } = LoanSingleItemlModel.Create();

        public virtual ObservableCollection<LoanCreditorItemModel> DetailList { get; set; } = new ObservableCollection<LoanCreditorItemModel>();


        protected override void OnParameterChanged(object parameter)
        {
            base.OnParameterChanged(parameter);
            if (parameter != null)
                this.Content = base.ContentBase;
            if (Content.LoanCreditorItems != null)
                DetailList = new ObservableCollection<LoanCreditorItemModel>(Content.LoanCreditorItems);
            if (parameter != null)
                return;

        }

        public void GoBack()
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();
        }

        public void AddCreditor()
        {
            var vm = CreditorViewModel.Create();
            //vm.IsEdit = true;
            IDocument doc = documentManagerService.FindDocument(vm);
            if (doc == null)
            {
                doc = documentManagerService.CreateDocument("CreditorView", null, this);//.CreateDocument("CreditorView", vm);
                doc.Id = documentManagerService.Documents.Count();
                doc.Title = "新增债权人";
                
            }
            var docContent = doc.Content as CreditorViewModel;
            //docContent.IsEnabled = true;
            docContent.LoanID = this.Content.ID;
            doc.Show();
            
            if (docContent.IsEdited)
            {
                DetailList.Add(docContent.Content);
            }
        }

        public void SelectRow(object _id)
        {
            Guid id = (Guid)_id;
            if (Content.LoanCreditorItems.SingleOrDefault(x => x.ID != id) != null)
            {
                Content.LoanCreditorItems.ForEach(x =>
                {
                    if (x.LoanEntryList.SingleOrDefault(le => le.ID == id) != null)
                    {
                        id = x.ID;
                    }
                });
            }
            NavigationService.Navigate("LoanDetailView", id, this);
        }

    }
}