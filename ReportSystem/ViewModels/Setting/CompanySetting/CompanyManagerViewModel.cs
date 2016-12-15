using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using System.Collections.ObjectModel;
using ReportSystem.Models;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class CompanyManagerViewModel
    {
        public virtual ObservableCollection<CompanyManagersModel> CM { get; set; } = new ObservableCollection<CompanyManagersModel>();
    }
}