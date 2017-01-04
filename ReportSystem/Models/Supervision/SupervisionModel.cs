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
    /// <summary>
    /// 用于列表显示
    /// </summary>
    public class SupervisionModel : ICloneable
    {

        #region 属性       


        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "", AutoGenerateField = false)]
        public virtual Guid ID { get; set; }

        /// <summary>
        /// 项目编号		
        /// </summary>
        [Display(Name = "项目编号")]
        public virtual string ProjectNo { get; set; }
        /// <summary>
        /// 主被担保人		
        /// </summary>
        [Display(Name = "主被担保人")]
        public virtual string MainWarantee { get; set; }
        /// <summary>
        /// 担保金额		
        /// </summary>
        [NumericMask(Mask = PredefinedMasks.Numeric.Number)]
        [Display(Name = "担保金额")]
        [DataType(DataType.Currency)]
        public virtual decimal Amount { get; set; }

        /// <summary>
        /// 记账日期	
        /// 当因发生代偿而报送记录时，指最近一次代偿日期；
        /// 当因发生追偿而报送记录时，指最近一次追偿日期；
        /// 当因发生损失而报送记录时，指损失确认日期 
        /// </summary>
        [NumericMask(Mask = PredefinedMasks.DateTime.LongDate)]
        [Display(Name = "记账日期")]
        public virtual DateTime AccountingDate { get; set; }
        /// <summary>
        /// 继续追偿标记		
        /// </summary>
        [Display(Name = "继续追偿标记")]
        public virtual Guid GoMark { get; set; }
        /// <summary>
        /// 最近一次代偿日期		
        /// </summary>
        [NumericMask(Mask = PredefinedMasks.DateTime.LongDate)]
        [Display(Name = "最近一次代偿日期")]
        public virtual DateTime LastRepaymentDate { get; set; }
        /// <summary>
        /// 累计代偿金额		
        /// </summary>
        [Display(Name = "累计代偿金额")]
        [DataType(DataType.Currency)]
        public virtual Decimal TotalRepaymentAmount { get; set; }
        /// <summary>
        /// 本机构承担代偿金额		
        /// </summary>
        [Display(Name = "本机构承担代偿金额")]
        [DataType(DataType.Currency)]
        public virtual Decimal OwnRepaymentAmount { get; set; }
        /// <summary>
        /// 最近一次追偿日期 	DateTime?
        /// </summary>
        [NumericMask(Mask = PredefinedMasks.DateTime.LongDate)]
        [Display(Name = "最近一次追偿日期")]
        public virtual DateTime? LastRecoveryDate { get; set; }
        /// <summary>
        /// 代偿余额		
        /// </summary>
        [Display(Name = "代偿余额")]
        [DataType(DataType.Currency)]
        public virtual Decimal RepaymentBalance { get; set; }
        /// <summary>
        /// 本机构承担代偿余额		
        /// </summary>
        [Display(Name = "本机构承担代偿余额")]
        [DataType(DataType.Currency)]
        public virtual Decimal OwnRepaymentBalance { get; set; }
        /// <summary>
        /// 累计追偿金额		
        /// </summary>
        [Display(Name = "累计追偿金额")]
        [DataType(DataType.Currency)]
        public virtual Decimal TotalRecoveryAmount { get; set; }
        /// <summary>
        /// 累计损失金额		
        /// </summary>
        [Display(Name = "累计损失金额")]
        [DataType(DataType.Currency)]
        public virtual Decimal TotalLossAmount { get; set; }

        #endregion


        #region 构造

        protected SupervisionModel()
        {

        }

        public static SupervisionModel Create()
        {
            return ViewModelSource.Create(() => new SupervisionModel());
        }

        public static SupervisionModel Create(Action<SupervisionModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        #endregion

        [Command(false)]
        public void Assign(SupervisionModel content)
        {
            this.ID = content.ID;

            this.ProjectNo = content.ProjectNo;
            this.MainWarantee = content.MainWarantee;
            this.Amount = content.Amount;

            this.AccountingDate = content.AccountingDate;
            this.GoMark = content.GoMark;
            this.LastRepaymentDate = content.LastRepaymentDate;
            this.TotalRepaymentAmount = content.TotalRepaymentAmount;
            this.OwnRepaymentAmount = content.OwnRepaymentAmount;
            this.LastRecoveryDate = content.LastRecoveryDate;
            this.RepaymentBalance = content.RepaymentBalance;
            this.OwnRepaymentBalance = content.OwnRepaymentBalance;
            this.TotalRecoveryAmount = content.TotalRecoveryAmount;
            this.TotalLossAmount = content.TotalLossAmount;

        }

        [Command(false)]
        public object Clone()
        {
            return Create(x =>
            {
                x.ID = this.ID;

                x.ProjectNo = this.ProjectNo;
                x.MainWarantee = this.MainWarantee;
                x.Amount = this.Amount;

                x.AccountingDate = this.AccountingDate;
                x.GoMark = this.GoMark;
                x.LastRepaymentDate = this.LastRepaymentDate;
                x.TotalRepaymentAmount = this.TotalRepaymentAmount;
                x.OwnRepaymentAmount = this.OwnRepaymentAmount;
                x.LastRecoveryDate = this.LastRecoveryDate;
                x.RepaymentBalance = this.RepaymentBalance;
                x.OwnRepaymentBalance = this.OwnRepaymentBalance;
                x.TotalRecoveryAmount = this.TotalRecoveryAmount;
                x.TotalLossAmount = this.TotalLossAmount;

            });
        }




    }

}
