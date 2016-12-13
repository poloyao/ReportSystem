using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class AddPremiumViewModel:SingleViewModel<PremiumItemModel>
    {
        public static AddPremiumViewModel Create()
        {
            return ViewModelSource.Create(() => new AddPremiumViewModel());
        }

        protected AddPremiumViewModel() { }

        public virtual PremiumItemModel Content { get; set; }



        protected override void OnParameterChanged(object parameter)
        {
            base.OnParameterChanged(parameter);
            if (parameter != null)
                this.Content = base.ContentBase;
        }




    }
}