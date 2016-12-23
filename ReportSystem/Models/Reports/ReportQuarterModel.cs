using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Models
{
    public class ReportQuarterModel
    {
        //public List<ReportQuarterSheet1> sheet1 { get; set; }
        //public List<ReportQuarterSheet2> sheet2 { get; set; }

        public ReportQuarterSheet1 sheet1 { get; set; }
        public ReportQuarterSheet2 sheet2 { get; set; }
        public List<ReportQuarterSheet3> sheet3 { get; set; }
    }


    public class ReportQuarterSheet1
        {
            #region 构造方法

            public ReportQuarterSheet1()
            {

            }

            #endregion

            #region 属性	

            /// <summary>
            /// 		
            /// </summary>
            [Display(Name = "",AutoGenerateField = false)]
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
            /// 成立时间		
            /// </summary>
            [Display(Name = "成立时间")]
            public string A03 { get; set; }
            /// <summary>
            /// 是否今年新开展业务机构		
            /// </summary>
            [Display(Name = "是否今年新开展业务机构")]
            public string A04 { get; set; }
            /// <summary>
            /// 机构性质		
            /// </summary>
            [Display(Name = "机构性质")]
            public string A05 { get; set; }
            /// <summary>
            /// 合作银行家数		
            /// </summary>
            [Display(Name = "合作银行家数")]
            public string A06 { get; set; }
            /// <summary>
            /// 合作银行名称		
            /// </summary>
            [Display(Name = "合作银行名称")]
            public string A07 { get; set; }
            /// <summary>
            /// 授信时间		
            /// </summary>
            [Display(Name = "授信时间")]
            public string A08 { get; set; }
            /// <summary>
            /// 授信额度		
            /// </summary>
            [Display(Name = "授信额度")]
            public string A09 { get; set; }
            /// <summary>
            /// 当年累计新增担保额		
            /// </summary>
            [Display(Name = "当年累计新增担保额")]
            public string A10 { get; set; }
            /// <summary>
            /// 在保责任余额		
            /// </summary>
            [Display(Name = "在保责任余额")]
            public string A11 { get; set; }
            /// <summary>
            /// 放大倍数		
            /// </summary>
            [Display(Name = "放大倍数")]
            public string A12 { get; set; }
            /// <summary>
            /// 是否为今年以来新增合作银行		
            /// </summary>
            [Display(Name = "是否为今年以来新增合作银行")]
            public string A13 { get; set; }
            /// <summary>
            /// 纳入再担保体系时间		
            /// </summary>
            [Display(Name = "纳入再担保体系时间")]
            public string A14 { get; set; }
            /// <summary>
            /// 年份		
            /// </summary>
            [Display(Name = "年份",Order = 1)]
            public string Year { get; set; }
            /// <summary>
            /// 季度		
            /// </summary>
            [Display(Name = "季度",Order = 2)]
            public string Quarter { get; set; }
            /// <summary>
            /// 状态		
            /// </summary>
            [Display(Name = "状态")]
            public int Status { get; set; }


            #endregion

        }

    public class ReportQuarterSheet2
    {
        #region 构造方法

        public ReportQuarterSheet2()
        {

        }

        #endregion

        #region 属性	
        [Display(Name = "",AutoGenerateField = false)]
        public Guid ID { get; set; }

        /// <summary>
        /// 担保机构名称		
        /// </summary>
        [Display(Name = "担保机构名称")]
        public string A01 { get; set; }
        /// <summary>
        /// 年初余额		
        /// </summary>
        [Display(Name = "年初余额")]
        public string A02 { get; set; }
        /// <summary>
        /// 本年累计发放贷款金额		
        /// </summary>
        [Display(Name = "本年累计发放贷款金额")]
        public string A03 { get; set; }
        /// <summary>
        /// 本年累计实现收益		
        /// </summary>
        [Display(Name = "本年累计实现收益")]
        public string A04 { get; set; }
        /// <summary>
        /// 期末余额		
        /// </summary>
        [Display(Name = "期末余额")]
        public string A05 { get; set; }
        /// <summary>
        /// 年初余额		
        /// </summary>
        [Display(Name = "年初余额")]
        public string A06 { get; set; }
        /// <summary>
        /// 本年累计对外投资		
        /// </summary>
        [Display(Name = "本年累计对外投资")]
        public string A07 { get; set; }
        /// <summary>
        /// 债权投资		
        /// </summary>
        [Display(Name = "债权投资")]
        public string A08 { get; set; }
        /// <summary>
        /// 股权投资		
        /// </summary>
        [Display(Name = "股权投资")]
        public string A09 { get; set; }
        /// <summary>
        /// 其他投资		
        /// </summary>
        [Display(Name = "其他投资")]
        public string A10 { get; set; }
        /// <summary>
        /// 本年累计实现投资收益		
        /// </summary>
        [Display(Name = "本年累计实现投资收益")]
        public string A11 { get; set; }
        /// <summary>
        /// 期末余额		
        /// </summary>
        [Display(Name = "期末余额")]
        public string A12 { get; set; }
        /// <summary>
        /// 债权投资余额		
        /// </summary>
        [Display(Name = "债权投资余额")]
        public string A13 { get; set; }
        /// <summary>
        /// 股权投资余额		
        /// </summary>
        [Display(Name = "股权投资余额")]
        public string A14 { get; set; }
        /// <summary>
        /// 其他投资余额		
        /// </summary>
        [Display(Name = "其他投资余额")]
        public string A15 { get; set; }

        /// <summary>
        /// 年份		
        /// </summary>
        [Display(Name = "年份",Order = 1)]
        public string Year { get; set; }
        /// <summary>
        /// 季度		
        /// </summary>
        [Display(Name = "季度",Order = 2)]
        public string Quarter { get; set; }
        /// <summary>
        /// 状态		
        /// </summary>
        [Display(Name = "状态")]
        public int Status { get; set; }


        #endregion

    }

    public class ReportQuarterSheet3
    {
        #region 构造方法

        public ReportQuarterSheet3()
        {

        }

        #endregion

        #region 属性	
        [Display(Name = "",AutoGenerateField = false)]
        public Guid ID { get; set; }
        /// <summary>
        /// 1.法人机构（家）		
        /// </summary>
        [Display(Name = "1.法人机构（家）")]
        public string A01 { get; set; }
        /// <summary>
        /// （1）其中：1.1国有控股		
        /// </summary>
        [Display(Name = "（1）其中：1.1国有控股")]
        public string A02 { get; set; }
        /// <summary>
        /// 1.2民营及外资控股		
        /// </summary>
        [Display(Name = "1.2民营及外资控股")]
        public string A03 { get; set; }
        /// <summary>
        /// （2）其中：再担保机构		
        /// </summary>
        [Display(Name = "（2）其中：再担保机构")]
        public string A04 { get; set; }
        /// <summary>
        /// 2.从业人员(人)		
        /// </summary>
        [Display(Name = "2.从业人员(人)")]
        public string A05 { get; set; }
        /// <summary>
        /// 3.实收资本		
        /// </summary>
        [Display(Name = "3.实收资本")]
        public string A06 { get; set; }
        /// <summary>
        /// 其中：3.1国有控股		
        /// </summary>
        [Display(Name = "其中：3.1国有控股")]
        public string A07 { get; set; }
        /// <summary>
        /// 3.2民营及外资控股		
        /// </summary>
        [Display(Name = "3.2民营及外资控股")]
        public string A08 { get; set; }
        /// <summary>
        /// 4.净资产		
        /// </summary>
        [Display(Name = "4.净资产")]
        public string A09 { get; set; }
        /// <summary>
        /// 5.融资担保业务在保余额		
        /// </summary>
        [Display(Name = "5.融资担保业务在保余额")]
        public string A10 { get; set; }
        /// <summary>
        /// （1）其中：5.1国有控股		
        /// </summary>
        [Display(Name = "（1）其中：5.1国有控股")]
        public string A11 { get; set; }
        /// <summary>
        ///  5.2民营及外资控股		
        /// </summary>
        [Display(Name = " 5.2民营及外资控股")]
        public string A12 { get; set; }
        /// <summary>
        /// （2）其中：小微企业担保		
        /// </summary>
        [Display(Name = "（2）其中：小微企业担保")]
        public string A13 { get; set; }
        /// <summary>
        /// 涉农担保		
        /// </summary>
        [Display(Name = "涉农担保")]
        public string A14 { get; set; }
        /// <summary>
        /// 6.融资担保业务在保户数		
        /// </summary>
        [Display(Name = "6.融资担保业务在保户数")]
        public string A15 { get; set; }
        /// <summary>
        /// 其中：小微企业担保户数		
        /// </summary>
        [Display(Name = "其中：小微企业担保户数")]
        public string A16 { get; set; }
        /// <summary>
        /// 涉农担保户数		
        /// </summary>
        [Display(Name = "涉农担保户数")]
        public string A17 { get; set; }
        /// <summary>
        /// 7.再担保业务在保余额		
        /// </summary>
        [Display(Name = "7.再担保业务在保余额")]
        public string A18 { get; set; }
        /// <summary>
        /// 8.融资担保放大倍数(倍)		
        /// </summary>
        [Display(Name = "8.融资担保放大倍数(倍)")]
        public string A19 { get; set; }
        /// <summary>
        /// 9.融资担保代偿金额		
        /// </summary>
        [Display(Name = "9.融资担保代偿金额")]
        public string A20 { get; set; }
        /// <summary>
        /// 10.融资担保损失金额		
        /// </summary>
        [Display(Name = "10.融资担保损失金额")]
        public string A21 { get; set; }
        /// <summary>
        /// 11.融资担保代偿率		
        /// </summary>
        [Display(Name = "11.融资担保代偿率")]
        public string A22 { get; set; }
        /// <summary>
        /// 12.融资担保代偿损失率		
        /// </summary>
        [Display(Name = "12.融资担保代偿损失率")]
        public string A23 { get; set; }
        /// <summary>
        /// 标记		
        /// </summary>
        [Display(Name = "标记")]
        public string Mark { get; set; }

        /// <summary>
        /// 年份		
        /// </summary>
        [Display(Name = "年份",Order = 1)]
        public string Year { get; set; }
        /// <summary>
        /// 季度		
        /// </summary>
        [Display(Name = "季度",Order = 2)]
        public string Quarter { get; set; }
        /// <summary>
        /// 状态		
        /// </summary>
        [Display(Name = "状态")]
        public int Status { get; set; }


        #endregion

    }





}
