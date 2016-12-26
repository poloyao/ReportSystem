using ReportSystem.Common.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm;
using System.ComponentModel;

namespace ReportSystem.Common.ViewModel
{
    public abstract class ViewModelBase<TModel> : ViewModelBase where TModel :class
    {
        protected virtual IDataProvider<TModel> DataProvider { get; private set; }

        //protected Type ParentType = typeof(TModel);

        public ViewModelBase()
        {
            this.DataProvider = Core.GetDataProvider<TModel>();
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

    public abstract class CollectionViewModel<TModel> : ViewModelBase<TModel> where TModel : class
    {
        protected IList<TModel> Items { get; set; }
        public virtual ObservableCollection<TModel> ItemSource { get; set; }

        public virtual TModel SelectedItem { get; set; }

        object baseId = null;

        protected CollectionViewModel()
        {
            Init();
        }

        private void Init(object filter = null)
        {
            if (DataProvider == null)
            {
                Core.LOGGER.Error(string.Format(" {0} 模块的DataProvider异常", typeof(TModel)));
                return;
            }
            Items = DataProvider.GetCollection(filter).ToList();
            ItemSource = new ObservableCollection<TModel>(Items);
        }

        protected CollectionViewModel(object id)
        {
            Init(id);
        }

        private void Init(object id, object filter = null)
        {
            baseId = id;
            Items = DataProvider.GetCollection(id,filter).ToList();
            ItemSource = new ObservableCollection<TModel>(Items);
        }

        protected void Refresh()
        {
            if (baseId == null)
                Init();
            else
                Init(baseId);
        }

        protected void FilterItems(object filter)
        {
            if (baseId == null)
                Init(filter);
            else
                Init(baseId, filter);
        }
        


    }

    public abstract class SingleViewModel<TModel> : ViewModelBase<TModel> , IDocumentContent where TModel : class
    {
        protected virtual TModel ContentBase { get; private set; }
        
        protected ParentModel Parent { get; set; }

        public IDocumentOwner DocumentOwner { get; set; }

        public object Title { get; }

        object ModelID = null;        

        protected SingleViewModel()
        {
            
        }
        private void Init(object id)
        {
            //主要区分模块传进的是“Module” 不能当id使用
            ModelID = id;
            ContentBase = DataProvider.GetItem(id);
        }

        protected TModel AddItem(TModel item)
        {
            return DataProvider.AddItem(item);          
        }

        protected TModel UpdateItem(TModel item)
        {
            return DataProvider.UpdateItem(item);
        }

        protected TModel DeleteItem(TModel item)
        {
            return DataProvider.UpdateItem(item,true);
        }

        protected override void OnParameterChanged(object parameter)
        {
            base.OnParameterChanged(parameter);
            if (parameter != null)
                Init(parameter);
        }

        public void OnClose(CancelEventArgs e)
        {
            e.Cancel = false;
        }

        public void OnDestroy() { }
    }

    public abstract class ReportViewModel<TModel> : CollectionViewModel<TModel> where TModel : class
    {
        protected ReportViewModel(Models.ReportType repType):base(repType)
        {
            
        }
    }



    public class ParentModel
    {
        public Type ParentType { get; set; }
        public Object ParentID { get; set; } = null;

        public object ChildID { get; set; } = null;

    }


}
