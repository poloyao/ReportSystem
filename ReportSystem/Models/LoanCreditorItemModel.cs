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

    public partial class LoanCreditorItemModel : ICloneable
    {

        #region 属性       


        /// <summary>
        /// 		
        /// </summary>
        [Display(AutoGenerateField = false)]
        public virtual Guid ID { get; set; }
        /// <summary>
        /// 债权人		
        /// </summary>
        //[Display(Name = "债权人", AutoGenerateField = false)]
       // public virtual CreditorItemViewModel Creditor { get; set; }

        [Display(Name = "债权人")]
        public virtual string CreditorName { get; set; }

        [Display(Name = "证件类型")]
        public virtual Guid CardType { get; set; }
        [Display(Name = "证件号码")]
        public virtual string CardID { get; set; }

        /// <summary>
        /// 放款详细信息		
        /// </summary>
        [Display(Name = "放款详细信息")]
        public virtual ObservableCollection<LoanEntryItemModel> LoanEntryList{ get; set; } = new ObservableCollection<LoanEntryItemModel>();
        /// <summary>
        /// 主合同号码		
        /// </summary>
        [Display(Name = "主合同号码")]
        public virtual string ContractID { get; set; }
        /// <summary>
        /// 主合同编号		
        /// </summary>
        [Display(Name = "主合同编号")]
        public virtual string ContractNo { get; set; }

        /// <summary>
        /// 授信总额
        /// </summary>
        [Display(Name = "授信总额")]
        public virtual decimal TotalCredit { get; set; }

        /// <summary>
        /// 在保总额
        /// </summary>
        [Display(Name = "在保总额")]
        public virtual decimal TotalLoanAmount { get; set; }

        /// <summary>
        /// 投向		
        /// </summary>
        [Display(Name = "投向")]
        public virtual Guid DirectionID { get; set; }
        /// <summary>
        /// 是否有效		
        /// </summary>
        [Display(Name = "是否有效")]
        public virtual bool IsMain { get; set; }

        #region VM使用



        #endregion

        #endregion


        #region 构造

        protected LoanCreditorItemModel()
        {
            //this.Creditor = CreditorItemViewModel.Create();

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
        public void Assign(LoanCreditorItemModel loanCreditor)
        {
            this.ID = loanCreditor.ID;
            //this.Creditor = contact.Creditor;
            //this.Creditor.Assign(loanCreditor.Creditor);
            //this.LoanDetailList = loanCreditor.LoanDetailList;
            this.CreditorName = loanCreditor.CreditorName;
            this.CardType = loanCreditor.CardType;
            this.CardID = loanCreditor.CardID;
            this.LoanEntryList = loanCreditor.LoanEntryList;
            this.ContractID = loanCreditor.ContractID;
            this.ContractNo = loanCreditor.ContractNo;
            this.TotalCredit = loanCreditor.TotalCredit;
            this.TotalLoanAmount = loanCreditor.TotalLoanAmount;
            this.DirectionID = loanCreditor.DirectionID;
            this.IsMain = loanCreditor.IsMain;

        }

        [Command(false)]
        public object Clone()
        {
            return Create(x =>
            {
                x.ID = this.ID;
                x.CreditorName = this.CreditorName;
                x.CardType = this.CardType;
                x.CardID = this.CardID;
                x.LoanEntryList = this.LoanEntryList;
                x.ContractID = this.ContractID;
                x.ContractNo = this.ContractNo;
                x.TotalCredit = this.TotalCredit;
                x.TotalLoanAmount = this.TotalLoanAmount;
                x.DirectionID = this.DirectionID;
                x.IsMain = this.IsMain;

            });
        }




    }

}
