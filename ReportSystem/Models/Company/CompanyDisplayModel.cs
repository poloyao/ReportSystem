using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataAnnotations;

namespace ReportSystem.Models
{
    public class CompanyDisplayModel : ICloneable
    {

        #region 属性       


        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual Guid ID { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual CompanyInfoModel Info { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual ObservableCollection<CompanyManagersModel> CM { get; set; } = new ObservableCollection<CompanyManagersModel>();
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual ObservableCollection<CompanyStockholderModel> CS { get; set; } = new ObservableCollection<CompanyStockholderModel>();
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual ObservableCollection<CompanyBranchModel> CB { get; set; } = new ObservableCollection<CompanyBranchModel>();
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public virtual ObservableCollection<CompanyAccountModel> CA { get; set; } = new ObservableCollection<CompanyAccountModel>();

        #endregion


        #region 构造

        protected CompanyDisplayModel()
        {

        }

        public static CompanyDisplayModel Create()
        {
            return ViewModelSource.Create(() => new CompanyDisplayModel());
        }

        public static CompanyDisplayModel Create(Action<CompanyDisplayModel> objectInitializer)
        {
            var result = Create();
            objectInitializer(result);
            return result;
        }

        #endregion

        [Command(false)]
        public void Assign(CompanyDisplayModel content)
        {
            this.ID = content.ID;
            this.Info = content.Info;
            this.CM = content.CM;
            this.CS = content.CS;
            this.CB = content.CB;
            this.CA = content.CA;

        }

        [Command(false)]
        public object Clone()
        {
            return Create(x =>
            {
                x.ID = this.ID;
                x.Info = this.Info;
                x.CM = this.CM;
                x.CS = this.CS;
                x.CB = this.CB;
                x.CA = this.CA;

            });
        }




    }
}
