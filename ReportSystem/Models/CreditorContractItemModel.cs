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
   
    public class CreditorContractItemModel : ICloneable
    {

        #region 属性       


        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "",AutoGenerateField = false)]
        public virtual Guid ID { get; set; }
        /// <summary>
        /// 主合同号码		
        /// </summary>
        [Display(Name = "主合同号码")]
        public virtual string ContractID { get; set; }
        /// <summary>
        /// 主合同编号		
        /// </summary>
        [Display(Name = "主合同编号")]
        public virtual string ContractNo { get; set; }
        /// <summary>
        /// 投向		
        /// </summary>
        [Display(Name = "投向")]
        public virtual Guid DirectionID { get; set; }
        /// <summary>
        /// 是否有效		
        /// </summary>
        [Display(Name = "是否有效")]
        public virtual bool IsMain { get; set; }

        #endregion


        #region 构造

        protected CreditorContractItemModel()
        {

        }

        public static CreditorContractItemModel Create()
        {
            return ViewModelSource.Create(() => new CreditorContractItemModel());
        }

        public static CreditorContractItemModel Create(Action<CreditorContractItemModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        #endregion

        [Command(false)]
        public void Assign(CreditorContractItemModel content)
        {
            this.ID = content.ID;
            this.ContractID = content.ContractID;
            this.ContractNo = content.ContractNo;
            this.DirectionID = content.DirectionID;
            this.IsMain = content.IsMain;

        }

        [Command(false)]
        public object Clone()
        {
            return Create(x =>
            {
                x.ID = this.ID;
                x.ContractID = this.ContractID;
                x.ContractNo = this.ContractNo;
                x.DirectionID = this.DirectionID;
                x.IsMain = this.IsMain;

            });
        }




    }

}
