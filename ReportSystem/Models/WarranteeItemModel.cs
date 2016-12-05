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

    public class WarranteeItemModel : ICloneable
    {

        #region 属性       


        /// <summary>
        /// 		
        /// </summary>
        [Display(AutoGenerateField = false)]
        public virtual Guid ID { get; set; }
        /// <summary>
        /// 被担保人类型		
        /// </summary>
        [Display(Name = "被担保人类型")]
        public virtual Guid WarranteeType { get; set; }
        /// <summary>
        /// 被担保人名称		
        /// </summary>
        [Display(Name = "被担保人名称")]
        public virtual string Name { get; set; }
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
        /// <summary>
        /// 主被担保人		
        /// </summary>
        [Display(Name = "主被担保人")]
        public virtual bool IsMain { get; set; }

        #endregion


        #region 构造

        protected WarranteeItemModel()
        {

        }

        public static WarranteeItemModel Create()
        {
            return ViewModelSource.Create(() => new WarranteeItemModel());
        }

        public static WarranteeItemModel Create(Action<WarranteeItemModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        #endregion


        public bool CheckNotNull()
        {
            //contact.ID = 
            int result = 0;
            result += this.WarranteeType == Guid.Empty ? 1 : 0;
            result += (this.Name == null || this.Name == "") ? 1 : 0;
            result += this.CardType == Guid.Empty ? 1 : 0;
            result += (this.CardID == null || this.CardID == "") ? 1 : 0;
            if (result == 0)
                return true;
            return false;
        }

        [Command(false)]
        public void Assign(WarranteeItemModel contact)
        {
            this.ID = contact.ID;
            this.WarranteeType = contact.WarranteeType;
            this.Name = contact.Name;
            this.CardType = contact.CardType;
            this.CardID = contact.CardID;
            this.IsMain = contact.IsMain;

        }

        [Command(false)]
        public object Clone()
        {
            return Create(x =>
            {
                x.ID = this.ID;
                x.WarranteeType = this.WarranteeType;
                x.Name = this.Name;
                x.CardType = this.CardType;
                x.CardID = this.CardID;
                x.IsMain = this.IsMain;

            });
        }




    }
}
