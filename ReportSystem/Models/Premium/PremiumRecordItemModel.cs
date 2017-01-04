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
    /// 缴费单笔详细记录
    /// </summary>
    public class PremiumRecordItemModel : ICloneable
    {

        #region 属性       


        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "", AutoGenerateField = false)]
        public virtual Guid ID { get; set; }
        /// <summary>
        /// 缴费类别	不参与显示	
        /// </summary>
        [Display(Name = "缴费类别", AutoGenerateField = false)]
        public virtual Guid PayCategory { get; set; }
        /// <summary>
        /// 应缴金额		
        /// </summary>
        [Display(Name = "应缴金额")]
        [DataType(DataType.Currency)]
        public virtual Decimal PayableAmount { get; set; }
        /// <summary>
        /// 应缴日期		
        /// </summary>
        [NumericMask(Mask = PredefinedMasks.DateTime.LongDate)]
        [Display(Name = "应缴日期")]
        public virtual DateTime PayableDate { get; set; }
        /// <summary>
        /// 实缴日期		
        /// </summary>
        [NumericMask(Mask = PredefinedMasks.DateTime.LongDate)]
        [Display(Name = "实缴日期")]
        public virtual DateTime PaidDate { get; set; }
        /// <summary>
        /// 欠缴金额		
        /// </summary>
        [Display(Name = "欠缴金额")]
        [DataType(DataType.Currency)]
        public virtual Decimal ArrearsAmount { get; set; }
        /// <summary>
        /// 本期状态		
        /// </summary>
        [Display(Name = "本期状态")]
        public virtual Guid CurrentStatus { get; set; }

        #endregion


        #region 构造

        protected PremiumRecordItemModel()
        {

        }

        public static PremiumRecordItemModel Create()
        {
            return ViewModelSource.Create(() => new PremiumRecordItemModel());
        }

        public static PremiumRecordItemModel Create(Action<PremiumRecordItemModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        #endregion

        [Command(false)]
        public void Assign(PremiumRecordItemModel content)
        {
            this.ID = content.ID;
            this.PayCategory = content.PayCategory;
            this.PayableAmount = content.PayableAmount;
            this.PayableDate = content.PayableDate;
            this.PaidDate = content.PaidDate;
            this.ArrearsAmount = content.ArrearsAmount;
            this.CurrentStatus = content.CurrentStatus;

        }

        [Command(false)]
        public object Clone()
        {
            return Create(x =>
            {
                x.ID = this.ID;
                x.PayCategory = this.PayCategory;
                x.PayableAmount = this.PayableAmount;
                x.PayableDate = this.PayableDate;
                x.PaidDate = this.PaidDate;
                x.ArrearsAmount = this.ArrearsAmount;
                x.CurrentStatus = this.CurrentStatus;

            });
        }




    }
}
