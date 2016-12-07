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

    public partial class LoanEntryItemModel : ICloneable
    {

        #region 属性       


        /// <summary>
        /// 		
        /// </summary>
        [Display(AutoGenerateField = false)]
        public virtual Guid ID { get; set; }
        /// <summary>
        /// 放款金额		
        /// </summary>
        [Display(Name = "放款金额")]
        public virtual decimal Amount { get; set; }

        /// <summary>
        /// 解除金额 vm	
        /// </summary>
        [Display(Name = "解除金额", AutoGenerateField = false)]
        public virtual decimal RelieveAmount { get; set; } = 0;

        /// <summary>
        /// 开始日期 
        /// </summary>
        [NumericMask(Mask = PredefinedMasks.DateTime.LongDate)]
        [Display(Name = "开始日期")]
        public virtual DateTime StartDate { get; set; } = DateTime.Now;
        /// <summary>
        /// 结束日期		
        /// </summary>
        [NumericMask(Mask = PredefinedMasks.DateTime.LongDate)]
        [Display(Name = "结束日期")]
        public virtual DateTime EndDate { get; set; } = DateTime.Now;
        /// <summary>
        /// 状态		
        /// </summary>
        [Display(Name = "状态")]
        public virtual int LoanStatus { get; set; }

        #endregion


        #region 构造

        protected LoanEntryItemModel()
        {

        }

        public static LoanEntryItemModel Create()
        {
            return ViewModelSource.Create(() => new LoanEntryItemModel());
        }

        public static LoanEntryItemModel Create(Action<LoanEntryItemModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        #endregion

        [Command(false)]
        public void Assign(LoanEntryItemModel contact)
        {
            this.ID = contact.ID;
            this.Amount = contact.Amount;
            this.StartDate = contact.StartDate;
            this.EndDate = contact.EndDate;

        }

        [Command(false)]
        public object Clone()
        {
            return Create(x =>
            {
                x.ID = this.ID;
                x.Amount = this.Amount;
                //x.LoanDate = this.LoanDate;
                x.StartDate = this.StartDate;
                x.EndDate = this.EndDate;

            });
        }




    }
}
