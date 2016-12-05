using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using ReportSystem.Common.ViewModel;
using ReportSystem.Models;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class ProjectSingleViewModel : SingleViewModel<ProjectItemModel>
    {
        
        public virtual ProjectItemModel Content { get; set; }

        protected ProjectSingleViewModel()
        {
            //this.Content = base.ContentBase;
        }

        public static ProjectSingleViewModel Create()
        {
            return ViewModelSource.Create(() => new ProjectSingleViewModel());
        }

        protected override void OnParameterChanged(object parameter)
        {
            base.OnParameterChanged(parameter);
            this.Content = base.ContentBase;
        }



    }
}