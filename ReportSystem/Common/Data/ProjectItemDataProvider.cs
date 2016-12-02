using ReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Common.Data
{


    public abstract class ProjectItemDataProviderBase : IDataProvider
    {
        public bool AddItem<TModel, TModelID>(TModel item, object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TModel> GetCollection<TModel>(object filter = null)
        {
            return GetProjectItems(filter).Cast<TModel>();            
        }

        public IEnumerable<TModel> GetCollection<TModel>(object id, object filter = null)
        {
            return GetProjectItems(id, filter).Cast<TModel>();
        }

        public TModel GetItem<TModel>(object id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateItem<TModel, TModelID>(TModel item, object id)
        {
            throw new NotImplementedException();
        }

        IList<ProjectItemModel> projectItems;
        IEnumerable<ProjectItemModel> GetProjectItems(object filter) { return projectItems ?? (projectItems = FillProjectItems(filter)); }

        protected abstract IList<ProjectItemModel> FillProjectItems(object filter);

        IEnumerable<ProjectItemModel> GetProjectItems(object id,object filter) { return projectItems ?? (projectItems = FillProjectItems(id,filter)); }

        protected abstract IList<ProjectItemModel> FillProjectItems(object id,object filter);

    }

    public class ProjectItemDataProvider : ProjectItemDataProviderBase
    {

        protected override IList<ProjectItemModel> FillProjectItems(object filter)
        {
            return new List<ProjectItemModel>()
            {
                ProjectItemModel.Create()
            };
        }

        protected override IList<ProjectItemModel> FillProjectItems(object id, object filter)
        {
            return new List<ProjectItemModel>()
            {
                ProjectItemModel.Create()
            };
        }
    }
}
