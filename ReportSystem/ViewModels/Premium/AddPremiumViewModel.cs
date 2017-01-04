using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;
using System.ComponentModel;

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

        public virtual RegisterNewPremiumItemModelWithDataErrorInfo Content { get; set; } = new RegisterNewPremiumItemModelWithDataErrorInfo();

        public bool IsChange { get; set; } = false;



        protected override void OnParameterChanged(object parameter)
        {
            base.OnParameterChanged(parameter);
            if (parameter != null)
                //this.Content = base.ContentBase;
                this.Content = new RegisterNewPremiumItemModelWithDataErrorInfo(base.ContentBase);
        }

        public void Save()
        {
            if (Content.ID == null || Content.ID == Guid.Empty)
            {
                //UNDONE     应在后台设置记账日期，并返回
                var query = base.AddItem((PremiumItemModel)Content.Clone());
                if (query != null)
                {
                    IsChange = true;
                    //this.Content = query;
                    this.Content = new RegisterNewPremiumItemModelWithDataErrorInfo(query);
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
                    //this.Content = query;
                    this.Content = new RegisterNewPremiumItemModelWithDataErrorInfo(query);
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

    public class RegisterNewPremiumItemModelWithDataErrorInfo : PremiumItemModel, IDataErrorInfo
    {

        public RegisterNewPremiumItemModelWithDataErrorInfo() { }
        public RegisterNewPremiumItemModelWithDataErrorInfo(PremiumItemModel pre)
        {
            this.Assign(pre);
        }
        string IDataErrorInfo.this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "PayCategory":
                        return ValidatePayCategory(PayCategory) ? string.Empty : Error;
                    //case "AccountingDate":
                    //    return ValidateAccountingDate(AccountingDate) ? string.Empty : Error;
                    case "PayAmount":
                        return ValidatePayAmount(PayAmount) ? string.Empty : Error;
                    case "PayMethod":
                        return ValidatePayMethod(PayMethod) ? string.Empty : Error;
                    case "PayFre":
                        return ValidatePayFre(PayFre) ? string.Empty : Error;
                    case "StartDate":
                        return ValidateStartDate(StartDate) ? string.Empty : Error;
                    case "EndDate":
                        return ValidateEndDate(EndDate) ? string.Empty : Error;
                    case "Balance":
                        return ValidateBalance(Balance) ? string.Empty : Error;
                    case "TotalArrears":
                        return ValidateTotalArrears(TotalArrears) ? string.Empty : Error;
                    case "PayStatus":
                        return ValidatePayStatus(PayStatus) ? string.Empty : Error;
                }
                return string.Empty;
            }
        }

        string IDataErrorInfo.Error { get { return Error; } }

        string Error { get; set; }


        public bool ValidatePayCategory(Guid id)
        {
            if (id == null || id == Guid.Empty)
            {
                Error = "不能为空";
                return false;
            }
            return true;
        }
        //public bool ValidateAccountingDate(DateTime? dt)
        //{
        //    if (dt == null || dt < new DateTime(2000, 1, 1))
        //    {
        //        Error = "日期不能为空";
        //        return false;
        //    }
        //    return true;
        //}
        public bool ValidatePayAmount(decimal dec)
        {
            if (dec < 0)
            {
                Error = "金额不能为负数";
                return false;
            }
            return true;
        }
        public bool ValidatePayMethod( Guid id)
        {
            if (id == null || id == Guid.Empty)
            {
                Error = "不能为空";
                return false;
            }
            return true;
        }
        public bool ValidatePayFre( Guid id)
        {
            if (id == null || id == Guid.Empty)
            {
                Error = "不能为空";
                return false;
            }
            return true;
        }
        public bool ValidateStartDate(DateTime? dt)
        {
            if (dt == null || dt < new DateTime(2000, 1, 1))
            {
                Error = "日期不能为空";
                return false;
            }
            return true;
        }
        public bool ValidateEndDate( DateTime? dt)
        {
            if (dt == null || dt < new DateTime(2000, 1, 1))
            {
                Error = "日期不能为空";
                return false;
            }
            return true;
        }
        public bool ValidateBalance(decimal dec)
        {
            if (dec < 0)
            {
                Error = "金额不能为负数";
                return false;
            }
            return true;
        }
        public bool ValidateTotalArrears( decimal dec)
        {
            if (dec < 0)
            {
                Error = "金额不能为负数";
                return false;
            }
            return true;
        }

        public bool ValidatePayStatus(Guid id)
        {
            if (id == null || id == Guid.Empty)
            {
                Error = "不能为空";
                return false;
            }
            return true;
        }
    }

}