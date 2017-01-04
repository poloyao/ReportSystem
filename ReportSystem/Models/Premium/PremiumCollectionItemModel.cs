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

    public class PremiumCollectionItemModel : ICloneable
    {

        #region 属性       


        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "", AutoGenerateField = false)]
        public virtual Guid ID { get; set; }
        /// <summary>
        /// 关联项目 废弃		
        /// </summary>
        [Display(Name = "关联项目", AutoGenerateField = false)]
        public virtual string ProjectID { get; set; }
        /// <summary>
        /// 项目编号
        /// </summary>
        [Display(Name = "项目编号")]
        public virtual string ProjectNo { get; set; }
        /// <summary>
        /// 最近记账日期		
        /// </summary>
        [NumericMask(Mask = PredefinedMasks.DateTime.LongDate)]
        [Display(Name = "最近记账日期")]
        public virtual DateTime? PreviousBookedDate { get; set; }
        /// <summary>
        /// 缴纳状态		
        /// </summary>
        [Display(Name = "缴纳状态")]
        public virtual Guid? PremiumStatus { get; set; }
        /// <summary>
        /// 累计金额		
        /// </summary>
        [Display(Name = "累计金额")]
        [DataType(DataType.Currency)]
        public virtual decimal TotalAmount { get; set; }

        #endregion


        #region 构造

        protected PremiumCollectionItemModel()
        {

        }

        public static PremiumCollectionItemModel Create()
        {
            return ViewModelSource.Create(() => new PremiumCollectionItemModel());
        }

        public static PremiumCollectionItemModel Create(Action<PremiumCollectionItemModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        #endregion

        [Command(false)]
        public void Assign(PremiumCollectionItemModel content)
        {
            this.ID = content.ID;
            this.ProjectID = content.ProjectID;
            this.ProjectNo = content.ProjectNo;
            this.PreviousBookedDate = content.PreviousBookedDate;
            this.PremiumStatus = content.PremiumStatus;
            this.TotalAmount = content.TotalAmount;

        }

        [Command(false)]
        public object Clone()
        {
            return Create(x =>
            {
                x.ID = this.ID;
                x.ProjectID = this.ProjectID;
                x.ProjectNo = this.ProjectNo;
                x.PreviousBookedDate = this.PreviousBookedDate;
                x.PremiumStatus = this.PremiumStatus;
                x.TotalAmount = this.TotalAmount;

            });
        }
    }
}
