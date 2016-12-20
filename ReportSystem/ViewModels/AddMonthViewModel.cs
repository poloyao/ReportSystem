using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using ReportSystem.Models;
using System.Linq;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class AddMonthViewModel
    {
        public static AddMonthViewModel Create()
        {
            return ViewModelSource.Create(() => new AddMonthViewModel());
        }

        protected AddMonthViewModel()
        {

        }

        public void Save(object obj)
        {
            var workbook = ((DevExpress.Xpf.Spreadsheet.SpreadsheetControl)obj).Document;
            var workSheet = workbook.Worksheets[0];
            var rang = workSheet.Range["B8:O8"];
            //!++ rqs1
            ReportQuarterSheet1 rqs1 = new ReportQuarterSheet1();
            System.Reflection.PropertyInfo[] properties = rqs1.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

            for (int i = 0; i < rang.ColumnCount; i++)
            {
                var query = properties.Where(x => x.Name == $"A{(i + 1).ToString().PadLeft(2, '0')}");
                if (query == null)
                    continue;
                foreach (var item in query)
                {
                    item.SetValue(rqs1, rang[i].Value.ToString());
                }
            }
        }
    }
}