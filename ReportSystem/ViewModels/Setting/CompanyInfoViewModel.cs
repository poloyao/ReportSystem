using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using ReportSystem.Models;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class CompanyInfoViewModel
    {

        public virtual CompanyInfoModel Content { get; set; }
    }
}