using NLog;
using ReportSystem.Common.Data;
using ReportSystem.Common.Data.Demo;
using ReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Common
{
    public static class Core
    {
        /// <summary>
        /// NLog日志
        /// </summary>
        public static Logger LOGGER = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// DataProvider分离
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <returns></returns>
        public static IDataProvider<TModel> GetDataProvider<TModel>() where TModel : class
        {
            if (IsDerivedFrom<TModel, ProjectItemModel>())
                return (IDataProvider<TModel>)(new ProjectItemDataProvider());

            //合同
            if (IsDerivedFrom<TModel, ContractItemModel>())
                return (IDataProvider<TModel>)(new ContractItemDataProvider());
            if (IsDerivedFrom<TModel, WarranteeItemModel>())
                return (IDataProvider<TModel>)(new WarranteeItemDataProvider());

            //放款
            if (IsDerivedFrom<TModel, LoanItemModel>())
                return (IDataProvider<TModel>)new LoanItemDataProvider();
            if (IsDerivedFrom<TModel, LoanSingleItemlModel>())
                return (IDataProvider<TModel>)new LoanSingleItemlDataProvider();
            if (IsDerivedFrom<TModel, LoanCreditorItemModel>())
                return (IDataProvider<TModel>)new LoanCreditorItemDataProvider();

            //保费
            if (IsDerivedFrom<TModel, PremiumCollectionItemModel>())
                return (IDataProvider<TModel>)new PremiumCollectionItemDataProvider();
            if (IsDerivedFrom<TModel, PremiumDisplayItemModel>())
                return (IDataProvider<TModel>)new PremiumDisplayItemDataProvider();
            if (IsDerivedFrom<TModel, CompanyDisplayModel>())
                return (IDataProvider<TModel>)new CompanyDisplayDataProvider();

            //不良
            if (IsDerivedFrom<TModel, SupervisionModel>())
                return (IDataProvider<TModel>)new SupervisionDataProvider();
            if (IsDerivedFrom<TModel, SupervisionDetailModel>())
                return (IDataProvider<TModel>)new SupervisionDetailDataProvider();

            //机构信息
            if (IsDerivedFrom<TModel, CompanyManagersModel>())
                return (IDataProvider<TModel>)new CompanyManagersDataprovider();
            if (IsDerivedFrom<TModel, CompanyStockholderModel>())
                return (IDataProvider<TModel>)new CompanyStockholderDataprovider();
            if (IsDerivedFrom<TModel, CompanyBranchModel>())
                return (IDataProvider<TModel>)new CompanyBranchDataprovider();
            if (IsDerivedFrom<TModel, CompanyAccountModel>())
                return (IDataProvider<TModel>)new CompanyAccountDataprovider();

            //报表
            if (IsDerivedFrom<TModel, ReportMonthModel>())
                return (IDataProvider<TModel>)new ReportMonthDataProvider();
            if (IsDerivedFrom<TModel, ReportQuarterModel>())
                return (IDataProvider<TModel>)new ReportQuarterDataProvider();
            if (IsDerivedFrom<TModel, ReportHalfYearModel>())
                return (IDataProvider<TModel>)new ReportHalfYearDataProvider();
            if (IsDerivedFrom<TModel, ReportYearModel>())
                return (IDataProvider<TModel>)new ReportYearDataProvider();

            return null;
        }


        public static bool IsDerivedFrom<TBase, Tancestor>()
        {
            Type baseType = typeof(TBase);
            Type ancestorType = typeof(Tancestor);
            return baseType.Equals(ancestorType) || baseType.IsAssignableFrom(ancestorType);
        }


    }
}
