using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Models
{
    public class ReportMonthModel
    {
        public ReportMonthSheet1 Sheet1 { get; set; }
        public ReportMonthSheet2 Sheet2 { get; set; }
        public ReportMonthSheet3 Sheet3 { get; set; }
        public ReportMonthSheet4 Sheet4 { get; set; }
    }

    public class ReportMonthSheet1
    {
        #region 构造方法

        public ReportMonthSheet1()
        {

        }

        #endregion

        #region 属性	

        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public Guid ID { get; set; }
        /// <summary>
        /// 担保机构名称		
        /// </summary>
        [Display(Name = "担保机构名称")]
        public string A01 { get; set; }
        /// <summary>
        /// 注册资本		
        /// </summary>
        [Display(Name = "注册资本")]
        public string A02 { get; set; }
        /// <summary>
        /// 净资产		
        /// </summary>
        [Display(Name = "净资产")]
        public string A03 { get; set; }
        /// <summary>
        /// 现金类资产		
        /// </summary>
        [Display(Name = "现金类资产")]
        public string A04 { get; set; }
        /// <summary>
        /// 存入保证金		
        /// </summary>
        [Display(Name = "存入保证金")]
        public string A05 { get; set; }
        /// <summary>
        /// 存出保证金		
        /// </summary>
        [Display(Name = "存出保证金")]
        public string A06 { get; set; }
        /// <summary>
        /// 担保准备金		
        /// </summary>
        [Display(Name = "担保准备金")]
        public string A07 { get; set; }
        /// <summary>
        /// 本年累计担保额		
        /// </summary>
        [Display(Name = "本年累计担保额")]
        public string A08 { get; set; }
        /// <summary>
        /// 个人担保金额		
        /// </summary>
        [Display(Name = "个人担保金额")]
        public string A09 { get; set; }
        /// <summary>
        /// 企业担保金额		
        /// </summary>
        [Display(Name = "企业担保金额")]
        public string A10 { get; set; }
        /// <summary>
        /// 本年累计担保企业户数		
        /// </summary>
        [Display(Name = "本年累计担保企业户数")]
        public string A11 { get; set; }
        /// <summary>
        /// 本年累计担保人数		
        /// </summary>
        [Display(Name = "本年累计担保人数")]
        public string A12 { get; set; }
        /// <summary>
        /// 本年累计代偿额		
        /// </summary>
        [Display(Name = "本年累计代偿额")]
        public string A13 { get; set; }
        /// <summary>
        /// 本年累计解除担保额		
        /// </summary>
        [Display(Name = "本年累计解除担保额")]
        public string A14 { get; set; }
        /// <summary>
        /// 担保代偿余额		
        /// </summary>
        [Display(Name = "担保代偿余额")]
        public string A15 { get; set; }
        /// <summary>
        /// 本年累计损失额		
        /// </summary>
        [Display(Name = "本年累计损失额")]
        public string A16 { get; set; }
        /// <summary>
        /// 本年累计担保收入		
        /// </summary>
        [Display(Name = "本年累计担保收入")]
        public string A17 { get; set; }
        /// <summary>
        /// 净利润		
        /// </summary>
        [Display(Name = "净利润")]
        public string A18 { get; set; }
        /// <summary>
        /// 纳税		
        /// </summary>
        [Display(Name = "纳税")]
        public string A19 { get; set; }
        /// <summary>
        /// 在保责任余额		
        /// </summary>
        [Display(Name = "在保责任余额")]
        public string A20 { get; set; }
        /// <summary>
        /// 个人在保余额		
        /// </summary>
        [Display(Name = "个人在保余额")]
        public string A21 { get; set; }
        /// <summary>
        /// 企业在保余额		
        /// </summary>
        [Display(Name = "企业在保余额")]
        public string A22 { get; set; }
        /// <summary>
        /// 在保企业户数		
        /// </summary>
        [Display(Name = "在保企业户数")]
        public string A23 { get; set; }
        /// <summary>
        /// 在保人数		
        /// </summary>
        [Display(Name = "在保人数")]
        public string A24 { get; set; }
        /// <summary>
        /// 年份		
        /// </summary>
        [Display(Name = "年份")]
        public string Year { get; set; }
        /// <summary>
        /// 季度		
        /// </summary>
        [Display(Name = "季度")]
        public string Month { get; set; }
        /// <summary>
        /// 状态		
        /// </summary>
        [Display(Name = "状态")]
        public int Status { get; set; }


        #endregion

    }

    public class ReportMonthSheet2
    {
        #region 构造方法

        public ReportMonthSheet2()
        {

        }

        #endregion

        #region 属性	

        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public Guid ID { get; set; }
        /// <summary>
        /// 担保机构名称		
        /// </summary>
        [Display(Name = "担保机构名称")]
        public string A01 { get; set; }
        /// <summary>
        /// 月初在保责任余额		
        /// </summary>
        [Display(Name = "月初在保责任余额")]
        public string A02 { get; set; }
        /// <summary>
        /// 本月担保发生额		
        /// </summary>
        [Display(Name = "本月担保发生额")]
        public string A03 { get; set; }
        /// <summary>
        /// 中小企业担保额		
        /// </summary>
        [Display(Name = "中小企业担保额")]
        public string A04 { get; set; }
        /// <summary>
        /// 县域企业担保额		
        /// </summary>
        [Display(Name = "县域企业担保额")]
        public string A05 { get; set; }
        /// <summary>
        /// 高新技术企业担保额		
        /// </summary>
        [Display(Name = "高新技术企业担保额")]
        public string A06 { get; set; }
        /// <summary>
        /// 本月担保企业户数		
        /// </summary>
        [Display(Name = "本月担保企业户数")]
        public string A07 { get; set; }
        /// <summary>
        /// 中小企业户数		
        /// </summary>
        [Display(Name = "中小企业户数")]
        public string A08 { get; set; }
        /// <summary>
        /// 县域企业户数		
        /// </summary>
        [Display(Name = "县域企业户数")]
        public string A09 { get; set; }
        /// <summary>
        /// 高新技术企业户数		
        /// </summary>
        [Display(Name = "高新技术企业户数")]
        public string A10 { get; set; }
        /// <summary>
        /// 本月解除担保额		
        /// </summary>
        [Display(Name = "本月解除担保额")]
        public string A11 { get; set; }
        /// <summary>
        /// 月末在保责任余额		
        /// </summary>
        [Display(Name = "月末在保责任余额")]
        public string A12 { get; set; }
        /// <summary>
        /// 中小企业在保余额		
        /// </summary>
        [Display(Name = "中小企业在保余额")]
        public string A13 { get; set; }
        /// <summary>
        /// 县域企业在保余额		
        /// </summary>
        [Display(Name = "县域企业在保余额")]
        public string A14 { get; set; }
        /// <summary>
        /// 高新技术企业在保余额		
        /// </summary>
        [Display(Name = "高新技术企业在保余额")]
        public string A15 { get; set; }
        /// <summary>
        /// 月末在保企业户数		
        /// </summary>
        [Display(Name = "月末在保企业户数")]
        public string A16 { get; set; }
        /// <summary>
        /// 中小企业户数		
        /// </summary>
        [Display(Name = "中小企业户数")]
        public string A17 { get; set; }
        /// <summary>
        /// 县域企业户数		
        /// </summary>
        [Display(Name = "县域企业户数")]
        public string A18 { get; set; }
        /// <summary>
        /// 高新技术企业户数		
        /// </summary>
        [Display(Name = "高新技术企业户数")]
        public string A19 { get; set; }
        /// <summary>
        /// 年份		
        /// </summary>
        [Display(Name = "年份")]
        public string Year { get; set; }
        /// <summary>
        /// 月份		
        /// </summary>
        [Display(Name = "月份")]
        public string Month { get; set; }
        /// <summary>
        /// 状态		
        /// </summary>
        [Display(Name = "状态")]
        public int Status { get; set; }


        #endregion

    }

    public class ReportMonthSheet3
    {
        #region 构造方法

        public ReportMonthSheet3()
        {

        }

        #endregion

        #region 属性	

        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public Guid ID { get; set; }
        /// <summary>
        /// 担保机构名称		
        /// </summary>
        [Display(Name = "担保机构名称")]
        public string A01 { get; set; }
        /// <summary>
        /// 月初在保责任余额		
        /// </summary>
        [Display(Name = "月初在保责任余额")]
        public string A02 { get; set; }
        /// <summary>
        /// 其中：下岗失业人员小额贷款担保额		
        /// </summary>
        [Display(Name = "其中：下岗失业人员小额贷款担保额")]
        public string A03 { get; set; }
        /// <summary>
        /// 本月担保人数		
        /// </summary>
        [Display(Name = "本月担保人数")]
        public string A04 { get; set; }
        /// <summary>
        /// 其中：下岗失业人员小额贷款人数		
        /// </summary>
        [Display(Name = "其中：下岗失业人员小额贷款人数")]
        public string A05 { get; set; }
        /// <summary>
        /// 本月解除额		
        /// </summary>
        [Display(Name = "本月解除额")]
        public string A06 { get; set; }
        /// <summary>
        /// 月末在保余额		
        /// </summary>
        [Display(Name = "月末在保余额")]
        public string A07 { get; set; }
        /// <summary>
        /// 其中：下岗失业人员小额贷款余额		
        /// </summary>
        [Display(Name = "其中：下岗失业人员小额贷款余额")]
        public string A08 { get; set; }
        /// <summary>
        /// 月末在保人数		
        /// </summary>
        [Display(Name = "月末在保人数")]
        public string A09 { get; set; }
        /// <summary>
        /// 其中：下岗失业人员小额贷款在保人数		
        /// </summary>
        [Display(Name = "其中：下岗失业人员小额贷款在保人数")]
        public string A10 { get; set; }
        /// <summary>
        /// 年份		
        /// </summary>
        [Display(Name = "年份")]
        public string Year { get; set; }
        /// <summary>
        /// 月份		
        /// </summary>
        [Display(Name = "月份")]
        public string Month { get; set; }
        /// <summary>
        /// 状态		
        /// </summary>
        [Display(Name = "状态")]
        public int Status { get; set; }


        #endregion

    }

    public class ReportMonthSheet4
    {
        #region 构造方法

        public ReportMonthSheet4()
        {

        }

        #endregion

        #region 属性	

        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public Guid ID { get; set; }
        /// <summary>
        /// 担保机构名称		
        /// </summary>
        [Display(Name = "担保机构名称")]
        public string A01 { get; set; }
        /// <summary>
        /// 注册资本		
        /// </summary>
        [Display(Name = "注册资本")]
        public string A02 { get; set; }
        /// <summary>
        /// 本年累计担保额		
        /// </summary>
        [Display(Name = "本年累计担保额")]
        public string A03 { get; set; }
        /// <summary>
        /// 其中：本月担保额		
        /// </summary>
        [Display(Name = "其中：本月担保额")]
        public string A04 { get; set; }
        /// <summary>
        /// 本年累计解除担保额		
        /// </summary>
        [Display(Name = "本年累计解除担保额")]
        public string A05 { get; set; }
        /// <summary>
        /// 本年累计代偿额		
        /// </summary>
        [Display(Name = "本年累计代偿额")]
        public string A06 { get; set; }
        /// <summary>
        /// 本年累计损失额		
        /// </summary>
        [Display(Name = "本年累计损失额")]
        public string A07 { get; set; }
        /// <summary>
        /// 本年累计实现担保收入		
        /// </summary>
        [Display(Name = "本年累计实现担保收入")]
        public string A08 { get; set; }
        /// <summary>
        /// 期末在保余额		
        /// </summary>
        [Display(Name = "期末在保余额")]
        public string A09 { get; set; }
        /// <summary>
        /// 年份		
        /// </summary>
        [Display(Name = "年份")]
        public string Year { get; set; }
        /// <summary>
        /// 月份		
        /// </summary>
        [Display(Name = "月份")]
        public string Month { get; set; }
        /// <summary>
        /// 状态		
        /// </summary>
        [Display(Name = "状态")]
        public int Status { get; set; }


        #endregion

    }


}
