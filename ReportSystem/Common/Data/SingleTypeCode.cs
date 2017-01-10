using ReportSystem.CommonSer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Common.Data
{
    public class SingleTypeCode
    {
        private static readonly SingleTypeCode instance = new SingleTypeCode();

        public static SingleTypeCode GetInstance()
        {
            return instance;
        }

        private SingleTypeCode()
        {
            //using (var client = ne
            CommonList = CommonCodeData.DataSource;
        }

        CommonCodeDataObjectList _CommonList;

        /// <summary>
        /// 类型列表
        /// </summary>
        public CommonCodeDataObjectList CommonList
        {
            get
            {
                return _CommonList;
            }

            private set
            {
                _CommonList = value;
            }
        }

        /// <summary>
        /// 根据参数获取特定列表 多用于下拉
        /// </summary>
        /// <param name="csd"></param>
        /// <returns></returns>
        public List<CommonCodeDataObject> GetList(CommonStatusDataObject csd)
        {
            return CommonList.Where(t => t.Category == csd).ToList();
        }

        public List<CommonCodeDataObject> GetList(string csd)
        {
            return CommonList.Where(t => t.Category.ToString() == csd).ToList();
        }

        /// <summary>
        /// 获取指定类型
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public CommonCodeDataObject GetCommonCode(string ID)
        {
            return CommonList.Single(t => t.ID.ToUpper() == ID.ToUpper());
        }
    }

    public class CommonCodeData : CommonCodeDataObjectList
    {
        static CommonCodeDataObjectList dataSource = null;

        public static CommonCodeDataObjectList DataSource
        {
            get
            {
                if (dataSource != null)
                    return dataSource;

                return Newtonsoft.Json.JsonConvert.DeserializeObject<CommonCodeDataObjectList>(JSONSTRING);

            }

        }


        static string JSONSTRING = @"[
{'ID':'CDA8FEBF-4C42-4EB4-9810-49DA94394251','Category':'0','Name':'身份证','Value':'0','Description':'证件类型','Order':'0'},
{'ID':'CE990D2B-D4F6-4589-B9B3-5A0CF325F300','Category':'0','Name':'户口簿','Value':'1','Description':'证件类型','Order':'0'},
{'ID':'6F2C8BBF-7974-4899-A581-756E27A43270','Category':'0','Name':'护照','Value':'2','Description':'证件类型','Order':'0'},
{'ID':'64F40AF3-D38A-44D3-9320-41ABABE10B57','Category':'0','Name':'军官证','Value':'3','Description':'证件类型','Order':'0'},
{'ID':'6C760B3F-04D4-4AEB-9EE1-500A0109FA6D','Category':'0','Name':'士兵证','Value':'4','Description':'证件类型','Order':'0'},
{'ID':'320375A8-9468-48F7-A9C4-DECC6F009C33','Category':'0','Name':'港澳居民来往内地通行证','Value':'5','Description':'证件类型','Order':'0'},
{'ID':'64BD658A-AFFA-48A9-8A7F-63902C502A99','Category':'0','Name':'台湾同胞来往内地通行证','Value':'6','Description':'证件类型','Order':'0'},
{'ID':'6D548349-116A-49FC-ADED-DCBBC209CC61','Category':'0','Name':'临时身份证','Value':'7','Description':'证件类型','Order':'0'},
{'ID':'1E3B1458-C8DE-418E-A75F-03D99FDC63DB','Category':'0','Name':'外国人居留证','Value':'8','Description':'证件类型','Order':'0'},
{'ID':'ACCF59B3-A06F-4277-897C-FE0BF1488A4F','Category':'0','Name':'警官证','Value':'9','Description':'证件类型','Order':'0'},
{'ID':'F819BDFD-7E84-471A-9D19-E7B66AACBBE1','Category':'0','Name':'组织机构代码证','Value':'a','Description':'证件类型','Order':'0'},
{'ID':'4132751A-7F62-432F-9883-5BB7E6EB160F','Category':'0','Name':'贷款卡','Value':'c','Description':'证件类型','Order':'0'},
{'ID':'2CB960EB-C928-418B-AACD-B7A770EC1C63','Category':'0','Name':'机构信用代码','Value':'d','Description':'证件类型','Order':'0'},
{'ID':'57D25BEB-1CB5-4E1C-B20C-DE5A7ACA2D81','Category':'0','Name':'其他证件','Value':'X','Description':'证件类型','Order':'0'},
{'ID':'D7A7F700-3D4D-444B-B18C-CCD3E3917942','Category':'0','Name':'金融机构代码','Value':'z','Description':'证件类型','Order':'0'},
{'ID':'376AC91E-D3B6-414B-A76D-9FF879438869','Category':'1','Name':'担保费','Value':'1','Description':'缴费类别','Order':'0'},
{'ID':'B0CB9AF3-949A-44E1-AAEF-97AC732A324F','Category':'1','Name':'保险保费','Value':'2','Description':'缴费类别','Order':'0'},
{'ID':'8FBB33BB-0F57-4BFC-97B1-18228C801307','Category':'2','Name':'正常','Value':'1','Description':'保费缴纳状态','Order':'0'},
{'ID':'E454B484-2120-4B2E-8EB4-1C0A4CE66DE2','Category':'2','Name':'欠缴','Value':'2','Description':'保费缴纳状态','Order':'0'},
{'ID':'F6407021-A235-4277-A028-AF701978B759','Category':'2','Name':'缴清','Value':'3','Description':'保费缴纳状态','Order':'0'},
{'ID':'7154625F-5FCC-456A-A9E3-2FC61C75153E','Category':'3','Name':'一次性（趸交）','Value':'1','Description':'保费缴纳方式','Order':'0'},
{'ID':'484DACC6-92D2-48D2-A4D1-ED819152122F','Category':'3','Name':'分期（期交）','Value':'2','Description':'保费缴纳方式','Order':'0'},
{'ID':'2E5DBB8C-E86F-4E57-9FDA-012DDF10E1AE','Category':'4','Name':'日','Value':'1','Description':'保费缴纳频率','Order':'0'},
{'ID':'644651C8-46B5-4078-8F4D-DAB600374FD4','Category':'4','Name':'周','Value':'2','Description':'保费缴纳频率','Order':'0'},
{'ID':'A1D9CF68-8120-4C64-B8A9-E70EF0A2873C','Category':'4','Name':'月','Value':'3','Description':'保费缴纳频率','Order':'0'},
{'ID':'D7D1064B-1AD5-4CBD-AF21-762271567D30','Category':'4','Name':'季','Value':'4','Description':'保费缴纳频率','Order':'0'},
{'ID':'D7C72574-2198-4F2F-BFDB-946519BAD1FC','Category':'4','Name':'半年','Value':'5','Description':'保费缴纳频率','Order':'0'},
{'ID':'CE1345C4-FABE-455C-9929-E72EB47ABF04','Category':'4','Name':'年','Value':'6','Description':'保费缴纳频率','Order':'0'},
{'ID':'D1533AF9-2ACB-4B2C-AA48-29D62F67C2BE','Category':'4','Name':'介于周和月之间','Value':'23','Description':'保费缴纳频率','Order':'0'},
{'ID':'64BB8602-4A48-45F0-A8FD-7A172DC9CB55','Category':'4','Name':'介于月和季之间','Value':'34','Description':'保费缴纳频率','Order':'0'},
{'ID':'416D2B42-CDAB-4EE9-A327-64CFA50CE665','Category':'4','Name':'其他','Value':'99','Description':'保费缴纳频率','Order':'0'},
{'ID':'D37D0909-09CE-43ED-B9A2-FD41AC614910','Category':'5','Name':'贷款担保','Value':'1','Description':'担保业务种类','Order':'0'},
{'ID':'2173640C-F6C8-44C2-9E2E-5CCCDC7D44E8','Category':'5','Name':'票据承兑担保','Value':'2','Description':'担保业务种类','Order':'0'},
{'ID':'7C335521-5173-451D-B47D-FAA5C4DE5047','Category':'5','Name':'贸易融资担保','Value':'3','Description':'担保业务种类','Order':'0'},
{'ID':'8F824523-AEEF-451E-9048-A3746DD90816','Category':'5','Name':'项目融资担保','Value':'4','Description':'担保业务种类','Order':'0'},
{'ID':'E5E944F4-F95C-41A0-8337-ABAA656172AE','Category':'5','Name':'信用证担保','Value':'5','Description':'担保业务种类','Order':'0'},
{'ID':'58A2CFCF-76E9-427A-9509-B75B027A63FB','Category':'5','Name':'其他融资性担保','Value':'6','Description':'担保业务种类','Order':'0'},
{'ID':'BF9ED9A9-6B5E-4FA1-95F8-A0B733942C3C','Category':'5','Name':'诉讼保全担保','Value':'7','Description':'担保业务种类','Order':'0'},
{'ID':'651E21C6-6D5F-4935-9A3D-1C64BE0D1504','Category':'5','Name':'履约担保','Value':'8','Description':'担保业务种类','Order':'0'},
{'ID':'300779EB-C57E-4A76-BDF9-F6C805C23BF4','Category':'5','Name':'其他非融资性担保','Value':'9','Description':'担保业务种类','Order':'0'},
{'ID':'F9C22554-4A2B-4272-9CEF-BB6E2A7DDA15','Category':'5','Name':'债券发行担保','Value':'10','Description':'担保业务种类','Order':'0'},
{'ID':'75B3BB27-DABC-4B39-A6BE-B8CF770A6FE7','Category':'5','Name':'再担保','Value':'11','Description':'担保业务种类','Order':'0'},
{'ID':'E563938C-45BB-4543-94C7-3529B3DEE65C','Category':'6','Name':'保证','Value':'1','Description':'担保方式','Order':'0'},
{'ID':'8F7DC3CD-5BC2-4E70-8EFC-643F075FD4FC','Category':'6','Name':'抵押','Value':'2','Description':'担保方式','Order':'0'},
{'ID':'51B23C91-352E-4370-81D6-AFCF4C48DB23','Category':'6','Name':'质押','Value':'3','Description':'担保方式','Order':'0'},
{'ID':'11BB1768-4417-4A73-83A5-AE7A1A4A9D0B','Category':'6','Name':'多种形式组合担保','Value':'4','Description':'担保方式','Order':'0'},
{'ID':'07A90E59-4B1B-4A97-9046-A8DE6F93519A','Category':'7','Name':'有效','Value':'1','Description':'状态位','Order':'0'},
{'ID':'0AD9FA86-10D8-413F-8E90-1EBB36EDCE7F','Category':'7','Name':'无效','Value':'2','Description':'状态位','Order':'0'},
{'ID':'89688C0F-18EE-438B-87A3-278ECFC81150','Category':'8','Name':'放贷机构','Value':'1','Description':'债权人类型','Order':'0'},
{'ID':'56D11973-BE9A-41C1-877F-4C4CFE20BB43','Category':'8','Name':'非放贷机构','Value':'2','Description':'债权人类型','Order':'0'},
{'ID':'AD8CEE1E-7DB8-45EA-AD96-077271E13F9A','Category':'8','Name':'自然人','Value':'3','Description':'债权人类型','Order':'0'},
{'ID':'209EFAF8-3D3A-4B4A-86C7-206280BAAAA0','Category':'9','Name':'企业或其他组织','Value':'1','Description':'被担保人类型','Order':'0'},
{'ID':'25BAF40C-49BE-43D9-88CC-742791007D69','Category':'9','Name':'自然人','Value':'2','Description':'被担保人类型','Order':'0'},
{'ID':'F1A5D751-E837-4281-8788-14236B5402AF','Category':'10','Name':'企业或其他组织','Value':'1','Description':'反担保人类型','Order':'0'},
{'ID':'AD18E7BC-9D74-4AD4-AC03-ABD30E18F669','Category':'10','Name':'自然人','Value':'2','Description':'反担保人类型','Order':'0'},
{'ID':'59B72F05-1165-4988-8316-0FC7618E6031','Category':'11','Name':'自然人信用担保','Value':'0','Description':'反担保方式','Order':'0'},
{'ID':'0AA2DB87-F76B-4723-803C-EC848F8805C0','Category':'11','Name':'第三方企业信用担保','Value':'1','Description':'反担保方式','Order':'0'},
{'ID':'81B03CB9-AEA3-4154-AD17-C954EB62CCF1','Category':'11','Name':'动产质押担保','Value':'2','Description':'反担保方式','Order':'0'},
{'ID':'1F05E289-95D8-4BA1-949C-17A8DFD6D8DA','Category':'11','Name':'存单质押担保','Value':'3','Description':'反担保方式','Order':'0'},
{'ID':'0FBF08F3-7E2E-419E-B478-5A3DF6C66DC9','Category':'11','Name':'知识产权质押担保','Value':'4','Description':'反担保方式','Order':'0'},
{'ID':'E6AA3CB3-A3D9-4923-8C35-B68B4498150D','Category':'11','Name':'应收账款质押担保','Value':'5','Description':'反担保方式','Order':'0'},
{'ID':'914B8F81-F855-436A-A4C1-E2384077E686','Category':'11','Name':'其他质押担保','Value':'6','Description':'反担保方式','Order':'0'},
{'ID':'941D83FF-A259-4BE5-9FFD-5762A6244334','Category':'11','Name':'房地产抵押担保','Value':'7','Description':'反担保方式','Order':'0'},
{'ID':'86A7E243-B223-4403-8A4C-BCE4BB9A171A','Category':'11','Name':'其他抵押担保','Value':'8','Description':'反担保方式','Order':'0'},
{'ID':'E36456B9-55BB-44C9-9055-397304445D2A','Category':'11','Name':'多种形式组合担保','Value':'9','Description':'反担保方式','Order':'0'},
{'ID':'0E21997A-5F39-4872-BFEA-DE44C4AE4722','Category':'11','Name':'无反担保方式。','Value':'X','Description':'反担保方式','Order':'0'},
{'ID':'774399B5-5D49-44CE-9E5A-2C84C606853B','Category':'12','Name':'有效','Value':'1','Description':'担保合同状态','Order':'0'},
{'ID':'778A2EA2-ED5A-4600-8D03-AAB62F90DD53','Category':'12','Name':'无效','Value':'2','Description':'担保合同状态','Order':'0'},
{'ID':'536C1FC6-FD86-4864-BEAB-E465E113FCA9','Category':'13','Name':'是','Value':'1','Description':'继续追偿标志','Order':'0'},
{'ID':'BF4484A5-085D-4E6F-93B0-F640FC676D84','Category':'13','Name':'否','Value':'2','Description':'继续追偿标志','Order':'0'},
{'ID':'39304565-A14E-40EA-8ED3-055EF16D9829','Category':'14','Name':'正常','Value':'0','Description':'本期保费缴纳状态','Order':'0'},
{'ID':'127DBB19-F941-4448-BD3E-2A9953813151','Category':'14','Name':'欠缴','Value':'1','Description':'本期保费缴纳状态','Order':'0'},
{'ID':'07FDA00D-2CFE-44F8-A327-32527EB0D686','Category':'14','Name':'欠缴2期及以上','Value':'2','Description':'本期保费缴纳状态','Order':'0'},
{'ID':'86A50036-7B3F-40C7-A152-45D2599F3D51','Category':'14','Name':'缴清','Value':'99','Description':'本期保费缴纳状态','Order':'0'},

{'ID':'39FD38A6-0319-4819-8029-5B8A14F52B08','Category':'15','Name':'部分解除','Value':'1','Description':'解除状态','Order':'0'},
{'ID':'BA0F0E69-8393-4D69-845A-DAFBCFA80420','Category':'15','Name':'全部解除','Value':'2','Description':'解除状态','Order':'0'},
{'ID':'E9BE1A30-688C-40FD-A68C-8F6D911A0897','Category':'15','Name':'代偿解除','Value':'3','Description':'解除状态','Order':'0'},


]";

        //{'ID':'8FBB33BB-0F57-4BFC-97B1-18228C801307','Category':'2','Name':'正常','Value':'1','Description':'保费缴纳状态','Order':'0'},

    }


}
