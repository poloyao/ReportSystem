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

            IDocument doc = documentManagerService.CreateDocument("AddMonthView", null, this);
            doc.Id = documentManagerService.Documents.Count();
            doc.Title = "新增月报信息";
            var docVM = (AddMonthViewModel)doc.Content;           
            doc.Show();
            if (docVM.IsSaved)
            {
                //重新获取数据 临时借用filer 
                base.Init(ReportType.MONTH, 123);
            }

        }

        public void ShowReport(object item)
        {
            var _item = (ReportModel)item;
            try
            {                
                if (_item.ID == null || (Guid)_item.ID == Guid.Empty)
                    return;

                IDocument doc = documentManagerService.CreateDocument("AddMonthView", _item.ID, this);
                doc.Id = documentManagerService.Documents.Count();
                doc.Title = _item.DisplayName + "月报信息";
                var docVM = (AddMonthViewModel)doc.Content;
                doc.Show();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    Common.Core.LOGGER.Error($"{_item.DisplayName}月报信息存在问题无法打开。");
                    DevExpress.Xpf.Core.DXMessageBox.Show(ex.InnerException.Message);
                }
                else
                {
                    throw ex;
                }

            }
           

        }

    }
}