using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using System.Collections.ObjectModel;
using ReportSystem.Models;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class CompanyStockholderViewModel
    {
        public virtual ObservableCollection<CompanyStockholderModel> CS { get; set; } = new ObservableCollection<CompanyStockholderModel>();
    }
}