using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Models
{
    public class SupervisionDetailModel : ICloneable
    {

        #region 属性       


        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "",AutoGenerateField = false)]
        public virtual Guid ID { get; set; }

        #region MyRegion

        ///// <summary>
        ///// 项目编号		
        ///// </summary>
        //[Display(Name = "项目编号")]
        //public virtual string ProjectNo { get; set; }
        ///// <summary>
        ///// 被担保人类型		
        ///// </summary>
        //[Display(Name = "被担保人类型")]
        //public virtual Guid WarranteeType { get; set; }
        ///// <summary>
        ///// 主被担保人名称		
        ///// </summary>
        //[Display(Name = "主被担保人名称")]
        //public virtual string Name { get; set; }
        ///// <summary>
        ///// 担保业务种类		
        ///// </summary>
        //[Display(Name = "担保业务种类")]
        //public virtual Guid BusinessType { get; set; }
        ///// <summary>
        ///// 担保方式		
        ///// </summary>
        //[Display(Name = "担保方式")]
        //public virtual Guid GuaranteeType { get; set; }
        ///// <summary>
        ///// 担保金额		
        ///// </summary>
        //[Display(Name = "担保金额")]
        //public virtual Decimal Amount { get; set; }
        ///// <summary>
        ///// 总放款金额		
        ///// </summary>
        //[Display(Name = "总放款金额")]
        //public virtual Decimal LoanSumAmount { get; set; }

        //[Display(Name = "代偿金额")]
        //public virtual Decimal RepaymentAmount { get; set; }

        //[Display(Name = "追偿金额")]
        //public virtual Decimal RecoveryAmount { get; set; }

        #endregion

        /// <summary>
        /// 代偿基本信息
        /// </summary>
        [Display(Name = "代偿基本信息")]
        public SupervisionModel SupervisionItem { get; set; }

        /// <summary>
        /// 放款债权人关系表		
        /// </summary>
        [Display(Name = "放款债权人关系表")]
        public virtual List<LoanCreditorItemModel> LoanCreditors { get; set; }
        /// <summary>
        /// 追偿信息		
        /// </summary>
        [Display(Name = "追偿信息")]
        public virtual List<SupervisionRecoveryModel> RecoveryItems { get; set; }

        #endregion

        protected SupervisionDetailModel()
        {
            this.SupervisionItem = SupervisionModel.Create();
            this.LoanCreditors = new List<LoanCreditorItemModel>();
            this.RecoveryItems = new List<SupervisionRecoveryModel>();
        }

        public static SupervisionDetailModel Create()
        {
            return ViewModelSource.Create(() => new SupervisionDetailModel());
        }

        public static SupervisionDetailModel Create(Action<SupervisionDetailModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        [Command(false)]
        public void Assign(SupervisionDetailModel contact)
        {
            this.ID = contact.ID;
            //this.ProjectNo = contact.ProjectNo;
            //this.WarranteeType = contact.WarranteeType;
            //this.Name = contact.Name;
            //this.BusinessType = contact.BusinessType;
            //this.GuaranteeType = contact.GuaranteeType;
            //this.Amount = contact.Amount;
            //this.LoanSumAmount = contact.LoanSumAmount;

            this.SupervisionItem = contact.SupervisionItem;
            this.LoanCreditors = contact.LoanCreditors;
            this.RecoveryItems = contact.RecoveryItems;

        }

        [Command(false)]
        public object Clone()
        {
            return Create(x =>
            {
                x.ID = this.ID;
                //x.ProjectNo = this.ProjectNo;
                //x.WarranteeType = this.WarranteeType;
                //x.Name = this.Name;
                //x.BusinessType = this.BusinessType;
                //x.GuaranteeType = this.GuaranteeType;
                //x.Amount = this.Amount;
                //x.LoanSumAmount = this.LoanSumAmount;

                x.SupervisionItem = this.SupervisionItem;
                x.LoanCreditors = this.LoanCreditors;
                x.RecoveryItems = this.RecoveryItems;

            });
        }




    }

}
