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

    public class CompanyInfoModel : ICloneable
    {

        #region 属性       


        const string BaseGroup = "Base";
        const string CZGroup = "出资情况";
        const string LXRGroup = "联系人信息";
        const string YGGroup = "员工情况";


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
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info8 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info9 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info10 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info11 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info12 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info13 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info14 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info15 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info16 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info17 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info18 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info19 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info20 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info21 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info22 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info23 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info24 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info25 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual string Info26 { get; set; }

        [Display(Name = "")]
        public virtual string Info27 { get; set; }

        [Display(Name = "")]
        public virtual string Info28 { get; set; }
        [Display(Name = "")]
        public virtual string Info29 { get; set; }
        [Display(Name = "")]
        public virtual string Info30 { get; set; }
        [Display(Name = "")]
        public virtual string Info31 { get; set; }
        [Display(Name = "")]
        public virtual string Info32 { get; set; }
        [Display(Name = "")]
        public virtual string Info33 { get; set; }
        [Display(Name = "")]
        public virtual string Info34 { get; set; }
        [Display(Name = "")]
        public virtual string Info35 { get; set; }

        #endregion


        #region 构造

        protected CompanyInfoModel()
        {

        }

        public static CompanyInfoModel Create()
        {
            return ViewModelSource.Create(() => new CompanyInfoModel());
        }

        public static CompanyInfoModel Create(Action<CompanyInfoModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        #endregion

        [Command(false)]
        public void Assign(CompanyInfoModel content)
        {
            this.ID = content.ID;
            this.Info1 = content.Info1;
            this.Info2 = content.Info2;
            this.Info3 = content.Info3;
            this.Info4 = content.Info4;
            this.Info5 = content.Info5;
            this.Info6 = content.Info6;
            this.Info7 = content.Info7;
            this.Info8 = content.Info8;
            this.Info9 = content.Info9;
            this.Info10 = content.Info10;
            this.Info11 = content.Info11;
            this.Info12 = content.Info12;
            this.Info13 = content.Info13;
            this.Info14 = content.Info14;
            this.Info15 = content.Info15;
            this.Info16 = content.Info16;
            this.Info17 = content.Info17;
            this.Info18 = content.Info18;
            this.Info19 = content.Info19;
            this.Info20 = content.Info20;
            this.Info21 = content.Info21;
            this.Info22 = content.Info22;
            this.Info23 = content.Info23;
            this.Info24 = content.Info24;
            this.Info25 = content.Info25;
            this.Info26 = content.Info26;

            this.Info27 = content.Info27;
            this.Info28 = content.Info28;
            this.Info29 = content.Info29;
            this.Info30 = content.Info30;
            this.Info31 = content.Info31;
            this.Info32 = content.Info32;
            this.Info33 = content.Info33;
            this.Info34 = content.Info34;
            this.Info35 = content.Info35;

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
                x.Info8 = this.Info8;
                x.Info9 = this.Info9;
                x.Info10 = this.Info10;
                x.Info11 = this.Info11;
                x.Info12 = this.Info12;
                x.Info13 = this.Info13;
                x.Info14 = this.Info14;
                x.Info15 = this.Info15;
                x.Info16 = this.Info16;
                x.Info17 = this.Info17;
                x.Info18 = this.Info18;
                x.Info19 = this.Info19;
                x.Info20 = this.Info20;
                x.Info21 = this.Info21;
                x.Info22 = this.Info22;
                x.Info23 = this.Info23;
                x.Info24 = this.Info24;
                x.Info25 = this.Info25;
                x.Info26 = this.Info26;

                x.Info27 = this.Info27;
                x.Info28 = this.Info28;
                x.Info29 = this.Info29;
                x.Info30 = this.Info30;
                x.Info31 = this.Info31;
                x.Info32 = this.Info32;
                x.Info33 = this.Info33;
                x.Info34 = this.Info34;
                x.Info35 = this.Info35;

            });
        }




    }
}
