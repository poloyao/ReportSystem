using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.ComponentModel;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class CreditorViewModel:IDocumentContent
    {
        public IDocumentOwner DocumentOwner { get; set; }

        public object Title { get; }

        public static CreditorViewModel Create()
        {
            return ViewModelSource.Create(() => new CreditorViewModel());
        }

        protected CreditorViewModel() { }


        public void Save()
        {

        }

        public void Close()
        {
            DocumentOwner.Close(this, false);
        }

        public void OnClose(CancelEventArgs e)
        {
            e.Cancel = false;
        }

        public void OnDestroy() { }
    }
}