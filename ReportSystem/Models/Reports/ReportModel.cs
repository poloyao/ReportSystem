using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Models
{
    /// <summary>
    /// 报表类型
    /// </summary>
    public enum ReportType
    {
        MONTH,
        QUARTER,
        HALFYEAR,
        YEAR
    }

    /// <summary>
    /// 报表状态
    /// </summary>
    public enum ReportStatus
    {
        /// <summary>
        /// 未填写
        /// </summary>
        UNFILLED, //未填写
        /// <summary>
        /// 待上报
        /// </summary>
        CANREPORT, //待上报
        /// <summary>
        /// 已上报
        /// </summary>
        REPORTED, //已上报
        /// <summary>
        /// 可修改
        /// </summary>
        MODIFIED //可修改
    }
    public class ReportModel
    {
        [Display(AutoGenerateField = false)]
        public Guid ID { get; set; }
        /// <summary>
        /// 年份
        /// </summary>
        [Display(Name = "年份")]
        public String Year { get; set; }
        /// <summary>
        /// 报表类型
        /// </summary>
        [Display(Name = "报表类型",AutoGenerateField = false)]
        public ReportType RType { get; set; }
        /// <summary>
        /// 期数
        /// </summary>
        [Display(Name = "期数")]
        public int Period { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        [Display(Name = "日期")]
        public DateTime UDP { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name = "状态")]
        public ReportStatus Status { get; set; }
        
    }
}
