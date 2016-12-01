using ReportSystem.Common.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Common.ViewModel
{
    public abstract class ViewModelBase<T> where T: class 
    {
        protected IDataProvider DataProvider { get; private set; }

        protected ViewModelBase()
        {
            DataProvider = Core.GetIDataProvider();
        }


        #region 刷新

        public event EventHandler<IsLoadingEventArgs> IsLoadingChanged;
        protected void BeginUpdate()
        {
            IsLoadingChanged?.Invoke(this, new IsLoadingEventArgs() { IsLoading = true });
        }
        protected void EndUpdate()
        {
            IsLoadingChanged?.Invoke(this, new IsLoadingEventArgs() { IsLoading = false });
        }

        #endregion
        
    }

    public class IsLoadingEventArgs : EventArgs
    {
        public bool IsLoading { get; set; }
    }

    public class ssss : ISingleDataProvider
    {
        public bool AddItem<TModel, TModelID>(TModel item, object id)
        {
            throw new NotImplementedException();
        }

        public TModel GetItem<TModel, TModelID>(object id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateItem<TModel, TModelID>(TModel item, object id)
        {
            throw new NotImplementedException();
        }
    }
}
