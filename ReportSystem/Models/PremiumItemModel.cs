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

    /// <summary>
    /// 保费缴费基础内容   
    /// </summary>
    public class PremiumItemModel : ICloneable
    {

        #region 属性       


        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "", AutoGenerateField = false)]
        public virtual Guid ID { get; set; }
        /// <summary>
        /// 缴费类型		
        /// </summary>
        [Display(Name = "缴费类型")]
        public virtual Guid PayCategory { get; set; }
        /// <summary>
        /// 记账日期 不参与界面录入	
        /// </summary>
        [NumericMask(Mask = PredefinedMasks.DateTime.LongDate)]
        [Display(Name = "记账日期")]
        public virtual DateTime? AccountingDate { get; set; }
        /// <summary>
        /// 缴费金额		
        /// </summary>
        [Display(Name = "缴费金额")]
        public virtual Decimal PayAmount { get; set; }
        /// <summary>
        /// 缴纳方式		
        /// </summary>
        [Display(Name = "缴纳方式")]
        public virtual Guid PayMethod { get; set; }
        /// <summary>
        /// 缴纳频率		
        /// </summary>
        [Display(Name = "缴纳频率")]
        public virtual Guid PayFre { get; set; }
        /// <summary>
        /// 计费起始日期		
        /// </summary>
        [NumericMask(Mask = PredefinedMasks.DateTime.LongDate)]
        [Display(Name = "计费起始日期")]
        public virtual DateTime StartDate { get; set; } = DateTime.Now;
        /// <summary>
        /// 缴纳结束日期		
        /// </summary>
        [NumericMask(Mask = PredefinedMasks.DateTime.LongDate)]
        [Display(Name = "缴纳结束日期")]
        public virtual DateTime EndDate { get; set; } = DateTime.Now;
        /// <summary>
        /// 余额		
        /// </summary>
        [Display(Name = "余额")]
        public virtual Decimal Balance { get; set; }
        /// <summary>
        /// 累计欠缴金额		
        /// </summary>
        [Display(Name = "累计欠缴金额")]
        public virtual Decimal TotalArrears { get; set; }
        /// <summary>
        /// 缴纳状态		
        /// </summary>
        [Display(Name = "缴纳状态")]
        public virtual Guid PayStatus { get; set; }

        /// <summary>
        /// 阅读模式 默认true。add时修改为false
        /// </summary>
        //[Display(Name = "阅读模式",AutoGenerateField = false)]
        //public virtual bool IsRead { get; set; } = true;

        /// <summary>
        /// 缴费列表
        /// </summary>
        //[BindableProperty(OnPropertyChangedMethodName = "OnPremiumDetailAddItemViewModelListChanged")]
        [Display(Name = "缴费列表")]
        public virtual ObservableCollection<PremiumRecordItemModel> PremiumRecordItems { get; set; } = new ObservableCollection<PremiumRecordItemModel>();


        #endregion


        protected void OnPremiumDetailAddItemViewModelListChanged()
        {

        }



        #region 构造

        protected PremiumItemModel()
        {

        }

        public static PremiumItemModel Create()
        {
            return ViewModelSource.Create(() => new PremiumItemModel());
        }

        public static PremiumItemModel Create(Action<PremiumItemModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        #endregion

        [Command(false)]
        public void Assign(PremiumItemModel content)
        {
            this.ID = content.ID;
            this.PayCategory = content.PayCategory;
            this.AccountingDate = content.AccountingDate;
            this.PayAmount = content.PayAmount;
            this.PayMethod = content.PayMethod;
            this.PayFre = content.PayFre;
            this.StartDate = content.StartDate;
            this.EndDate = content.EndDate;
            this.Balance = content.Balance;
            this.TotalArrears = content.TotalArrears;
            this.PayStatus = content.PayStatus;

        }

        [Command(false)]
        public object Clone()
        {
            return Create(x =>
            {
                x.ID = this.ID;
                x.PayCategory = this.PayCategory;
                x.AccountingDate = this.AccountingDate;
                x.PayAmount = this.PayAmount;
                x.PayMethod = this.PayMethod;
                x.PayFre = this.PayFre;
                x.StartDate = this.StartDate;
                x.EndDate = this.EndDate;
                x.Balance = this.Balance;
                x.TotalArrears = this.TotalArrears;
                x.PayStatus = this.PayStatus;

            });
        }



    }
}
