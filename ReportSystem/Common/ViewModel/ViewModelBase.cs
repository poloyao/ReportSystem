﻿using ReportSystem.Common.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem.Common.ViewModel
{
    public abstract class ViewModelBase<TModel> where TModel :class
    {
        protected virtual IDataProvider DataProvider { get; private set; }

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
            Items = DataProvider.GetCollection<TModel>(filter).ToList();
            ItemSource = new ObservableCollection<TModel>(Items);
        }

        protected CollectionViewModel(object id)
        {
            Init(id);
        }

        private void Init(object id, object filter = null)
        {
            baseId = id;
            Items = DataProvider.GetCollection<TModel>(id,filter).ToList();
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

    public abstract class SingleViewModel<TModel> : ViewModelBase<TModel> where TModel : class
    {
        protected virtual TModel Content { get; private set; }

        object ModelID = null;

        protected SingleViewModel() { }
        protected SingleViewModel(object id)
        {
            Init(id);
        }
        private void Init(object id)
        {
            ModelID = id;
            Content = DataProvider.GetItem<TModel>(id);
        }

        protected bool AddItem(TModel item)
        {
            //DataProvider.AddItem<>
            return true;
        }

        protected bool UpdateItem(TModel item)
        {
            return true;
        }

        protected bool DeleteItem(TModel item)
        {
            return true;
        }
    }




}
