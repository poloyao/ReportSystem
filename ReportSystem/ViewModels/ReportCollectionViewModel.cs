using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.Collections.Generic;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class ReportCollectionViewModel
    {
        private INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        public enum ReportTitleEnum
        {
            
        }

        public Dictionary<string,string> ReportTitle { get; private set; }

        public virtual int SelectIndex { get; set; }

        public void OnViewLoaded()
        {
            NavigationService.Navigate("ReportMonthView", null, this);
        }

        public void SelectedIndexChanged(int index)
        {
            string navString = "ReportMonthView";
            switch (index)
            {
                case 0:
                    navString = "ReportMonthView";
                    break;
                case 1:
                    navString = "ReportQuarterView";
                    break;
                case 2:
                    navString = "ReportHalfYearView";
                    break;
                case 3:
                    navString = "ReportYearView";
                    break;
                default:
                    break;
            }
            NavigationService.Navigate(navString, null, this);
        }



    }
}