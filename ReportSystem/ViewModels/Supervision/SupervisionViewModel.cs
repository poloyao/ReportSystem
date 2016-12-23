using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class SupervisionViewModel:SingleViewModel<SupervisionDetailModel>
    {


        public virtual SupervisionDetailModel Content { get; set; }


        protected override void OnParameterChanged(object parameter)
        {
            base.OnParameterChanged(parameter);
            if (parameter != null)
                Content = ContentBase; 
        }
    }
}