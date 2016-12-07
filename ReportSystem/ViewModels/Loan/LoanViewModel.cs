using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;
using System.Linq;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class LoanViewModel: SingleViewModel<LoanSingleItemlModel>
    {
        private INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        protected IDocumentManagerService documentManagerService { get { return this.GetService<IDocumentManagerService>(); } }

        public virtual LoanSingleItemlModel Content { get; set; }


        protected override void OnParameterChanged(object parameter)
        {
            base.OnParameterChanged(parameter);
            this.Content = base.ContentBase;
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
            IDocument doc = documentManagerService.FindDocument(vm);
            if (doc == null)
            {
                doc = documentManagerService.CreateDocument("CreditorView", vm);
                doc.Id = documentManagerService.Documents.Count();
                doc.Title = "新增债权人";
            }
            doc.Show();
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