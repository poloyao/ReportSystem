using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class AddPremiumViewModel:SingleViewModel<PremiumItemModel>
    {
        public static AddPremiumViewModel Create()
        {
            return ViewModelSource.Create(() => new AddPremiumViewModel());
        }

        protected AddPremiumViewModel() { }

        public virtual PremiumItemModel Content { get; set; }

        public bool IsChange { get; set; } = false;



        protected override void OnParameterChanged(object parameter)
        {
            base.OnParameterChanged(parameter);
            if (parameter != null)
                this.Content = base.ContentBase;
        }

        public void Save()
        {
            if (Content.ID == null || Content.ID == Guid.Empty)
            {
                var query = base.AddItem((PremiumItemModel)Content.Clone());
                if (query != null)
                {
                    IsChange = true;
                    this.Content = query;
                    DevExpress.Xpf.Core.DXMessageBox.Show("添加成功！");
                    Common.Core.LOGGER.Info($"添加{query.GetType()}成功,ID:{query.ID}");
                    base.DocumentOwner.Close(this, false);
                }
                else
                {
                    DevExpress.Xpf.Core.DXMessageBox.Show("添加失败！", "提示", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                    Common.Core.LOGGER.Error($"添加{Content.GetType()}失败");
                }
            }
            else
            {
                var query = base.UpdateItem((PremiumItemModel)Content.Clone());
                if (query != null)
                {
                    IsChange = true;
                    this.Content = query;
                    DevExpress.Xpf.Core.DXMessageBox.Show("修改成功！");
                    Common.Core.LOGGER.Info($"修改{query.GetType()}成功,ID:{query.ID}");
                    base.DocumentOwner.Close(this, false);
                }
                else
                {
                    DevExpress.Xpf.Core.DXMessageBox.Show("修改失败！", "提示", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                    Common.Core.LOGGER.Error($"修改{Content.GetType()}失败,ID:{query.ID}");
                }
            }
        }



    }
}