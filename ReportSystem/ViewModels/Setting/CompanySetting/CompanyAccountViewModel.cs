using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using System.Collections.ObjectModel;
using ReportSystem.Models;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class CompanyAccountViewModel
    {
        public virtual ObservableCollection<CompanyAccountModel> CA { get; set; } = new ObservableCollection<CompanyAccountModel>();
    }
}