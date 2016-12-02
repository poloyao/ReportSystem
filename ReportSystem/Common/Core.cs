using NLog;
using ReportSystem.Common.Data;
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

        public static IDataProvider GetDataProvider<TModel>() where TModel : class
        {
            if (IsDerivedFrom<TModel, ProjectItemModel>())
                return new ProjectItemDataProvider();
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
