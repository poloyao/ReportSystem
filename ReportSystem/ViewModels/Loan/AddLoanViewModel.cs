using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class AddLoanViewModel
    {
        public static AddLoanViewModel Create()
        {
            return ViewModelSource.Create(() => new AddLoanViewModel());
        }

        protected AddLoanViewModel() { }
    }
}