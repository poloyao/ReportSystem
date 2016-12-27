using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.Linq;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class ReportHalfYearViewModel : ReportViewModel<ReportModel>
    {
        public static ReportHalfYearViewModel Create()
        {
            return ViewModelSource.Create(() => new ReportHalfYearViewModel());
        }

        protected ReportHalfYearViewModel():base(ReportType.HALFYEAR)
        {

        }

        protected IDocumentManagerService documentManagerService { get { return this.GetService<IDocumentManagerService>(); } }


        public void AddHalfYear()
        {
            var vm = AddHalfYearViewModel.Create();
            IDocument doc = documentManagerService.FindDocument(vm);

            if (doc == null)
            {
                doc = documentManagerService.CreateDocument("AddHalfYearView", null, vm);
                doc.Id = documentManagerService.Documents.Count();
                doc.Title = "新增半年报信息";
            }
            doc.Show();
            var docVM = (AddHalfYearViewModel)doc.Content;
            if (docVM.IsSaved)
            {
                //Items.Add(docVM.Content);
                //ItemSource.Add(docVM.Content);
            }
        }

        public void ShowReport(object id)
        {
            var vm = AddHalfYearViewModel.Create();
            IDocument doc = documentManagerService.FindDocument(vm);

            if (doc == null)
            {
                doc = documentManagerService.CreateDocument("AddHalfYearView", id, vm);
                doc.Id = documentManagerService.Documents.Count();
                doc.Title = "新增半年报信息";
            }
            doc.Show();
        }

    }
}