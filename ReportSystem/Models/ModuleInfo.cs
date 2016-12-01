using DevExpress.Mvvm;
using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Models
{
    public class ModuleInfo
    {
        ISupportServices parent;

        public ModuleInfo(string _type, object parent, string _title)
        {
            Type = _type;
            this.parent = (ISupportServices)parent;
            Title = _title;
        }

        public string Type { get; private set; }

        public virtual bool IsSelected { get; set; }

        public string Title { get; private set; }

        public virtual Uri Icon { get; set; }

        public ModuleInfo SetIcon(string icon)
        {
            this.Icon = AssemblyHelper.GetResourceUri(typeof(ModuleInfo).Assembly, string.Format("Images/Menu/{0}.png", icon));
            return this;
        }

        public void Show(object parameter = null)
        {
            INavigationService navigationService = parent.ServiceContainer.GetRequiredService<INavigationService>();
            navigationService.Navigate(Type, parameter, parent);
        }
    }

    public class ModuleGroup
    {
        public ModuleGroup(string _title, IEnumerable<ModuleInfo> _moduleInfos)
        {
            Title = _title;
            ModuleInfos = _moduleInfos;
        }
        public string Title { get; private set; }
        public IEnumerable<ModuleInfo> ModuleInfos { get; private set; }
    }
}
