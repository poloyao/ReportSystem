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
    public class CompanyAccountModel : ICloneable
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

        #endregion


        #region 构造

        protected CompanyAccountModel()
        {

        }

        public static CompanyAccountModel Create()
        {
            return ViewModelSource.Create(() => new CompanyAccountModel());
        }

        public static CompanyAccountModel Create(Action<CompanyAccountModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        #endregion

        [Command(false)]
        public void Assign(CompanyAccountModel content)
        {
            this.ID = content.ID;
            this.Info1 = content.Info1;
            this.Info2 = content.Info2;
            this.Info3 = content.Info3;

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

            });
        }




    }
}
