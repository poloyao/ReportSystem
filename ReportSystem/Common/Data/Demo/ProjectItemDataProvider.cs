using ReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Common.Data.Demo
{


    public class ProjectItemDataProvider : DataProviderBase<ProjectItemModel>
    {

        protected override IList<ProjectItemModel> FillProjectItems(object filter)
        {
            return new List<ProjectItemModel>()
            {
                ProjectItemModel.Create(x => { x.ID = Guid.NewGuid();x.Amount = 100000m; })
            };
        }

        protected override IList<ProjectItemModel> FillProjectItems(object id, object filter)
        {
            return new List<ProjectItemModel>()
            {
                ProjectItemModel.Create(x => { x.ID = Guid.NewGuid();x.Amount = 100000m; })
            };
        }

        protected override ProjectItemModel GetItem(object id)
        {
            return ProjectItemModel.Create(x => { x.ID = Guid.NewGuid();x.Amount = 100000m; });
        }
    }
}
