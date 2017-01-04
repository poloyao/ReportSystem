using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Models
{

    public class LoanCreditorItemModel : ICloneable
    {

        #region 属性       


        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "",AutoGenerateField = false)]
        public virtual Guid ID { get; set; }
        /// <summary>
        /// 债权人		
        /// </summary>
        [Display(Name = "债权人" ,AutoGenerateField = false)]
        public virtual CreditorItemModel Creditor { get; set; } = CreditorItemModel.Create();

        //[Display(Name = "债权人")]
        //public virtual string CreditorName { get; set; }
        /// <summary>
        /// 合同信息		
        /// </summary>
        [Display(Name = "合同信息",AutoGenerateField = false)]
        public virtual CreditorContractItemModel Contract { get; set; } = CreditorContractItemModel.Create();

        //[Display(Name = "合同信息")]
        //public virtual string ContractID { get; set; }

        /// <summary>
        /// 放款详细信息		
        /// </summary>
        [Display(Name = "放款详细信息")]
        public virtual ObservableCollection<LoanEntryItemModel> LoanEntryList { get; set; } = new ObservableCollection<LoanEntryItemModel>();
        /// <summary>
        /// 授信总额		
        /// </summary>
        [Display(Name = "授信总额")]
        [DataType(DataType.Currency)]
        public virtual decimal TotalCredit { get; set; }
        /// <summary>
        /// 在保总额		
        /// </summary>
        [Display(Name = "在保总额")]
        public virtual decimal TotalLoanAmount { get; set; }

        #endregion


        #region 构造

        protected LoanCreditorItemModel()
        {

        }

        public static LoanCreditorItemModel Create()
        {
            return ViewModelSource.Create(() => new LoanCreditorItemModel());
        }

        public static LoanCreditorItemModel Create(Action<LoanCreditorItemModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        #endregion

        [Command(false)]
        public void Assign(LoanCreditorItemModel content)
        {
            this.ID = content.ID;
            this.Creditor = content.Creditor;
            this.Contract = content.Contract;
            this.LoanEntryList = content.LoanEntryList;
            this.TotalCredit = content.TotalCredit;
            this.TotalLoanAmount = content.TotalLoanAmount;

        }

        [Command(false)]
        public object Clone()
        {
            return Create(x =>
            {
                x.ID = this.ID;
                x.Creditor = this.Creditor;
                x.Contract = this.Contract;
                x.LoanEntryList = this.LoanEntryList;
                x.TotalCredit = this.TotalCredit;
                x.TotalLoanAmount = this.TotalLoanAmount;

            });
        }




    }

}
