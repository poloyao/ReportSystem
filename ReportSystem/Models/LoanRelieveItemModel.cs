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
    /// 解除信息
    /// </summary>
    public class LoanRelieveItemModel : ICloneable
    {

        #region 属性       


        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "", AutoGenerateField = false)]
        public virtual Guid ID { get; set; }
        /// <summary>
        /// 解除类型	联动解除金额	
        /// </summary>
        //[BindableProperty(OnPropertyChangedMethodName = "OnRelieveTypeChanged")]
        [Display(Name = "解除类型")]
        public virtual Guid RelieveType { get; set; }
        /// <summary>
        /// 解除金额	最大金额取决与之前批次解除余额	
        /// </summary>
        [Display(Name = "解除金额")]
        public virtual decimal RelieveAmount { get; set; }

        /// <summary>
        /// 代偿金额
        /// </summary>
        [Display(Name = "代偿金额")]
        public virtual decimal RepaymentAmount { get; set; }

        /// <summary>
        /// 本机构代偿金额
        /// </summary>
        [Display(Name = "本机构代偿金额")]
        public virtual decimal OwnRepaymentAmount { get; set; }
        /// <summary>
        /// 解除日期	最小日期取决入上笔或放款时间	
        /// </summary>
        [NumericMask(Mask = PredefinedMasks.DateTime.LongDate)]
        [Display(Name = "解除日期")]
        public virtual DateTime RelieveDate { get; set; }

        /// <summary>
        /// 最小的解除日期 vm
        /// </summary>
        [Display(Name = "最小日期", AutoGenerateField = false)]
        public virtual DateTime MinRelieveDate { get; set; }

        /// <summary>
        /// 最大解除数 vm
        /// </summary>
        [Display(Name = "最大解除数", AutoGenerateField = false)]
        public virtual decimal MaxRelieveAmount { get; set; }

        ///// <summary>
        ///// 是否锁定数字区域 vm
        ///// </summary>
        //[Display(Name = "是否锁定",AutoGenerateField = false)]
        //public virtual bool IsLock { get; set; } = false;


        #endregion


        #region 构造

        protected LoanRelieveItemModel()
        {

        }

        public static LoanRelieveItemModel Create()
        {
            return ViewModelSource.Create(() => new LoanRelieveItemModel());
        }

        public static LoanRelieveItemModel Create(Action<LoanRelieveItemModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        #endregion

        [Command(false)]
        public void Assign(LoanRelieveItemModel content)
        {
            this.ID = content.ID;
            this.RelieveType = content.RelieveType;
            this.RelieveAmount = content.RelieveAmount;
            this.RepaymentAmount = content.RepaymentAmount;
            this.OwnRepaymentAmount = content.OwnRepaymentAmount;
            this.RelieveDate = content.RelieveDate;

        }

        [Command(false)]
        public object Clone()
        {
            return Create(x =>
            {
                x.ID = this.ID;
                x.RelieveType = this.RelieveType;
                x.RelieveAmount = this.RelieveAmount;
                x.RepaymentAmount = this.RepaymentAmount;
                x.OwnRepaymentAmount = this.OwnRepaymentAmount;
                x.RelieveDate = this.RelieveDate;

            });
        }

        




    }

}
