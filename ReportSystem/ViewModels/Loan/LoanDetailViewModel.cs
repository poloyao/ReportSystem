using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class LoanDetailViewModel:SingleViewModel<LoanCreditorItemModel>
    {
        public static LoanDetailViewModel Creatr()
        {
            return ViewModelSource.Create(() => new LoanDetailViewModel());
        }

        protected LoanDetailViewModel() { }

        private INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        public virtual LoanCreditorItemModel Content { get; set; }

        public void GoBack()
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();
        }

        public void NewLoan()
        {

        }

        protected override void OnParameterChanged(object parameter)
        {
            base.OnParameterChanged(parameter);
            this.Content = base.ContentBase;

        }
    }
}