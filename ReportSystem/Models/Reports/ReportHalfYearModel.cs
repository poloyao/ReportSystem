using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ReportSystem.Models
{
    public class ReportHalfYearModel
    {
        [Display(AutoGenerateField = false)]
        public Guid ID { get; set; }

        [Display(Name = "担保机构名称")]
        public string OrgName { get; set; }

        [Display(Name = "成立时间")]
        public string FoundDate { get; set; }

        [Display(Name = "注册资本")]
        public string RegAmount { get; set; }

        [Display(Name = "经营许可证号")]
        public string License { get; set; }

        [Display(Name = "法定代表人")]
        public string Legal { get; set; }

        [Display(Name = "年度",Order = 1)]
        public string Year { get; set; }

        [Display(Name = "上/下半年",Order = 2)]
        public string HalfYear { get; set; }

        public ObservableCollection<ReportHalfYearDetailModel> HalfYearDetail { get; set; } = new ObservableCollection<ReportHalfYearDetailModel>();
    }

    public class ReportHalfYearDetailModel
    {
        [Display(Name = "账户性质")]
        public string A01 { get; set; }
        [Display(Name = "开户行全称")]
        public string A02 { get; set; }
        [Display(Name = "开户行地址")]
        public string A03 { get; set; }
        [Display(Name = "开户账号")]
        public string A04 { get; set; }
    }
}
