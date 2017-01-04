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
    /// 具体的追偿信息内容
    /// </summary>
    public class SupervisionRecoveryModel : ICloneable
    {

        #region 属性       


        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "", AutoGenerateField = false)]
        public virtual Guid ID { get; set; }
        /// <summary>
        /// 追偿日期		
        /// </summary>
        [Display(Name = "追偿日期")]
        public virtual DateTime? RecoveryDate { get; set; }
        /// <summary>
        /// 追偿金额		
        /// </summary>
        [Display(Name = "追偿金额")]
        [DataType(DataType.Currency)]
        public virtual Decimal RecoveryAmount { get; set; }

        /// <summary>
        /// 本机构追偿金额		
        /// </summary>
        [Display(Name = "本机构追偿金额")]
        [DataType(DataType.Currency)]
        public virtual Decimal OwnRecoveryAmount { get; set; }
        /// <summary>
        /// 是否确认损失		
        /// </summary>
        [Display(Name = "是否确认损失")]
        public virtual bool IsLoss { get; set; }
        /// <summary>
        /// 损失金额		
        /// </summary>
        [Display(Name = "损失金额")]
        [DataType(DataType.Currency)]
        public virtual Decimal LossAmount { get; set; }
        /// <summary>
        /// 是否继续追偿		
        /// </summary>
        [Display(Name = "是否继续追偿")]
        public virtual Guid GoMark { get; set; }

        #endregion


        #region 构造

        protected SupervisionRecoveryModel()
        {

        }

        public static SupervisionRecoveryModel Create()
        {
            return ViewModelSource.Create(() => new SupervisionRecoveryModel());
        }

        public static SupervisionRecoveryModel Create(Action<SupervisionRecoveryModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        #endregion

        [Command(false)]
        public void Assign(SupervisionRecoveryModel content)
        {
            this.ID = content.ID;
            this.RecoveryDate = content.RecoveryDate;
            this.RecoveryAmount = content.RecoveryAmount;
            this.OwnRecoveryAmount = content.OwnRecoveryAmount;
            this.IsLoss = content.IsLoss;
            this.LossAmount = content.LossAmount;
            this.GoMark = content.GoMark;

        }

        [Command(false)]
        public object Clone()
        {
            return Create(x =>
            {
                x.ID = this.ID;
                x.RecoveryDate = this.RecoveryDate;
                x.RecoveryAmount = this.RecoveryAmount;
                x.OwnRecoveryAmount = this.OwnRecoveryAmount;
                x.IsLoss = this.IsLoss;
                x.LossAmount = this.LossAmount;
                x.GoMark = this.GoMark;

            });
        }




    }

}
