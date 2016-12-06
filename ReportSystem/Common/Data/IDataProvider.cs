using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Common.Data
{
    public interface IDataProvider<TModel>
    {
        IEnumerable<TModel> GetCollection(object filter = null);
        IEnumerable<TModel> GetCollection(object id, object filter = null);

        TModel GetItem(object id);

        TModel UpdateItem(TModel item, bool IsDelete = false);

        TModel AddItem(TModel item);
    }

    public abstract class DataProviderBase<TModel> : IDataProvider<TModel> where TModel : class
    {

        IList<TModel> projectItems;
        IEnumerable<TModel> GeItems(object filter) { return projectItems ?? (projectItems = FillItems(filter)); }

        protected abstract IList<TModel> FillItems(object filter);

        IEnumerable<TModel> GetItems(object id, object filter) { return projectItems ?? (projectItems = FillItems(id, filter)); }

        protected abstract IList<TModel> FillItems(object id, object filter);

        protected abstract TModel GetItem(object id);

        protected abstract TModel AddItem(TModel item);

        protected abstract TModel UpdateItem(TModel item, bool IsDelete);


        #region IDataProvider       

        IEnumerable<TModel> IDataProvider<TModel>.GetCollection(object filter)
        {
            return GeItems(filter).Cast<TModel>();
        }

        IEnumerable<TModel> IDataProvider<TModel>.GetCollection(object id, object filter)
        {
            return GetItems(id, filter).Cast<TModel>();
        }

        TModel IDataProvider<TModel>.GetItem(object id)
        {
            return GetItem(id);
        }

        TModel IDataProvider<TModel>.UpdateItem(TModel item, bool IsDelete)
        {
            return UpdateItem(item, IsDelete);
        }

        TModel IDataProvider<TModel>.AddItem(TModel item)
        {
            return AddItem(item);
        }
        #endregion

    }



}
