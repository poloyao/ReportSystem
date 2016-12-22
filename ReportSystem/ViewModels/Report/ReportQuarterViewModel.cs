using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using System.Linq;
using DevExpress.Mvvm.POCO;
using System.Collections.ObjectModel;
using ReportSystem.Models;
using ReportSystem.Common.ViewModel;
using System.Collections.Generic;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class ReportQuarterViewModel: CollectionViewModel<ReportQuarterModel>
    {
        protected IDocumentManagerService documentManagerService { get { return this.GetService<IDocumentManagerService>(); } }

        public ObservableCollection<ReportQuarterSheet1> sheet1 { get; set; } = new ObservableCollection<ReportQuarterSheet1>();
        public ObservableCollection<ReportQuarterSheet2> sheet2 { get; set; } = new ObservableCollection<ReportQuarterSheet2>();
        public List<ReportQuarterSheet3> sheet3 { get; set; } = new List<ReportQuarterSheet3>();

        public static ReportQuarterViewModel Create()
        {
            return ViewModelSource.Create(() => new ReportQuarterViewModel());
        }

        protected ReportQuarterViewModel()
        {
            if (Items == null)
                return;
            this.sheet1 = new ObservableCollection<ReportQuarterSheet1>(Items.Select(x => x.sheet1).ToList());
            this.sheet2 = new ObservableCollection<ReportQuarterSheet2>(Items.Select(x => x.sheet2).ToList());
            var querysheet3 = Items.Select(x => x.sheet3).ToList();
            
            querysheet3.ForEach(x =>
            {
                sheet3.AddRange(x);
            });
        }



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
            var docVM = (AddQuarterViewModel)doc.Content;
            if (docVM.IsSaved)
            {
                Items.Add(docVM.Content);
                ItemSource.Add(docVM.Content);
                sheet1.Add(docVM.Content.sheet1);
                sheet2.Add(docVM.Content.sheet2);
                sheet3.AddRange(docVM.Content.sheet3);
            }

        }
    }
}