using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.ComponentModel;
using ReportSystem.Models;
using ReportSystem.Common.ViewModel;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class CreditorViewModel: SingleViewModel<LoanCreditorItemModel>, IDocumentContent
    {
        //public IDocumentOwner DocumentOwner { get; set; }

        //public object Title { get; }

        public virtual RegisterNewLoanCreditorItemModelWithDataErrorInfo Content { get; set; } = new RegisterNewLoanCreditorItemModelWithDataErrorInfo();//LoanCreditorItemModel.Create();
        [BindableProperty(OnPropertyChangedMethodName = "OnIsEditChanged")]
        public virtual bool IsEnabled { get; set; } = true;
        protected void OnIsEditChanged()
        {
            this.IsReadOnly = !IsEnabled;
        }

        public virtual bool IsReadOnly { get; set; } = false;
        /// <summary>
        /// 编辑完后置为true
        /// </summary>
        public bool IsEdited { get; private set; } = true;

        public Guid LoanID { get; set; }

        public static CreditorViewModel Create()
        {
            return ViewModelSource.Create(() => new CreditorViewModel());
        }

        protected CreditorViewModel() { }

        protected override void OnParameterChanged(object parameter)
        {
            base.OnParameterChanged(parameter);
            //if (parameter != null)
            //{
            //    IsEnabled = (bool)parameter;
            //}                
            //else
            //    IsEnabled = true;
        }


        public void Save()
        {
            if (Content == null)
                return;
            LoanCreditorItemModel query;
            //if (Content.ID == Guid.Empty)
            //    query = base.AddItem(Content);
            //else
            //    query = base.UpdateItem(Content);
            Content.ID = LoanID;
            query = base.AddItem(Content);
            if (query != null)
            {
                this.IsEnabled = false;
                this.IsEdited = true;
                this.Close();
                DevExpress.Xpf.Core.DXMessageBox.Show("添加成功！");
                Common.Core.LOGGER.Info(string.Format("添加LoanCreditorItemModel成功,ID:{0}", query.ID));
            }
            else
            {
                DevExpress.Xpf.Core.DXMessageBox.Show("添加失败！", "提示", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                Common.Core.LOGGER.Error("添加LoanCreditorItemModel失败");
            }
        }

        public void Close()
        {
            DocumentOwner.Close(this, false);
        }

        //public void OnClose(CancelEventArgs e)
        //{
        //    e.Cancel = false;
        //}

        //public void OnDestroy() { }
    }


    public class RegisterNewLoanCreditorItemModelWithDataErrorInfo : LoanCreditorItemModel, IDataErrorInfo
    {
   
        string Error { get; set; }
        string IDataErrorInfo.Error { get { return Error; } }

        string IDataErrorInfo.this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "CreditorName":
                        return ValidateCreditorName(this.Creditor.CreditorName) ? string.Empty : Error;
                }

                return string.Empty;
            }
        }


        public RegisterNewLoanCreditorItemModelWithDataErrorInfo() { }
        public RegisterNewLoanCreditorItemModelWithDataErrorInfo(LoanCreditorItemModel lc)
        {
            this.Assign(lc);
        }


        public bool ValidateCreditorName(string creditorName)
        {
            Error = "you can xxx";
            return false;
        }


    }


    public class RegisterNewCreditorItemModelWithDataErrorInfo : CreditorItemModel, IDataErrorInfo
    {
        string Error { get; set; }
        string IDataErrorInfo.Error { get { return Error; } }

        string IDataErrorInfo.this[string columnName]
        {
            get
            {
                //switch (columnName)
                //{
                //    case "CreditorName":
                //        return ValidateCreditorName(this.Creditor.CreditorName) ? string.Empty : Error;
                //}

                return string.Empty;
            }
        }



    }

}