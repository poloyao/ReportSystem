using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using ReportSystem.Models;
using ReportSystem.Common.ViewModel;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class AddCompanyBranchViewModel: SingleViewModel<CompanyBranchModel>
    {
        public static AddCompanyBranchViewModel Create()
        {
            return ViewModelSource.Create(() => new AddCompanyBranchViewModel());
        }

        protected AddCompanyBranchViewModel() { }


        public bool IsChange { get; set; } = false;

        public virtual CompanyBranchModel Content { get; set; } = CompanyBranchModel.Create();



        protected override void OnParameterChanged(object parameter)
        {
            base.OnParameterChanged(parameter);
            if (parameter != null)
                this.Content = base.ContentBase;
        }

        public void Save()
        {
            var query = base.AddItem((CompanyBranchModel)Content.Clone());
            if (query != null)
            {
                IsChange = true;
                this.Content = query;
                DocumentOwner.Close(this, false);
                DevExpress.Xpf.Core.DXMessageBox.Show("添加成功！");
                Common.Core.LOGGER.Info(string.Format("添加CompanyBranchModel成功,ID:{0}", query.ID));
            }
            else
            {
                DevExpress.Xpf.Core.DXMessageBox.Show("添加失败！", "提示", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                Common.Core.LOGGER.Error("添加CompanyBranchModel失败");
            }
        }

    }
}