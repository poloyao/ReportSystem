using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Common.Data
{


    public abstract class ProjectItemDataProvider : IDataProvider
    {
        public bool AddItem<TModel, TModelID>(TModel item, object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TModel> GetCollection<TModel>(object filter = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TModel> GetCollection<TModel>(object id, object filter = null)
        {
            throw new NotImplementedException();
        }

        public TModel GetItem<TModel>(object id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateItem<TModel, TModelID>(TModel item, object id)
        {
            throw new NotImplementedException();
        }
    }

    public class Projecssss : ProjectItemDataProvider
    {
       
    }
}
