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

    public class LoanItemModel : ICloneable
    {

        #region 属性       


        /// <summary>
        /// 		
        /// </summary>
        [Display(AutoGenerateField = false)]
        public virtual Guid ID { get; set; }

        [Display(Name = "项目编号")]
        public virtual string ProjectNo { get; set; }

        [Display(Name = "被担保人")]
        public virtual string MianWarrantee { get; set; }
        /// <summary>
        /// 担保总额		
        /// </summary>
        [Display(Name = "担保总额")]
        public virtual decimal Amount { get; set; }
        /// <summary>
        /// 放款金额		
        /// </summary>
        [Display(Name = "放款金额")]
        public virtual decimal LoanAmount { get; set; }

        #endregion


        #region 构造

        protected LoanItemModel()
        {

        }

        public static LoanItemModel Create()
        {
            return ViewModelSource.Create(() => new LoanItemModel());
        }

        public static LoanItemModel Create(Action<LoanItemModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        #endregion

        [Command(false)]
        public void Assign(LoanItemModel content)
        {
            this.ID = content.ID;
            this.ProjectNo = content.ProjectNo;
            this.Amount = content.Amount;
            this.LoanAmount = content.LoanAmount;

        }

        [Command(false)]
        public object Clone()
        {
            return Create(x =>
            {
                x.ID = this.ID;
                x.ProjectNo = this.ProjectNo;
                x.Amount = this.Amount;
                x.LoanAmount = this.LoanAmount;

            });
        }




    }

}
