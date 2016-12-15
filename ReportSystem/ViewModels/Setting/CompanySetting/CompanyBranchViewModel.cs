using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using System.Collections.ObjectModel;
using ReportSystem.Models;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class CompanyBranchViewModel
    {
        public virtual ObservableCollection<CompanyBranchModel> CB { get; set; } = new ObservableCollection<CompanyBranchModel>();
    }
}