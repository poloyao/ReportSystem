using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using ReportSystem.Models;
using ReportSystem.Common.ViewModel;
using System.ComponentModel;

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

        public virtual RegisterNewSupervisionRecoveryModelWithDataErrorInfo Content { get; set; } = new RegisterNewSupervisionRecoveryModelWithDataErrorInfo(); //SupervisionRecoveryModel.Create();

        public bool IsChange { get; set; } = false;

        public void Save()
        {
            if (Content.ID == null || Content.ID == Guid.Empty)
            {
                var query = base.AddItem((SupervisionRecoveryModel)Content.Clone());
                if (query != null)
                {
                    IsChange = true;
                    //this.Content = query;
                    this.Content = new RegisterNewSupervisionRecoveryModelWithDataErrorInfo(query);
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
                var query = base.UpdateItem((SupervisionRecoveryModel)Content.Clone());
                if (query != null)
                {
                    IsChange = true;
                    //this.Content = query;
                    this.Content = new RegisterNewSupervisionRecoveryModelWithDataErrorInfo(query);
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

    public class RegisterNewSupervisionRecoveryModelWithDataErrorInfo : SupervisionRecoveryModel, IDataErrorInfo
    {
        string Error { get; set; }
        string IDataErrorInfo.Error { get { return Error; } }

        string IDataErrorInfo.this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "RecoveryDate":
                        return ValidateRecoveryDate(RecoveryDate) ? string.Empty : Error;
                    case "RecoveryAmount":
                        return ValidateRecoveryAmount(RecoveryAmount) ? string.Empty : Error;
                    case "OwnRecoveryAmount":
                        return ValidateOwnRecoveryAmount(OwnRecoveryAmount) ? string.Empty : Error;
                    case "LossAmount":
                        return ValidateLossAmount(LossAmount) ? string.Empty : Error;                   

                }

                return string.Empty;
            }
        }

        public RegisterNewSupervisionRecoveryModelWithDataErrorInfo() { }
        public RegisterNewSupervisionRecoveryModelWithDataErrorInfo(SupervisionRecoveryModel info)
        {
            this.Assign(info);
        }

        public bool ValidateRecoveryDate(DateTime? dt)
        {
            if (dt == null)
            {
                Error = "日期不能为空";
                return false;
            }
            return true;
        }

        public bool ValidateRecoveryAmount(decimal dec)
        {
            if (dec < 0)
            {
                Error = "金额不能为空";
                return false;
            }
            return true;
        }

        public bool ValidateOwnRecoveryAmount(decimal dec)
        {
            if (dec < 0)
            {
                Error = "金额不能为空";
                return false;
            }
            return true;
        }

        public bool ValidateLossAmount(decimal dec)
        {
            if (dec < 0)
            {
                Error = "金额不能为空";
                return false;
            }
            return true;
        }
        



    }
}