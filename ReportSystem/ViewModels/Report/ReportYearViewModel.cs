using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.Linq;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;
using System.Collections.ObjectModel;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class ReportYearViewModel: ReportViewModel<ReportModel>
    {
        public static ReportYearViewModel Create()
        {
            return ViewModelSource.Create(() => new ReportYearViewModel());
        }

        protected ReportYearViewModel() : base(ReportType.YEAR)
        {
            //SplashScreenType = typeof(DXSplashScreen.ProgressWindow);
        }

        protected IDocumentManagerService documentManagerService { get { return this.GetService<IDocumentManagerService>(); } }

        //public ObservableCollection<ReportYearSheet1> Sheet1 { get; set; } = new ObservableCollection<ReportYearSheet1>();
        //public ObservableCollection<ReportYearSheet2> Sheet2 { get; set; } = new ObservableCollection<ReportYearSheet2>();
        //public ObservableCollection<ReportYearSheet3> Sheet3 { get; set; } = new ObservableCollection<ReportYearSheet3>();
        //public ObservableCollection<ReportYearSheet4> Sheet4 { get; set; } = new ObservableCollection<ReportYearSheet4>();
        //public ObservableCollection<ReportYearSheet5> Sheet5 { get; set; } = new ObservableCollection<ReportYearSheet5>();
        //public ObservableCollection<ReportYearSheet6> Sheet6 { get; set; } = new ObservableCollection<ReportYearSheet6>();
        //public ObservableCollection<ReportYearSheet7> Sheet7 { get; set; } = new ObservableCollection<ReportYearSheet7>();


        public ObservableCollection<ReportModel> ReportList { get; set; } = new ObservableCollection<ReportModel>();

        //public virtual Type SplashScreenType { get; set; }
        //protected ISplashScreenService SplashScreenService { get { return this.GetService<ISplashScreenService>(); } }


        //{
        //    new ReportModel() { Year = "2016",RType = ReportType.YEAR,Period = 1,UDP = DateTime.Now,Status = ReportStatus.MODIFIED },
        //    new ReportModel() { Year = "2015",RType = ReportType.YEAR,Period = 1,UDP = DateTime.Now,Status = ReportStatus.CANREPORT },
        //    new ReportModel() { Year = "2014",RType = ReportType.YEAR,Period = 1,UDP = DateTime.Now,Status = ReportStatus.UNFILLED },
        //    new ReportModel() { Year = "2013",RType = ReportType.YEAR,Period = 1,UDP = DateTime.Now,Status = ReportStatus.REPORTED },
        //};

        //void IntList(ReportYearModel collection)
        //{
        //    Sheet1.Add(collection.Sheet1);
        //    Sheet2.Add(collection.Sheet2);
        //    Sheet3.Add(collection.Sheet3);
        //    //Sheet4.(collection.Sheet4);
        //    //Sheet5.Add(collection.Sheet5);
        //    Sheet6.Add(collection.Sheet6);
        //    Sheet7.Add(collection.Sheet7);
        //}


        public void AddYear()
        {

            IDocument doc = documentManagerService.CreateDocument("AddYearView", null, this);
            doc.Id = documentManagerService.Documents.Count();
            doc.Title = "新增年报信息";
            var docVM = (AddYearViewModel)doc.Content;
            doc.Show();
            if (docVM.IsSaved)
            {
                //重新获取数据 临时借用filer 
                base.Init(ReportType.YEAR, 123);
            }
        }

        public void ShowReport(object item)
        {
            var _item = (ReportModel)item;
            try
            {                
                if (_item.ID == null || (Guid)_item.ID == Guid.Empty)
                    return;

                IDocument doc = documentManagerService.CreateDocument("AddYearView", _item.ID, this);
                doc.Id = documentManagerService.Documents.Count();
                doc.Title = _item.DisplayName + "年报信息";
                var docVM = (AddYearViewModel)doc.Content;
                doc.Show();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    Common.Core.LOGGER.Error($"{_item.DisplayName}年报信息存在问题无法打开。");
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