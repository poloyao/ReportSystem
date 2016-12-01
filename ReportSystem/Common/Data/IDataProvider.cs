using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Common.Data
{
    public interface IDataProvider
    {
        IEnumerable<TModel> GetCollection<TModel>(object filter = null);
        IEnumerable<TModel> GetCollection<TModel>(object id,object filter = null);

        //IEnumerable<TModel> FilterItems<TModel, TModelID>(object id, object filter);
        TModel GetItem<TModel>(object id);

        bool UpdateItem<TModel, TModelID>(TModel item, object id);

        bool AddItem<TModel, TModelID>(TModel item, object id);
    }
    


}
