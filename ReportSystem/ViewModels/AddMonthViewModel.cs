using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class AddMonthViewModel
    {
        public static AddMonthViewModel Create()
        {
            return ViewModelSource.Create(() => new AddMonthViewModel());
        }

        protected AddMonthViewModel()
        {

        }
    }
}