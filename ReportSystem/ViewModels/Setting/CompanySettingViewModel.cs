using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using ReportSystem.Models;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class CompanySettingViewModel
    {

        public virtual CompanyDisplayModel Content { get; set; }
    }
}