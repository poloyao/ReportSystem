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

        public static IDataProvider<TModel> GetDataProvider<TModel>() where TModel : class
        {
            if (IsDerivedFrom<TModel, ProjectItemModel>())
                return (IDataProvider<TModel>)(new ProjectItemDataProvider());
            if (IsDerivedFrom<TModel, ContractItemModel>())
                return (IDataProvider<TModel>)(new ContractItemDataProvider());
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
