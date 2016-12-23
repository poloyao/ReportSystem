using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Models
{
    public class ReportYearModel
    {
        public ReportYearSheet1 Sheet1 { get; set; }
        public ReportYearSheet2 Sheet2 { get; set; }

        public ReportYearSheet3 Sheet3 { get; set; }

        public List<ReportYearSheet4> Sheet4 { get; set; }
        public List<ReportYearSheet5> Sheet5 { get; set; }

        public ReportYearSheet6 Sheet6 { get; set; }

        public ReportYearSheet7 Sheet7 { get; set; }
    }

    public class ReportYearSheet1
    {
        #region 构造方法

        public ReportYearSheet1()
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
        /// 1. 本市融资性担保机构数量		
        /// </summary>
        [Display(Name = "1. 本市融资性担保机构数量")]
        public string A01 { get; set; }
        /// <summary>
        ///  1.1 法人机构数量		
        /// </summary>
        [Display(Name = " 1.1 法人机构数量")]
        public string A02 { get; set; }
        /// <summary>
        /// 1.1.1  10亿元(含)以上		
        /// </summary>
        [Display(Name = "1.1.1  10亿元(含)以上")]
        public string A03 { get; set; }
        /// <summary>
        /// 其中：国有控股		
        /// </summary>
        [Display(Name = "其中：国有控股")]
        public string A04 { get; set; }
        /// <summary>
        /// 国资参股		
        /// </summary>
        [Display(Name = "国资参股")]
        public string A05 { get; set; }
        /// <summary>
        /// 民   营		
        /// </summary>
        [Display(Name = "民   营")]
        public string A06 { get; set; }
        /// <summary>
        /// 1.1.2  1亿元(含)-10亿元		
        /// </summary>
        [Display(Name = "1.1.2  1亿元(含)-10亿元")]
        public string A07 { get; set; }
        /// <summary>
        ///  其中：国有控股		
        /// </summary>
        [Display(Name = " 其中：国有控股")]
        public string A08 { get; set; }
        /// <summary>
        /// 国资参股		
        /// </summary>
        [Display(Name = "国资参股")]
        public string A09 { get; set; }
        /// <summary>
        /// 民   营		
        /// </summary>
        [Display(Name = "民   营")]
        public string A10 { get; set; }
        /// <summary>
        /// 1.1.3  2000万元(含)-1亿元		
        /// </summary>
        [Display(Name = "1.1.3  2000万元(含)-1亿元")]
        public string A11 { get; set; }
        /// <summary>
        /// 其中：国有控股		
        /// </summary>
        [Display(Name = "其中：国有控股")]
        public string A12 { get; set; }
        /// <summary>
        /// 国资参股		
        /// </summary>
        [Display(Name = "国资参股")]
        public string A13 { get; set; }
        /// <summary>
        /// 民   营		
        /// </summary>
        [Display(Name = "民   营")]
        public string A14 { get; set; }
        /// <summary>
        /// 已开展再担保业务的		
        /// </summary>
        [Display(Name = "已开展再担保业务的")]
        public string A15 { get; set; }
        /// <summary>
        /// 在县（市）登记机关登记的		
        /// </summary>
        [Display(Name = "在县（市）登记机关登记的")]
        public string A16 { get; set; }
        /// <summary>
        /// 中外合资或外商独资的		
        /// </summary>
        [Display(Name = "中外合资或外商独资的")]
        public string A17 { get; set; }
        /// <summary>
        /// 1.2 分支机构数量		
        /// </summary>
        [Display(Name = "1.2 分支机构数量")]
        public string A18 { get; set; }
        /// <summary>
        /// 其中：跨省（区、市）在本市设立的		
        /// </summary>
        [Display(Name = "其中：跨省（区、市）在本市设立的")]
        public string A19 { get; set; }
        /// <summary>
        /// 2. 本市融资性担保行业的从业人数		
        /// </summary>
        [Display(Name = "2. 本市融资性担保行业的从业人数")]
        public string A20 { get; set; }
        /// <summary>
        /// 2.1  研究生		
        /// </summary>
        [Display(Name = "2.1  研究生")]
        public string A21 { get; set; }
        /// <summary>
        /// 2.2  本科		
        /// </summary>
        [Display(Name = "2.2  本科")]
        public string A22 { get; set; }
        /// <summary>
        /// 2.3  大专及以下		
        /// </summary>
        [Display(Name = "2.3  大专及以下")]
        public string A23 { get; set; }
        /// <summary>
        /// 3年以上担保从业经验人数		
        /// </summary>
        [Display(Name = "3年以上担保从业经验人数")]
        public string A24 { get; set; }
        /// <summary>
        /// 机关、事业单位编制人数		
        /// </summary>
        [Display(Name = "机关、事业单位编制人数")]
        public string A25 { get; set; }
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
        /// 状态		
        /// </summary>
        [Display(Name = "状态",Order = 2)]
        public int Status { get; set; }


        #endregion

    }

    public class ReportYearSheet2
    {
        #region 构造方法

        public ReportYearSheet2()
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
        /// 资产总额		
        /// </summary>
        [Display(Name = "资产总额")]
        public string A01 { get; set; }
        /// <summary>
        /// 其中：货币资金		
        /// </summary>
        [Display(Name = "其中：货币资金")]
        public string A02 { get; set; }
        /// <summary>
        /// 存出保证金		
        /// </summary>
        [Display(Name = "存出保证金")]
        public string A03 { get; set; }
        /// <summary>
        /// 债权投资		
        /// </summary>
        [Display(Name = "债权投资")]
        public string A04 { get; set; }
        /// <summary>
        /// 合计		
        /// </summary>
        [Display(Name = "合计")]
        public string A05 { get; set; }
        /// <summary>
        /// 其中：长期股权投资（1年以上，不含1年）		
        /// </summary>
        [Display(Name = "其中：长期股权投资（1年以上，不含1年）")]
        public string A06 { get; set; }
        /// <summary>
        /// 委托贷款		
        /// </summary>
        [Display(Name = "委托贷款")]
        public string A07 { get; set; }
        /// <summary>
        /// 固定资产		
        /// </summary>
        [Display(Name = "固定资产")]
        public string A08 { get; set; }
        /// <summary>
        /// 抵债资产		
        /// </summary>
        [Display(Name = "抵债资产")]
        public string A09 { get; set; }
        /// <summary>
        /// 合计		
        /// </summary>
        [Display(Name = "合计")]
        public string A10 { get; set; }
        /// <summary>
        /// 其中：期限在2年以上（含）的应收代偿款		
        /// </summary>
        [Display(Name = "其中：期限在2年以上（含）的应收代偿款")]
        public string A11 { get; set; }
        /// <summary>
        /// 其他应收款		
        /// </summary>
        [Display(Name = "其他应收款")]
        public string A12 { get; set; }
        /// <summary>
        /// 2.负债总额		
        /// </summary>
        [Display(Name = "2.负债总额")]
        public string A13 { get; set; }
        /// <summary>
        /// 其中：借款		
        /// </summary>
        [Display(Name = "其中：借款")]
        public string A14 { get; set; }
        /// <summary>
        /// 应付款项		
        /// </summary>
        [Display(Name = "应付款项")]
        public string A15 { get; set; }
        /// <summary>
        /// 存入保证金		
        /// </summary>
        [Display(Name = "存入保证金")]
        public string A16 { get; set; }
        /// <summary>
        /// 预计负债		
        /// </summary>
        [Display(Name = "预计负债")]
        public string A17 { get; set; }
        /// <summary>
        /// 未到期责任准备金		
        /// </summary>
        [Display(Name = "未到期责任准备金")]
        public string A18 { get; set; }
        /// <summary>
        /// 担保赔偿准备金		
        /// </summary>
        [Display(Name = "担保赔偿准备金")]
        public string A19 { get; set; }
        /// <summary>
        /// 3.净资产		
        /// </summary>
        [Display(Name = "3.净资产")]
        public string A20 { get; set; }
        /// <summary>
        /// 合计		
        /// </summary>
        [Display(Name = "合计")]
        public string A21 { get; set; }
        /// <summary>
        /// 其中：政府出资		
        /// </summary>
        [Display(Name = "其中：政府出资")]
        public string A22 { get; set; }
        /// <summary>
        /// 一般风险准备		
        /// </summary>
        [Display(Name = "一般风险准备")]
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
        /// 状态		
        /// </summary>
        [Display(Name = "状态",Order = 2)]
        public int Status { get; set; }


        #endregion

    }

    public class ReportYearSheet3
    {
        #region 构造方法

        public ReportYearSheet3()
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
        /// 1.担保业务收入		
        /// </summary>
        [Display(Name = "1.担保业务收入")]
        public string A01 { get; set; }
        /// <summary>
        /// 其中：融资性担保费收入		
        /// </summary>
        [Display(Name = "其中：融资性担保费收入")]
        public string A02 { get; set; }
        /// <summary>
        /// 2.担保业务成本		
        /// </summary>
        [Display(Name = "2.担保业务成本")]
        public string A03 { get; set; }
        /// <summary>
        /// 其中：融资性担保赔偿支出 		
        /// </summary>
        [Display(Name = "其中：融资性担保赔偿支出 ")]
        public string A04 { get; set; }
        /// <summary>
        /// 融资性分担保费支出		
        /// </summary>
        [Display(Name = "融资性分担保费支出")]
        public string A05 { get; set; }
        /// <summary>
        /// 营业税金及附加		
        /// </summary>
        [Display(Name = "营业税金及附加")]
        public string A06 { get; set; }
        /// <summary>
        /// 3.担保业务利润		
        /// </summary>
        [Display(Name = "3.担保业务利润")]
        public string A07 { get; set; }
        /// <summary>
        /// 4.利息净收入（净支出则前加“－”号填列）		
        /// </summary>
        [Display(Name = "4.利息净收入（净支出则前加“－”号填列）")]
        public string A08 { get; set; }
        /// <summary>
        /// 5.其他业务利润		
        /// </summary>
        [Display(Name = "5.其他业务利润")]
        public string A09 { get; set; }
        /// <summary>
        /// 6.业务及管理费		
        /// </summary>
        [Display(Name = "6.业务及管理费")]
        public string A10 { get; set; }
        /// <summary>
        /// 7.投资收益（投资损失则前加“－”号填列）		
        /// </summary>
        [Display(Name = "7.投资收益（投资损失则前加“－”号填列）")]
        public string A11 { get; set; }
        /// <summary>
        /// 其中：债权投资收益		
        /// </summary>
        [Display(Name = "其中：债权投资收益")]
        public string A12 { get; set; }
        /// <summary>
        /// 委托贷款收益		
        /// </summary>
        [Display(Name = "委托贷款收益")]
        public string A13 { get; set; }
        /// <summary>
        /// 8.营业利润		
        /// </summary>
        [Display(Name = "8.营业利润")]
        public string A14 { get; set; }
        /// <summary>
        /// 9.营业外净收入（净亏损则前加“－”号填列）		
        /// </summary>
        [Display(Name = "9.营业外净收入（净亏损则前加“－”号填列）")]
        public string A15 { get; set; }
        /// <summary>
        /// 10.资产减值损失（转回的金额则前加“－”号填列）		
        /// </summary>
        [Display(Name = "10.资产减值损失（转回的金额则前加“－”号填列）")]
        public string A16 { get; set; }
        /// <summary>
        /// 11.所得税		
        /// </summary>
        [Display(Name = "11.所得税")]
        public string A17 { get; set; }
        /// <summary>
        /// 12.净利润（净亏损则前加“－”号填列）		
        /// </summary>
        [Display(Name = "12.净利润（净亏损则前加“－”号填列）")]
        public string A18 { get; set; }
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
        /// 状态		
        /// </summary>
        [Display(Name = "状态",Order = 2)]
        public int Status { get; set; }


        #endregion

    }

    public class ReportYearSheet4
    {
        #region 构造方法

        public ReportYearSheet4()
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
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A01 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A02 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A03 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A04 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A05 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A06 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A07 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A08 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A09 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A10 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A11 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A12 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A13 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A14 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A15 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A16 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A17 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A18 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A19 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A20 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A21 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A22 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A23 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A24 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A25 { get; set; }
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
        /// 状态		
        /// </summary>
        [Display(Name = "状态",Order = 2)]
        public int Status { get; set; }


        #endregion

    }

    public class ReportYearSheet5
    {
        #region 构造方法

        public ReportYearSheet5()
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
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A01 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A02 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A03 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A04 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A05 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A06 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A07 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A08 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A09 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A10 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A11 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A12 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A13 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A14 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A15 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A16 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A17 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A18 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A19 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A20 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A21 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A22 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A23 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A24 { get; set; }
        /// <summary>
        /// 		
        /// </summary>
        [Display(Name = "")]
        public string A25 { get; set; }
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
        /// 状态		
        /// </summary>
        [Display(Name = "状态",Order = 2)]
        public int Status { get; set; }


        #endregion

    }

    public class ReportYearSheet6
    {
        #region 构造方法

        public ReportYearSheet6()
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
        /// 上一年获得扶持（奖补）资金		
        /// </summary>
        [Display(Name = "上一年获得扶持（奖补）资金")]
        public string A02 { get; set; }
        /// <summary>
        /// 来自国家部门		
        /// </summary>
        [Display(Name = "来自国家部门")]
        public string A03 { get; set; }
        /// <summary>
        /// 来自省级部门		
        /// </summary>
        [Display(Name = "来自省级部门")]
        public string A04 { get; set; }
        /// <summary>
        /// 来自地（市）部门		
        /// </summary>
        [Display(Name = "来自地（市）部门")]
        public string A05 { get; set; }
        /// <summary>
        /// 来自县（市）部门		
        /// </summary>
        [Display(Name = "来自县（市）部门")]
        public string A06 { get; set; }
        /// <summary>
        /// 上一年获得注入（股本）资金		
        /// </summary>
        [Display(Name = "上一年获得注入（股本）资金")]
        public string A07 { get; set; }
        /// <summary>
        /// 来自省级部门		
        /// </summary>
        [Display(Name = "来自省级部门")]
        public string A08 { get; set; }
        /// <summary>
        /// 来自地（市）部门		
        /// </summary>
        [Display(Name = "来自地（市）部门")]
        public string A09 { get; set; }
        /// <summary>
        /// 来自县（市）部门		
        /// </summary>
        [Display(Name = "来自县（市）部门")]
        public string A10 { get; set; }
        /// <summary>
        /// 营业税免征额		
        /// </summary>
        [Display(Name = "营业税免征额")]
        public string A11 { get; set; }
        /// <summary>
        /// 担保机构代管资金余额		
        /// </summary>
        [Display(Name = "担保机构代管资金余额")]
        public string A12 { get; set; }
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
        /// 状态		
        /// </summary>
        [Display(Name = "状态",Order = 2)]
        public int Status { get; set; }


        #endregion

    }

    public class ReportYearSheet7
    {
        #region 构造方法

        public ReportYearSheet7()
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
        /// 地区		
        /// </summary>
        [Display(Name = "地区")]
        public string A01 { get; set; }
        /// <summary>
        /// 担保机构名称		
        /// </summary>
        [Display(Name = "担保机构名称")]
        public string A02 { get; set; }
        /// <summary>
        /// 成立时间		
        /// </summary>
        [Display(Name = "成立时间")]
        public string A03 { get; set; }
        /// <summary>
        /// 注册资本		
        /// </summary>
        [Display(Name = "注册资本")]
        public string A04 { get; set; }
        /// <summary>
        /// 机构性质		
        /// </summary>
        [Display(Name = "机构性质")]
        public string A05 { get; set; }
        /// <summary>
        /// 股东名称及持股比例		
        /// </summary>
        [Display(Name = "股东名称及持股比例")]
        public string A06 { get; set; }
        /// <summary>
        /// 法定代表人		
        /// </summary>
        [Display(Name = "法定代表人")]
        public string A07 { get; set; }
        /// <summary>
        /// 总经理		
        /// </summary>
        [Display(Name = "总经理")]
        public string A08 { get; set; }
        /// <summary>
        /// 总经理固话及手机号码		
        /// </summary>
        [Display(Name = "总经理固话及手机号码")]
        public string A09 { get; set; }
        /// <summary>
        /// 上一年度净利润		
        /// </summary>
        [Display(Name = "上一年度净利润")]
        public string A10 { get; set; }
        /// <summary>
        /// 上一年度纳税		
        /// </summary>
        [Display(Name = "上一年度纳税")]
        public string A11 { get; set; }
        /// <summary>
        /// 年末在保余额		
        /// </summary>
        [Display(Name = "年末在保余额")]
        public string A12 { get; set; }
        /// <summary>
        /// 合作银行户数		
        /// </summary>
        [Display(Name = "合作银行户数")]
        public string A13 { get; set; }
        /// <summary>
        /// 两金提取总额		
        /// </summary>
        [Display(Name = "两金提取总额")]
        public string A14 { get; set; }
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
        /// 状态		
        /// </summary>
        [Display(Name = "状态",Order = 2)]
        public int Status { get; set; }


        #endregion

    }


}
