using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using ReportSystem.Models;
using ReportSystem.Common.ViewModel;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class SupervisionRecovertViewModel: SingleViewModel<SupervisionRecoveryModel>
    {
        public static SupervisionRecovertViewModel Create()
        {
            return ViewModelSource.Create(() => new SupervisionRecovertViewModel());
        }

        protected SupervisionRecovertViewModel() { }

        public virtual SupervisionRecoveryModel Content { get; set; } = SupervisionRecoveryModel.Create();

        public bool IsChange { get; set; } = false;

        public void Save()
        {
            if (Content.ID == null || Content.ID == Guid.Empty)
            {
                var query = base.AddItem((SupervisionRecoveryModel)Content.Clone());
                if (query != null)
                {
                    IsChange = true;
                    this.Content = query;
                    DevExpress.Xpf.Core.DXMessageBox.Show("添加成功！");
                    Common.Core.LOGGER.Info($"添加{query.GetType()}成功,ID:{query.ID}");
                }
                else
                {
                    DevExpress.Xpf.Core.DXMessageBox.Show("添加失败！", "提示", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                    Common.Core.LOGGER.Error("添加WarranteeItemModel失败");
                }
            }
            else
            {
                var query = base.UpdateItem((SupervisionRecoveryModel)Content.Clone());
                if (query != null)
                {
                    IsChange = true;
                    this.Content = query;
                    DevExpress.Xpf.Core.DXMessageBox.Show("修改成功！");
                    Common.Core.LOGGER.Info(string.Format("修改WarranteeItemModel成功,ID:{0}", query.ID));
                }
                else
                {
                    DevExpress.Xpf.Core.DXMessageBox.Show("修改失败！", "提示", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                    Common.Core.LOGGER.Error(string.Format("修改WarranteeItemModel失败,ID:{0}", query.ID));
                }
            }
        }

    }
}