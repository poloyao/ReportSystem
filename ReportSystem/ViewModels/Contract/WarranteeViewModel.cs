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
    public class WarranteeViewModel : SingleViewModel<WarranteeItemModel>
    {
        public static WarranteeViewModel Create()
        {
            return ViewModelSource.Create(() => new WarranteeViewModel());
        }

        protected WarranteeViewModel()
        {
        }

        [BindableProperty(OnPropertyChangedMethodName = "OnIsReadChanged")]
        public virtual bool IsRead { get; set; } = false;

        protected void OnIsReadChanged()
        {
            IsEdited = !IsRead;
        }

        public virtual bool IsEdited { get; set; } = true;

        public virtual RegisterNewWarranteeItemModelWithDataErrorInfo Content { get; set; } = new RegisterNewWarranteeItemModelWithDataErrorInfo();//WarranteeItemModel.Create();

        public bool IsChange { get; set; } = false;

        public virtual bool IsMain { get; set; }


        protected override void OnParameterChanged(object parameter)
        {
            base.OnParameterChanged(parameter);
            if (parameter != null)
            {
                //this.Content = (WarranteeItemModel)base.ContentBase.Clone();
                this.Content = new RegisterNewWarranteeItemModelWithDataErrorInfo(base.ContentBase);
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
                    this.Content = new RegisterNewWarranteeItemModelWithDataErrorInfo(query);//query;
                    DevExpress.Xpf.Core.DXMessageBox.Show("添加成功！");
                    Common.Core.LOGGER.Info($"添加{query.GetType()}成功,ID:{query.ID}");
                    base.DocumentOwner.Close(this, false);
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
                    this.Content = new RegisterNewWarranteeItemModelWithDataErrorInfo(query);//query;
                    DevExpress.Xpf.Core.DXMessageBox.Show("修改成功！");
                    Common.Core.LOGGER.Info(string.Format("修改WarranteeItemModel成功,ID:{0}", query.ID));
                    base.DocumentOwner.Close(this, false);
                }
                else
                {
                    DevExpress.Xpf.Core.DXMessageBox.Show("修改失败！", "提示", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                    Common.Core.LOGGER.Error(string.Format("修改WarranteeItemModel失败,ID:{0}", query.ID));
                }
            }
        }

        public class RegisterNewWarranteeItemModelWithDataErrorInfo : WarranteeItemModel, IDataErrorInfo
        {

            public RegisterNewWarranteeItemModelWithDataErrorInfo() { }
            public RegisterNewWarranteeItemModelWithDataErrorInfo(WarranteeItemModel warrantee)
            {
                this.Assign(warrantee);
            }

            string IDataErrorInfo.this[string columnName]
            {
                get
                {
                    switch (columnName)
                    {
                        case "WarranteeType":
                            return ValidateWarranteeType(WarranteeType) ? string.Empty : Error;
                        case "Name":
                            return ValidateName(Name) ? string.Empty : Error;
                        case "CardType":
                            return ValidateWarranteeType(CardType) ? string.Empty : Error;
                        case "CardID":
                            return ValidateCardID(CardID) ? string.Empty : Error;
                    }
                    return string.Empty;
                }
            }

            string Error { get; set; }

            string IDataErrorInfo.Error { get { return Error; } }

            public bool ValidateWarranteeType(Guid id)
            {
                if (id == null || id == Guid.Empty)
                {
                    Error = "不能为空";
                    return false;
                }
                return true;
            }

            public bool ValidateName(string name)
            {
                if (name == string.Empty || name == null)
                {
                    Error = "名字不能为空";
                    return false;
                }
                return true;
            }

            public bool ValidateCardID(string id)
            {
                if (id == string.Empty || id == null)
                {
                    Error = "号码不能为空";
                    return false;
                }
                else if (id.Length > 18)
                {
                    Error = "号码长度超出18位";
                    return false;
                }

                return true;
            }




        }




    }
}