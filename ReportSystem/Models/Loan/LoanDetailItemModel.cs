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

    public class LoanSingleItemlModel : ICloneable
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
        /// 被担保人类型		
        /// </summary>
        [Display(Name = "被担保人类型")]
        public virtual Guid WarranteeType { get; set; }
        /// <summary>
        /// 主被担保人名称		
        /// </summary>
        [Display(Name = "主被担保人名称")]
        public virtual string Name { get; set; }
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
        public virtual Decimal Amount { get; set; }
        /// <summary>
        /// 总放款金额		
        /// </summary>
        [Display(Name = "总放款金额")]
        public virtual Decimal LoanSumAmount { get; set; }
        /// <summary>
        /// 债权人信息列表		
        /// </summary>
        [Display(Name = "债权人信息列表", AutoGenerateField = false)]
        public virtual List<LoanCreditorItemModel> LoanCreditorItems { get; set; }

        #endregion


        #region 构造

        protected LoanSingleItemlModel()
        {
            LoanCreditorItems = new List<LoanCreditorItemModel>();
        }

        public static LoanSingleItemlModel Create()
        {
            return ViewModelSource.Create(() => new LoanSingleItemlModel());
        }

        public static LoanSingleItemlModel Create(Action<LoanSingleItemlModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        #endregion

        [Command(false)]
        public void Assign(LoanSingleItemlModel content)
        {
            this.ID = content.ID;
            this.ProjectNo = content.ProjectNo;
            this.WarranteeType = content.WarranteeType;
            this.Name = content.Name;
            this.BusinessType = content.BusinessType;
            this.GuaranteeType = content.GuaranteeType;
            this.Amount = content.Amount;
            this.LoanSumAmount = content.LoanSumAmount;
            this.LoanCreditorItems = content.LoanCreditorItems;

        }

        [Command(false)]
        public object Clone()
        {
            return Create(x =>
            {
                x.ID = this.ID;
                x.ProjectNo = this.ProjectNo;
                x.WarranteeType = this.WarranteeType;
                x.Name = this.Name;
                x.BusinessType = this.BusinessType;
                x.GuaranteeType = this.GuaranteeType;
                x.Amount = this.Amount;
                x.LoanSumAmount = this.LoanSumAmount;
                x.LoanCreditorItems = this.LoanCreditorItems;

            });
        }




    }

}
