using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.Linq;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class ReportMonthViewModel
    {
        protected IDocumentManagerService documentManagerService { get { return this.GetService<IDocumentManagerService>(); } }

        public void AddMonth()
        {

            var vm = AddMonthViewModel.Create();
            IDocument doc = documentManagerService.FindDocument(vm);

            if (doc == null)
            {
                doc = documentManagerService.CreateDocument("AddMonthView", null, vm);
                doc.Id = documentManagerService.Documents.Count();
                doc.Title = "新增月报信息";
            }
            doc.Show();
            //var docVM = (AddCompanyStockholderViewModel)doc.Content;
            //if (docVM.IsChange)
            //{
            //    Content.CS.Add(docVM.Content);
            //}
        }
    }
}