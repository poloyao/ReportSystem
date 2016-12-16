using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class WarranteeViewModel:SingleViewModel<WarranteeItemModel>
    {
        public static WarranteeViewModel Create()
        {
            return ViewModelSource.Create(() => new WarranteeViewModel());
        }

        protected WarranteeViewModel() {
        }

        [BindableProperty(OnPropertyChangedMethodName = "OnIsReadChanged")]
        public virtual bool IsRead { get; set; } = false;

        protected void OnIsReadChanged()
        {
            IsEdited = !IsRead;
        }

        public virtual bool IsEdited { get; set; }

        public virtual WarranteeItemModel Content { get; set; } = WarranteeItemModel.Create();

        public bool IsChange { get; set; } = false;
        



        protected override void OnParameterChanged(object parameter)
        {
            base.OnParameterChanged(parameter);
            if (parameter != null)
            {
                this.Content = (WarranteeItemModel)base.ContentBase.Clone();
            }

            //IsEdited = true;
        }

        public void Save()
        {
            if (Content.ID == null || Content.ID == Guid.Empty)
            {
                var query = base.AddItem((WarranteeItemModel)Content.Clone());
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
                var query = base.UpdateItem((WarranteeItemModel)Content.Clone());
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