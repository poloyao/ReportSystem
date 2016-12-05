using ReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Common.Data.Demo
{
    public class DemoData
    {
        #region 属性

        List<ProjectItemModel> _ListProjectItemViewModel = new List<ProjectItemModel>();

        public List<ProjectItemModel> ListProjectItemViewModel
        {
            get
            {
                return _ListProjectItemViewModel;
            }

            set
            {
                _ListProjectItemViewModel = value;
            }
        }

        #endregion

        public static readonly DemoData instance = new DemoData();

        private DemoData()
        {

        }


    }
}
