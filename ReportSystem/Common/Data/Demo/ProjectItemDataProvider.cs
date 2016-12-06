using ReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Common.Data.Demo
{


    public class ProjectItemDataProvider : DataProviderBase<ProjectItemModel>
    {
        protected override ProjectItemModel AddItem(ProjectItemModel item)
        {
            throw new NotImplementedException();
        }

        protected override IList<ProjectItemModel> FillItems(object filter)
        {
            return new List<ProjectItemModel>()
            {
                ProjectItemModel.Create(x => { x.ID = Guid.NewGuid();x.Amount = 100000m; })
            };
        }

        protected override IList<ProjectItemModel> FillItems(object id, object filter)
        {
            return new List<ProjectItemModel>()
            {
                ProjectItemModel.Create(x => { x.ID = Guid.NewGuid();x.Amount = 100000m; })
            };
        }

        protected override ProjectItemModel GetItem(object id)
        {
            return ProjectItemModel.Create(x => { x.ID = Guid.NewGuid(); x.Amount = 100000m; });
        }

        protected override ProjectItemModel UpdateItem(ProjectItemModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }

    public class ContractItemDataProvider : DataProviderBase<ContractItemModel>
    {
        protected override ContractItemModel AddItem(ContractItemModel item)
        {
            throw new NotImplementedException();
        }

        protected override IList<ContractItemModel> FillItems(object filter)
        {
            return new List<ContractItemModel>()
            {
                GetItem(null)
            };
        }

        protected override IList<ContractItemModel> FillItems(object id, object filter)
        {
            return new List<ContractItemModel>()
            {
                //ContractItemModel.Create(x=> { x.ID = Guid.NewGuid();x.Amount =100003m; })
                GetItem(null)
            };
        }

        protected override ContractItemModel GetItem(object id)
        {
            int number = 1;
            return ContractItemModel.Create(x =>
            {
                x.ID = Guid.NewGuid();
                x.ProjectNo = "XM" + number.ToString("000");
                x.ContractrNo = "HT" + number.ToString("000");
                x.BusinessType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.BusinessType)).ID);
                x.GuaranteeType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.GuaranteeType)).ID);
                x.Amount = new Random().Next(100) * 100000;
                x.StartDate = DemoHelper.GetRandomTime();
                x.EndDate = DemoHelper.GetRandomTime(x.StartDate);
                x.DepositRatio = 0.3m;
                x.ReRatio = 0;
                x.CounterGuarantee = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.CGType)).ID);
                x.Rates = 0.3m;
                x.YearRates = 0.3m;
                x.WarranteeItems = new List<WarranteeItemModel>()
                  {
                      WarranteeItemModel.Create(x1=> {
                          x1.ID = Guid.NewGuid();
                        x1.WarranteeType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.WarranteeType)).ID);
                        x1.Name = DemoHelper.GetRandomChineseWords(new Random().Next(2, 5)) + "有限公司";
                        x1.CardType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.CodeType)).ID);
                        x1.CardID = DemoHelper.GetRandomCardID(18, true);
                        x1.IsMain = true;
                      })
                  };
            });
        }

        protected override ContractItemModel UpdateItem(ContractItemModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }


    public class WarranteeItemDataProvider : DataProviderBase<WarranteeItemModel>
    {
        protected override WarranteeItemModel AddItem(WarranteeItemModel item)
        {
            item.ID = Guid.NewGuid();
            return item;
        }

        protected override IList<WarranteeItemModel> FillItems(object filter)
        {
            throw new NotImplementedException();
        }

        protected override IList<WarranteeItemModel> FillItems(object id, object filter)
        {
            throw new NotImplementedException();
        }

        protected override WarranteeItemModel GetItem(object id)
        {
            return WarranteeItemModel.Create(x =>
            {
                x.ID = (Guid)id;
                x.WarranteeType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.WarranteeType)).ID);
                x.Name = DemoHelper.GetRandomChineseWords(new Random().Next(2, 5)) + "有限公司";
                x.CardType = Guid.Parse(DemoHelper.GetRandomItem(SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.CodeType)).ID);
                x.CardID = DemoHelper.GetRandomCardID(18, true);
                x.IsMain = true;
            });
        }

        protected override WarranteeItemModel UpdateItem(WarranteeItemModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }


    public class LoanItemDataProvider : DataProviderBase<LoanItemModel>
    {
        protected override LoanItemModel AddItem(LoanItemModel item)
        {
            throw new NotImplementedException();
        }

        protected override IList<LoanItemModel> FillItems(object filter)
        {
            throw new NotImplementedException();
        }

        protected override IList<LoanItemModel> FillItems(object id, object filter)
        {
            throw new NotImplementedException();
        }

        protected override LoanItemModel GetItem(object id)
        {
            throw new NotImplementedException();
        }

        protected override LoanItemModel UpdateItem(LoanItemModel item, bool IsDelete)
        {
            throw new NotImplementedException();
        }
    }


    public static class DemoHelper
    {
        #region 帮助类


        public static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }



        /// <summary>
        /// List数组获取随机值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static T GetRandomItem<T>(IList<T> list)
        {
            if (list == null) throw new ArgumentNullException("list");
            int count = list.Count;
            if (count == 0) return default(T);
            System.Threading.Thread.Sleep(100);
            int index = new Random(GetRandomSeed()).Next(count);
            return list[index];
        }

        /// <summary>
        /// 得到随机日期
        /// </summary>
        /// <param name="date1">起始日期 默认值 new DateTime(2013, 1, 1)</param>
        /// <param name="date2">结束日期 默认值 DateTime.Now 或 起始有值延后3年</param>
        /// <returns>间隔日期之间的 随机日期</returns>
        public static DateTime GetRandomTime(DateTime? date1 = null, DateTime? date2 = null)
        {
            DateTime time1 = date1 ?? new DateTime(2013, 1, 1);
            DateTime time2 = date2 ?? (date1 == null ? DateTime.Now : time1.AddYears(3));

            Random random = new Random(Guid.NewGuid().GetHashCode());
            DateTime minTime = new DateTime();
            DateTime maxTime = new DateTime();

            System.TimeSpan ts = new System.TimeSpan(time1.Ticks - time2.Ticks);

            double dTotalSecontds = ts.TotalSeconds;
            int iTotalSecontds = 0;

            if (dTotalSecontds > System.Int32.MaxValue)
            {
                iTotalSecontds = System.Int32.MaxValue;
            }
            else if (dTotalSecontds < System.Int32.MinValue)
            {
                iTotalSecontds = System.Int32.MinValue;
            }
            else
            {
                iTotalSecontds = (int)dTotalSecontds;
            }


            if (iTotalSecontds > 0)
            {
                minTime = time2;
                maxTime = time1;
            }
            else if (iTotalSecontds < 0)
            {
                minTime = time1;
                maxTime = time2;
            }
            else
            {
                return time1;
            }

            int maxValue = iTotalSecontds;

            if (iTotalSecontds <= System.Int32.MinValue)
                maxValue = System.Int32.MinValue + 1;

            int i = random.Next(System.Math.Abs(maxValue));

            return minTime.AddSeconds(i);
        }



        /// <summary>  
        /// 随机产生常用汉字  
        /// </summary>  
        /// <param name="count">要产生汉字的个数</param>  
        /// <returns>常用汉字</returns>  
        public static string GetRandomChineseWords(int count)
        {
            string chineseWords = "";
            Random rm = new Random();
            Encoding gb = Encoding.GetEncoding("gb2312");

            for (int i = 0; i < count; i++)
            {
                // 获取区码(常用汉字的区码范围为16-55)  
                int regionCode = rm.Next(16, 56);
                // 获取位码(位码范围为1-94 由于55区的90,91,92,93,94为空,故将其排除)  
                int positionCode;
                if (regionCode == 55)
                {
                    // 55区排除90,91,92,93,94  
                    positionCode = rm.Next(1, 90);
                }
                else
                {
                    positionCode = rm.Next(1, 95);
                }

                // 转换区位码为机内码  
                int regionCode_Machine = regionCode + 160;// 160即为十六进制的20H+80H=A0H  
                int positionCode_Machine = positionCode + 160;// 160即为十六进制的20H+80H=A0H  

                // 转换为汉字  
                byte[] bytes = new byte[] { (byte)regionCode_Machine, (byte)positionCode_Machine };

                chineseWords += gb.GetString(bytes);
            }

            return chineseWords;
        }



        /// <summary>
        /// 随机生成证件号
        /// </summary>
        /// <param name="length">总长度</param>
        /// <param name="isLetter">是否在尾部后缀英文</param>
        /// <returns></returns>
        public static string GetRandomCardID(int length, bool isLetter)
        {
            length = isLetter ? length - 1 : length;
            string tmpstr = "";
            string idChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int randNum;
            Random ran = new Random();
            for (int i = 0; i < length; i++)
            {
                randNum = ran.Next(0, 9);
                tmpstr += randNum;
            }
            if (isLetter)
            {
                randNum = ran.Next(idChars.Length);
                tmpstr += idChars[randNum];
            }
            return tmpstr;
        }

        public static IList<T> GetRandomObjectList<T>(Action<T> Create, int count = 1)
        {

            return null;
        }

        #endregion
    }
}
