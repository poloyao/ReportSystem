using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.Linq;
using System.Collections.ObjectModel;
using ReportSystem.Models;
using ReportSystem.Common.ViewModel;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class ReportMonthViewModel : ReportViewModel<ReportModel>
    {
        public static ReportMonthViewModel Create()
        {
            return ViewModelSource.Create(() => new ReportMonthViewModel());
        }

        protected ReportMonthViewModel():base(ReportType.MONTH)
        {
            //if (Items == null)
            //    return;
            //this.Sheet1 = new ObservableCollection<ReportMonthSheet1>(Items.Select(x => x.Sheet1).ToList());
            //this.Sheet2 = new ObservableCollection<ReportMonthSheet2>(Items.Select(x => x.Sheet2).ToList());
            //this.Sheet3 = new ObservableCollection<ReportMonthSheet3>(Items.Select(x => x.Sheet3).ToList());
            //this.Sheet4 = new ObservableCollection<ReportMonthSheet4>(Items.Select(x => x.Sheet4).ToList());
        }

        protected IDocumentManagerService documentManagerService { get { return this.GetService<IDocumentManagerService>(); } }

        public ObservableCollection<ReportMonthSheet1> Sheet1 { get; set; } = new ObservableCollection<ReportMonthSheet1>();
        public ObservableCollection<ReportMonthSheet2> Sheet2 { get; set; } = new ObservableCollection<ReportMonthSheet2>();

        public ObservableCollection<ReportMonthSheet3> Sheet3 { get; set; } = new ObservableCollection<ReportMonthSheet3>();

        public ObservableCollection<ReportMonthSheet4> Sheet4 { get; set; } = new ObservableCollection<ReportMonthSheet4>();
        

        public void AddMonth()
        {

            //var vm = AddMonthViewModel.Create();
            //IDocument doc = documentManagerService.FindDocument(vm);

            //if (doc == null)
            //{
            //    doc = documentManagerService.CreateDocument("AddMonthView", null, vm);
            //    doc.Id = documentManagerService.Documents.Count();
            //    doc.Title = "新增月报信息";
            //}
            //doc.Show();
            //var docVM = (AddMonthViewModel)doc.Content;
            //if (docVM.IsSaved)
            //{
            //    //Items.Add(docVM.Content);
            //    //ItemSource.Add(docVM.Content);
            //    //Sheet1.Add(docVM.Content.Sheet1);
            //    //Sheet2.Add(docVM.Content.Sheet2);
            //    //Sheet3.Add(docVM.Content.Sheet3);
            //    //Sheet4.Add(docVM.Content.Sheet4);
            //}

            IDocument doc = documentManagerService.CreateDocument("AddMonthView", null, this);
            doc.Id = documentManagerService.Documents.Count();
            doc.Title = "新增月报信息";
            var docVM = (AddMonthViewModel)doc.Content;           
            doc.Show();
            if (docVM.IsSaved)
            {
            }

        }

        public void ShowReport(object id)
        {

            //var vm = AddMonthViewModel.Create();
            //IDocument doc = documentManagerService.FindDocument(vm);

            //if (doc == null)
            //{
            //    doc = documentManagerService.CreateDocument("AddMonthView", id, vm);
            //    doc.Id = documentManagerService.Documents.Count();
            //    doc.Title = "新增月报信息";
            //}
            //doc.Show();
            try
            {
                if (id == null || (Guid)id == Guid.Empty)
                    return;

                IDocument doc = documentManagerService.CreateDocument("AddMonthView", id, this);
                doc.Id = documentManagerService.Documents.Count();
                doc.Title = "新增月报信息";
                var docVM = (AddMonthViewModel)doc.Content;
                doc.Show();
            }
            catch (Exception ex)
            {
                DevExpress.Xpf.Core.DXMessageBox.Show(ex.Message);
                
            }
           

        }

    }
}