using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using System.Linq;
using DevExpress.Mvvm.POCO;
using System.Collections.ObjectModel;
using ReportSystem.Models;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class ReportQuarterViewModel
    {
        protected IDocumentManagerService documentManagerService { get { return this.GetService<IDocumentManagerService>(); } }

        public ObservableCollection<ReportQuarterSheet1> sheet1 { get; set; } = new ObservableCollection<ReportQuarterSheet1>();
        public ObservableCollection<ReportQuarterSheet2> sheet2 { get; set; } = new ObservableCollection<ReportQuarterSheet2>();
        //public ObservableCollection<ReportQuarterSheet3> sheet3 { get; set; }
        public void AddQuarter()
        {
            var vm = AddQuarterViewModel.Create();
            IDocument doc = documentManagerService.FindDocument(vm);

            if (doc == null)
            {
                doc = documentManagerService.CreateDocument("AddQuarterView", null, vm);
                doc.Id = documentManagerService.Documents.Count();
                doc.Title = "新增季报信息";
            }
            doc.Show();
            var ss = ((AddQuarterViewModel)doc.Content).Content;
            sheet1.Add(ss.sheet1);
            sheet2.Add(ss.sheet2);


        }
    }
}