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

        //IEnumerable<TModel> FilterItems<TModel, TModelID>(object id, object filter);
        TModel GetItem(object id);

        bool UpdateItem<TModelID>(TModel item, object id);

        bool AddItem<TModelID>(TModel item, object id);
    }

    public abstract class DataProviderBase<TModel> : IDataProvider<TModel> where TModel : class
    {

        IList<TModel> projectItems;
        IEnumerable<TModel> GetProjectItems(object filter) { return projectItems ?? (projectItems = FillProjectItems(filter)); }

        protected abstract IList<TModel> FillProjectItems(object filter);

        IEnumerable<TModel> GetProjectItems(object id, object filter) { return projectItems ?? (projectItems = FillProjectItems(id, filter)); }

        protected abstract IList<TModel> FillProjectItems(object id, object filter);

        protected abstract TModel GetItem(object id);


        #region IDataProvider



        public IEnumerable<TModel> GetCollection(object filter = null)
        {
            return GetProjectItems(filter).Cast<TModel>();
        }

        public IEnumerable<TModel> GetCollection(object id, object filter = null)
        {
            return GetProjectItems(id, filter).Cast<TModel>();
        }

        TModel IDataProvider<TModel>.GetItem(object id)
        {
            return GetItem(id);
        }

        public bool UpdateItem<TModelID>(TModel item, object id)
        {
            throw new NotImplementedException();
        }

        public bool AddItem<TModelID>(TModel item, object id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }



}
