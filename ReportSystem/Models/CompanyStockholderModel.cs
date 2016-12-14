using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;

namespace ReportSystem.Models
{
    public class CompanyStockholderModel : ICloneable
    {

        #region 属性       


        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "",AutoGenerateField = false)]
        public virtual Guid ID { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info1 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info2 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info3 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info4 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info5 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info6 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info7 { get; set; }

        #endregion


        #region 构造

        protected CompanyStockholderModel()
        {

        }

        public static CompanyStockholderModel Create()
        {
            return ViewModelSource.Create(() => new CompanyStockholderModel());
        }

        public static CompanyStockholderModel Create(Action<CompanyStockholderModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        #endregion

        [Command(false)]
        public void Assign(CompanyStockholderModel content)
        {
            this.ID = content.ID;
            this.Info1 = content.Info1;
            this.Info2 = content.Info2;
            this.Info3 = content.Info3;
            this.Info4 = content.Info4;
            this.Info5 = content.Info5;
            this.Info6 = content.Info6;
            this.Info7 = content.Info7;

        }

        [Command(false)]
        public object Clone()
        {
            return Create(x =>
            {
                x.ID = this.ID;
                x.Info1 = this.Info1;
                x.Info2 = this.Info2;
                x.Info3 = this.Info3;
                x.Info4 = this.Info4;
                x.Info5 = this.Info5;
                x.Info6 = this.Info6;
                x.Info7 = this.Info7;

            });
        }




    }
}
