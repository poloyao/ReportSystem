using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using ReportSystem.Models;
using System.ComponentModel;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class AddHalfYearDetailViewModel : IDocumentContent
    {
        public static AddHalfYearDetailViewModel Create()
        {
            return ViewModelSource.Create(() => new AddHalfYearDetailViewModel());
        }

        protected AddHalfYearDetailViewModel()
        {
        }

        public virtual  ReportHalfYearDetailModel Content { get; set; } = new ReportHalfYearDetailModel();

        public IDocumentOwner DocumentOwner { get; set; }

        public object Title { get; }

        public bool IsSaved { get; set; } = false;

        public void Save()
        {
            //检查 正确这close
            this.IsSaved = true;
            DocumentOwner.Close(this, false);


        }

        public void OnClose(CancelEventArgs e)
        {
            e.Cancel = false;
        }

        public void OnDestroy()
        {
        }
    }
}