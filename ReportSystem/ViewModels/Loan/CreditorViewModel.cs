using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class CreditorViewModel
    {
        public static CreditorViewModel Create()
        {
            return ViewModelSource.Create(() => new CreditorViewModel());
        }

        protected CreditorViewModel() { }
    }
}