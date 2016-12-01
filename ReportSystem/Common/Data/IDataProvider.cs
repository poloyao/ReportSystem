using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Common.Data
{
    public interface IDataProvider
    {
                
    }

    public interface ICollectionDataProvider : IDataProvider
    {

        IEnumerable<TModel> GetItems<TModel, TModelID>(object id);

        IEnumerable<TModel> FilterItems<TModel, TModelID>(object id, object filter);
    }

    public interface ISingleDataProvider : IDataProvider
    {
        TModel GetItem<TModel, TModelID>(object id);

        bool UpdateItem<TModel, TModelID>(TModel item, object id);

        bool AddItem<TModel, TModelID>(TModel item, object id);

    }
}
