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
    public class CreditorItemModel : ICloneable
    {

        #region 属性       


        /// <summary>
        /// 		
        /// </summary>
        [Display(AutoGenerateField = false)]
        public virtual Guid ID { get; set; }
        /// <summary>
        /// 债权人类型		
        /// </summary>
        [Display(Name = "债权人类型")]
        public virtual Guid CreditorType { get; set; }
        /// <summary>
        /// 债权人名称		
        /// </summary>
        [Display(Name = "债权人名称")]
        public virtual string CreditorName { get; set; }
        /// <summary>
        /// 证件类型		
        /// </summary>
        [Display(Name = "证件类型")]
        public virtual Guid CardType { get; set; }
        /// <summary>
        /// 证件号码		
        /// </summary>
        [Display(Name = "证件号码")]
        public virtual string CardID { get; set; }

        #endregion


        #region 构造

        protected CreditorItemModel()
        {

        }

        public static CreditorItemModel Create()
        {
            return ViewModelSource.Create(() => new CreditorItemModel());
        }

        public static CreditorItemModel Create(Action<CreditorItemModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        #endregion

        [Command(false)]
        public void Assign(CreditorItemModel contact)
        {
            this.ID = contact.ID;
            this.CreditorType = contact.CreditorType;
            this.CreditorName = contact.CreditorName;
            this.CardType = contact.CardType;
            this.CardID = contact.CardID;

        }

        [Command(false)]
        public object Clone()
        {
            return Create(x =>
            {
                x.ID = this.ID;
                x.CreditorType = this.CreditorType;
                x.CreditorName = this.CreditorName;
                x.CardType = this.CardType;
                x.CardID = this.CardID;

            });
        }




    }
}
