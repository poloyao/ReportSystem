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
            IDocument doc = documentManagerService.CreateDocument("AddHalfYearView", null, this);
            doc.Id = documentManagerService.Documents.Count();
            doc.Title = "新增半年报信息";
            var docVM = (AddHalfYearViewModel)doc.Content;
            doc.Show();
            if (docVM.IsSaved)
            {
                //重新获取数据 临时借用filer 
                base.Init(ReportType.HALFYEAR, 123);
            }

        }

        public void ShowReport(object item)
        {
            var _item = (ReportModel)item;
            IDocument doc = documentManagerService.CreateDocument("AddHalfYearView", _item.ID, this);
            doc.Id = documentManagerService.Documents.Count();
            doc.Title = _item.DisplayName + "半年报信息";
            var docVM = (AddHalfYearViewModel)doc.Content;
            doc.Show();
        }

    }
}