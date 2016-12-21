using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.Linq;
using System.Collections.ObjectModel;
using ReportSystem.Models;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class ReportMonthViewModel
    {
        protected IDocumentManagerService documentManagerService { get { return this.GetService<IDocumentManagerService>(); } }

        public ObservableCollection<ReportMonthSheet1> Sheet1 { get; set; } = new ObservableCollection<ReportMonthSheet1>();
        public ObservableCollection<ReportMonthSheet2> Sheet2 { get; set; } = new ObservableCollection<ReportMonthSheet2>();

        public ObservableCollection<ReportMonthSheet3> Sheet3 { get; set; } = new ObservableCollection<ReportMonthSheet3>();

        public ObservableCollection<ReportMonthSheet4> Sheet4 { get; set; } = new ObservableCollection<ReportMonthSheet4>();



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
            var docVM = (AddMonthViewModel)doc.Content;
            if (docVM.IsSaved)
            {
                Sheet1.Add(docVM.Content.Sheet1);
                Sheet2.Add(docVM.Content.Sheet2);
                Sheet3.Add(docVM.Content.Sheet3);
                Sheet4.Add(docVM.Content.Sheet4);
            }
        }
    }
}