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

    public class ProjectItemModel : ICloneable
    {

        #region 属性       

        [Display(AutoGenerateField = false)]
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
        public virtual decimal Amount { get; set; }
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
        /// 起始时间		
        /// </summary>
        [NumericMask(Mask = PredefinedMasks.DateTime.LongDate)]
        [Display(Name = "起始时间")]
        public virtual DateTime? StartDate { get; set; }
        /// <summary>
        /// 起始时间		
        /// </summary>
        [NumericMask(Mask = PredefinedMasks.DateTime.LongDate)]
        [Display(Name = "起始时间")]
        public virtual DateTime EndDate { get; set; }


        #endregion

        public static ProjectItemModel Create()
        {
            return ViewModelSource.Create(() => new ProjectItemModel());
        }

        protected ProjectItemModel() { }

        public static ProjectItemModel Create(Action<ProjectItemModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        [Command(false)]
        public void Assign(ProjectItemModel contact)
        {
            this.ID = contact.ID;
            this.ProjectNo = contact.ProjectNo;
            this.MainWarantee = contact.MainWarantee;
            this.Amount = contact.Amount;
            this.BusinessType = contact.BusinessType;
            this.GuaranteeType = contact.GuaranteeType;
            this.StartDate = contact.StartDate;
            this.EndDate = contact.EndDate;
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
                x.BusinessType = this.BusinessType;
                x.GuaranteeType = this.GuaranteeType;
                x.StartDate = this.StartDate;
                x.EndDate = this.EndDate;
            });
        }

      


    }
}
