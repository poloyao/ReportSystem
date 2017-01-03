using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Models
{
    public class ContractItemModel : ICloneable //, IDataErrorInfo
    {

        #region 属性       


        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "",AutoGenerateField = false)]
        public virtual Guid ID { get; set; }
        /// <summary>
        /// 项目编号		
        /// </summary>
        [Display(Name = "项目编号")]
        public virtual string ProjectNo { get; set; }
        /// <summary>
        /// 担保合同号码		
        /// </summary>
        [Display(Name = "担保合同号码")]
        public virtual string ContractrNo { get; set; }

        /// <summary>
        /// 主被担保人
        /// </summary>
        [Display(Name = "主被担保人")]
        public virtual string MainWarranteeName { get; set; }
        /// <summary>
        /// 担保业务种类		
        /// </summary>
        [Display(Name = "担保业务种类")]
        public virtual Guid BusinessType { get; set; }
        /// <summary>
        /// 担保方式		
        /// </summary>
        [Display(Name = "担保方式")]
        public virtual Guid GuaranteeType { get; set; }
        /// <summary>
        /// 担保金额		
        /// </summary>
        [Display(Name = "担保金额")]
        [DataType(DataType.Currency)]
        public virtual Decimal Amount { get; set; }
        /// <summary>
        /// 起始时间		
        /// </summary>
        [Display(Name = "起始时间")]
        public virtual DateTime? StartDate { get; set; }
        /// <summary>
        /// 结束时间		
        /// </summary>
        [Display(Name = "结束时间")]
        public virtual DateTime? EndDate { get; set; }
        /// <summary>
        /// 存出保证金比例		
        /// </summary>
        [Display(Name = "存出保证金比例")]
        public virtual Decimal DepositRatio { get; set; }
        /// <summary>
        /// 约定再担保比例		
        /// </summary>
        [Display(Name = "约定再担保比例")]
        public virtual Decimal ReRatio { get; set; }
        /// <summary>
        /// 反担保方式		
        /// </summary>
        [Display(Name = "反担保方式")]
        public virtual Guid CounterGuarantee { get; set; }
        /// <summary>
        /// 费率		
        /// </summary>
        [Display(Name = "费率")]
        public virtual Decimal Rates { get; set; }
        /// <summary>
        /// 年化费率		
        /// </summary>
        [Display(Name = "年化费率")]
        public virtual Decimal YearRates { get; set; }
        /// <summary>
        /// 被担保人信息		
        /// </summary>
        [Display(Name = "被担保人信息")]
        public virtual IList<WarranteeItemModel> WarranteeItems { get; set; }

        /// <summary>
        /// 是否可以修改标记
        /// </summary>
        [Display(Name ="是否可以修改标记",AutoGenerateField = false)]
        public bool AllowEdit { get; set; }

        //string Error { get; set; } = string.Empty;
        //string IDataErrorInfo.Error { get { return Error; } }

        //string IDataErrorInfo.this[string columnName]
        //{
        //    get
        //    {
        //        switch (columnName)
        //        {
        //            case "Amount":
        //                return ValidateAmount(Amount) ? string.Empty : Error;
        //        }
        //        return string.Empty;
        //    }
        //}

        

        #endregion


        #region 构造

        protected ContractItemModel()
        {
            this.WarranteeItems = new List<WarranteeItemModel>();
        }

        public static ContractItemModel Create()
        {
            return ViewModelSource.Create(() => new ContractItemModel());
        }

        public static ContractItemModel Create(Action<ContractItemModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        #endregion

        [Command(false)]
        public void Assign(ContractItemModel contact)
        {
            this.ID = contact.ID;
            this.ProjectNo = contact.ProjectNo;
            this.ContractrNo = contact.ContractrNo;
            this.MainWarranteeName = contact.MainWarranteeName;
            this.BusinessType = contact.BusinessType;
            this.GuaranteeType = contact.GuaranteeType;
            this.Amount = contact.Amount;
            this.StartDate = contact.StartDate;
            this.EndDate = contact.EndDate;
            this.DepositRatio = contact.DepositRatio;
            this.ReRatio = contact.ReRatio;
            this.CounterGuarantee = contact.CounterGuarantee;
            this.Rates = contact.Rates;
            this.YearRates = contact.YearRates;
            this.WarranteeItems = contact.WarranteeItems;

        }

        [Command(false)]
        public object Clone()
        {
            return Create(x =>
            {
                x.ID = this.ID;
                x.ProjectNo = this.ProjectNo;
                x.ContractrNo = this.ContractrNo;
                x.MainWarranteeName = this.MainWarranteeName;
                x.BusinessType = this.BusinessType;
                x.GuaranteeType = this.GuaranteeType;
                x.Amount = this.Amount;
                x.StartDate = this.StartDate;
                x.EndDate = this.EndDate;
                x.DepositRatio = this.DepositRatio;
                x.ReRatio = this.ReRatio;
                x.CounterGuarantee = this.CounterGuarantee;
                x.Rates = this.Rates;
                x.YearRates = this.YearRates;
                x.WarranteeItems = this.WarranteeItems;

            });
        }


        //public bool ValidateAmount(decimal amount)
        //{
        //    bool isValid = amount > 0;
        //    if (isValid)
        //        Error = string.Empty;
        //    else
        //        Error = "金额必须大于0";
        //    return isValid;
        //}

    }
}
