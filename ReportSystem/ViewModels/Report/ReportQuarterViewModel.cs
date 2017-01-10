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
    public class ReportQuarterViewModel: ReportViewModel<ReportModel>
    {
        protected IDocumentManagerService documentManagerService { get { return this.GetService<IDocumentManagerService>(); } }

        public ObservableCollection<ReportQuarterSheet1> sheet1 { get; set; } = new ObservableCollection<ReportQuarterSheet1>();
        public ObservableCollection<ReportQuarterSheet2> sheet2 { get; set; } = new ObservableCollection<ReportQuarterSheet2>();
        public List<ReportQuarterSheet3> sheet3 { get; set; } = new List<ReportQuarterSheet3>();

        public static ReportQuarterViewModel Create()
        {
            return ViewModelSource.Create(() => new ReportQuarterViewModel());
        }

        protected ReportQuarterViewModel():base(ReportType.QUARTER)
        {
            //if (Items == null)
            //    return;
            //this.sheet1 = new ObservableCollection<ReportQuarterSheet1>(Items.Select(x => x.sheet1).ToList());
            //this.sheet2 = new ObservableCollection<ReportQuarterSheet2>(Items.Select(x => x.sheet2).ToList());
            //var querysheet3 = Items.Select(x => x.sheet3).ToList();
            
            //querysheet3.ForEach(x =>
            //{
            //    sheet3.AddRange(x);
            //});
        }



        public void AddQuarter()
        {
            IDocument doc = documentManagerService.CreateDocument("AddQuarterView", null, this);
            doc.Id = documentManagerService.Documents.Count();
            doc.Title = "新增季报信息";
            var docVM = (AddQuarterViewModel)doc.Content;
            doc.Show();
            if (docVM.IsSaved)
            {
                //重新获取数据 临时借用filer 
                base.Init(ReportType.QUARTER, 123);
            }

        }

        public void ShowReport(object item)
        {
            var _item = (ReportModel)item;
            try
            {
                //if (_item.ID == null || (Guid)_item.ID == Guid.Empty)
                //    return;

                IDocument doc = documentManagerService.CreateDocument("AddQuarterView", _item.ID, this);
                doc.Id = documentManagerService.Documents.Count();
                doc.Title = _item.DisplayName + "季报信息";
                var docVM = (AddQuarterViewModel)doc.Content;
                doc.Show();
            }
            catch (Helpers.ReportException re)//因UI阻断未能捕获到此异常
            {
                Common.Core.LOGGER.Error($"{_item.DisplayName}季报信息存在问题无法打开。");
                DevExpress.Xpf.Core.DXMessageBox.Show(re.Message);
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    Common.Core.LOGGER.Error($"{_item.DisplayName}季报信息存在问题无法打开。");
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