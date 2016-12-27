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
    /// 用于显示保费详细信息，包含项目简介
    /// </summary>
    public class PremiumDisplayItemModel : ICloneable
    {

        #region 属性       


        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "项目的保费ID",AutoGenerateField = false)]
        public virtual Guid ID { get; set; }
        /// <summary>
        /// 项目简介		
        /// </summary>
        [Display(Name = "项目简介")]
        public virtual DisplayLoanBriefContentModel DisplayLoanBriefContent { get; set; }
        /// <summary>
        /// 保费收取详细信息		
        /// </summary>
        [Display(Name = "保费收取详细信息")]
        public virtual ObservableCollection<PremiumItemModel> PremiumItems { get; set; }

        #endregion


        #region 构造

        protected PremiumDisplayItemModel()
        {
           
        }

        public static PremiumDisplayItemModel Create()
        {
            return ViewModelSource.Create(() => new PremiumDisplayItemModel());
        }

        public static PremiumDisplayItemModel Create(Action<PremiumDisplayItemModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        #endregion

        [Command(false)]
        public void Assign(PremiumDisplayItemModel content)
        {
            this.ID = content.ID;
            this.DisplayLoanBriefContent = content.DisplayLoanBriefContent;
            this.PremiumItems = content.PremiumItems;

        }

        [Command(false)]
        public object Clone()
        {
            return Create(x =>
            {
                x.ID = this.ID;
                x.DisplayLoanBriefContent = this.DisplayLoanBriefContent;
                x.PremiumItems = this.PremiumItems;

            });
        }




    }
}
