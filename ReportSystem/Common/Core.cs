using ReportSystem.Common.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Common
{
    public static class Core
    {

        public static IDataProvider GetDataProvider<TModel>() where TModel : class
        {
            return null;
        }


        //protected static bool IsDerivedFrom<TBase, Tancestor>()
        //{
        //    Type baseType = typeof(TBase);
        //    Type ancestorType = typeof(Tancestor);
        //    return baseType.Equals(ancestorType) || baseType.IsAssignableFrom(ancestorType);
        //}


    }
}
