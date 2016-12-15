using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using ReportSystem.Models;
using System.Collections.ObjectModel;
using ReportSystem.Common.ViewModel;
using DevExpress.Mvvm.POCO;
using System.Linq;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class CompanySettingViewModel: SingleViewModel<CompanyDisplayModel>
    {
        protected CompanySettingViewModel()
        {
            //Content = CompanyDisplayModel.Create(cd =>
            //{
            //    cd.Info = CompanyInfoModel.Create(x => { x.Info1 = "123123123"; });
            //    cd.CM = new ObservableCollection<CompanyManagersModel>()
            //    {
            //        //CompanyManagersModel.Create(x=> { x.Info1 = "22222222"; })
            //        new CompanyManagersModel() {Info1 = "234234" }
            //    };
            //    cd.CS = new ObservableCollection<CompanyStockholderModel>()
            //    {
            //        //CompanyStockholderModel.Create(x=> { x.Info1 = "555555"; })
            //        new CompanyStockholderModel()
            //    };
            //    cd.CB = new ObservableCollection<CompanyBranchModel>()
            //    {
            //        //CompanyBranchModel.Create(x=> { x.Info1 = "555555"; })
            //        new CompanyBranchModel()
            //    };
            //    cd.CA = new ObservableCollection<CompanyAccountModel>()
            //    {
            //        //CompanyAccountModel.Create(x=> { x.Info1 = "555555"; })
            //        new CompanyAccountModel()
            //    };
            //});
            
        }

        public static CompanySettingViewModel Create()
        {
            return ViewModelSource.Create(() => new CompanySettingViewModel());
        }

        protected override void OnParameterChanged(object parameter)
        {
            base.OnParameterChanged(parameter);
            this.Content = base.ContentBase;
            if (Content == null)
                Content = CompanyDisplayModel.Create();
        }

        public virtual CompanyDisplayModel Content { get; set; }

        // public virtual CompanyInfoModel Content { get; set; } = CompanyInfoModel.Create();

        protected IDocumentManagerService documentManagerService { get { return this.GetService<IDocumentManagerService>(); } }

        public virtual int TabSelectIndex { get; set; } = 0;

        public void Save()
        {
            var query = base.AddItem(Content);
            if (query == null)
            {
                DevExpress.Xpf.Core.DXMessageBox.Show("添加失败！");
                Common.Core.LOGGER.Error("添加CompanyDisplayModel失败");
            }
            this.Content = query;
                
        }


        public void NewStockholder(int tabSelect)
        {
            TabSelectIndex = (int)tabSelect;
            var vm = AddCompanyStockholderViewModel.Create();
            IDocument doc = documentManagerService.FindDocument(vm);

            if (doc == null)
            {
                doc = documentManagerService.CreateDocument("AddCompanyStockholderView", null, vm);
                doc.Id = documentManagerService.Documents.Count();
                doc.Title = "新增股东信息";
            }
            doc.Show();
            var docVM = (AddCompanyStockholderViewModel)doc.Content;
            if (docVM.IsChange)
            {
                Content.CS.Add(docVM.Content);
            }
        }
        public void NewManager(int tabSelect)
        {
            TabSelectIndex = (int)tabSelect;
            var vm = AddCompanyManagerViewModel.Create();
            IDocument doc = documentManagerService.FindDocument(vm);

            if (doc == null)
            {
                doc = documentManagerService.CreateDocument("AddCompanyManagerView", null, vm);
                doc.Id = documentManagerService.Documents.Count();
                doc.Title = "新增高管信息";
            }
            doc.Show();
            var docVM = (AddCompanyManagerViewModel)doc.Content;
            if (docVM.IsChange)
            {
                Content.CM.Add(docVM.Content);
            }
        }
        public void NewBranch(int tabSelect)
        {
            TabSelectIndex = (int)tabSelect;
            var vm = AddCompanyBranchViewModel.Create();
            IDocument doc = documentManagerService.FindDocument(vm);

            if (doc == null)
            {
                doc = documentManagerService.CreateDocument("AddCompanyBranchView", null, vm);
                doc.Id = documentManagerService.Documents.Count();
                doc.Title = "新增分支机构信息";
            }
            doc.Show();
            var docVM = (AddCompanyBranchViewModel)doc.Content;
            if (docVM.IsChange)
            {
                Content.CB.Add(docVM.Content);
            }
        }
        public void NewAccount(int tabSelect)
        {
            TabSelectIndex = (int)tabSelect;
            var vm = AddCompanyAccountViewModel.Create();
            IDocument doc = documentManagerService.FindDocument(vm);

            if (doc == null)
            {
                doc = documentManagerService.CreateDocument("AddCompanyAccountView", null, vm);
                doc.Id = documentManagerService.Documents.Count();
                doc.Title = "新增银行账户信息";
            }
            doc.Show();
            var docVM = (AddCompanyAccountViewModel)doc.Content;
            if (docVM.IsChange)
            {
                Content.CA.Add(docVM.Content);
            }
        }



    }
}