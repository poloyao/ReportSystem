using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Models
{
    public class CreditorItemModel : ICloneable, IDataErrorInfo
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


        string Error { get; set; }
        string IDataErrorInfo.Error { get { return Error; } }

        string IDataErrorInfo.this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "CreditorType":
                        return ValidateCreditorType(CreditorType) ? string.Empty : Error;
                    case "CreditorName":
                        return ValidateCreditorName(CreditorName) ? string.Empty : Error;
                    case "CardType":
                        return ValidateCardType(CardType) ? string.Empty : Error;
                    case "CardID":
                        return ValidateCardID(CardID) ? string.Empty : Error;
                }

                return string.Empty;
            }
        }


        public bool ValidateCreditorType(Guid id)
        {
            if (id == null || id == Guid.Empty)
            {
                Error = "不能为空";
                return false;
            }
            return true;
        }

        public bool ValidateCreditorName(string creditorName)
        {
            if (creditorName == null || creditorName == string.Empty)
            {
                Error = "不能为空";
                return false;
            }
            return true;
        }

        public bool ValidateCardType(Guid id)
        {
            //!++ 需要根据类型判断相应的类型
            //UNDONE 需要根据类型判断相应的类型
            if (id == null || id == Guid.Empty)
            {
                Error = "不能为空";
                return false;
            }
            return true;
        }


        public bool ValidateCardID(string Card)
        {
            if (Card == null || Card == string.Empty || Card.Length > 18)
            {
                Error = "不能为空，且长度不能超过18位";
                return false;
            }
            return true;
        }









    }
}
