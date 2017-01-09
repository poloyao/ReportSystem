using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using ReportSystem.Models;
using System.Linq;
using ReportSystem.Common.ViewModel;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class AddMonthViewModel: SingleViewModel<ReportMonthModel>
    {
        public static AddMonthViewModel Create()
        {
            return ViewModelSource.Create(() => new AddMonthViewModel());
        }

        protected AddMonthViewModel()
        {

        }

        public ReportMonthModel Content { get; set; }
        public bool IsSaved { get; set; } = false;

        public void Save(object obj)
        {
            Content = new ReportMonthModel();
            var workbook = ((DevExpress.Xpf.Spreadsheet.SpreadsheetControl)obj).Document;
            var workSheet = workbook.Worksheets[0];
            var rang = workSheet.Range["B8:Y8"];
            //!++ rqs1
            ReportMonthSheet1 rqs1 = new ReportMonthSheet1();
            SetModelValue(rang, rqs1);

            workSheet = workbook.Worksheets[1];
            rang = workSheet.Range["B8:T8"];
            ReportMonthSheet2 rqs2 = new ReportMonthSheet2();
            SetModelValue(rang, rqs2);

            workSheet = workbook.Worksheets[2];
            rang = workSheet.Range["B8:L8"];
            ReportMonthSheet3 rqs3 = new ReportMonthSheet3();
            SetModelValue(rang, rqs3);

            workSheet = workbook.Worksheets[3];
            rang = workSheet.Range["B8:J8"];
            ReportMonthSheet4 rqs4 = new ReportMonthSheet4();
            SetModelValue(rang, rqs4);

            Content.Sheet1 = rqs1;
            Content.Sheet2 = rqs2;
            Content.Sheet3 = rqs3;
            Content.Sheet4 = rqs4;

            var query =  base.AddItem(Content);
            if (query != null)
            {
                Content = query;
                IsSaved = true;
            }

        }

        private static void SetModelValue<T>(DevExpress.Spreadsheet.Range rang,  T sheet)
        {
            System.Reflection.PropertyInfo[] properties = sheet.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

            for (int i = 0; i < rang.ColumnCount; i++)
            {
                var query = properties.Where(x => x.Name == $"A{(i + 1).ToString().PadLeft(2, '0')}");
                if (query == null)
                    continue;
                foreach (var item in query)
                {
                    item.SetValue(sheet, rang[i].Value.ToString());
                }
            }
        }

        protected override void OnParameterChanged(object parameter)
        {
            base.OnParameterChanged(parameter);
            if (parameter != null)
                this.Content = base.ContentBase;
        }

        public void DocLoaded(object obj)
        {
            if (this.Content == null)
                return;
            try
            {
                var sp = (DevExpress.Xpf.Spreadsheet.SpreadsheetControl)obj;
                sp.BeginUpdate();
                var workbook = (sp).Document;
                var workSheet = workbook.Worksheets[0];
                DevExpress.Spreadsheet.Range rang;
                rang = workSheet.Range["B8:Y8"];
                SetCellValue(rang, this.Content.Sheet1);

                workSheet = workbook.Worksheets[1];
                rang = workSheet.Range["B8:T8"];
                SetCellValue(rang, this.Content.Sheet2);

                workSheet = workbook.Worksheets[2];
                rang = workSheet.Range["B8:L8"];
                SetCellValue(rang, this.Content.Sheet3);


                workSheet = workbook.Worksheets[3];
                rang = workSheet.Range["B8:J8"];
                SetCellValue(rang, this.Content.Sheet4);

                sp.EndUpdate();
            }
            catch (Exception)
            {
                DocumentOwner.Close(this, false);
                throw new Exception("月报表数据不完整。请联系管理员。");
            }
        }

        private static void SetCellValue<T>(DevExpress.Spreadsheet.Range rang, T sheet)
        {
            System.Reflection.PropertyInfo[] properties = sheet.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

            for (int i = 0; i < rang.ColumnCount; i++)
            {
                var query = properties.Where(x => x.Name == $"A{(i + 1).ToString().PadLeft(2, '0')}");
                if (query == null)
                    continue;
                foreach (var item in query)
                {
                    if (item.PropertyType == typeof(string))
                        rang[i].Value = (string)item.GetValue(sheet);
                }
            }
        }

    }
}