using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using ReportSystem.Models;
using System.Linq;
using System.Collections.Generic;
using ReportSystem.Common.ViewModel;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class AddYearViewModel: SingleViewModel<ReportYearModel>
    {

        public static AddYearViewModel Create()
        {
            return ViewModelSource.Create(() => new AddYearViewModel());
        }

        protected AddYearViewModel()
        { }
        
        public ReportYearModel Content { get; set; }

        public bool IsSaved { get; set; } = false;

        public void Save(object obj)
        {
            Content = new ReportYearModel();
            //判断公司性质取值 用于sheet1-3表
            bool IsCompany = true;
            var workbook = ((DevExpress.Xpf.Spreadsheet.SpreadsheetControl)obj).Document;
            var workSheet = workbook.Worksheets[0];
            DevExpress.Spreadsheet.Range rang;
            ReportYearSheet1 rqs1 = new ReportYearSheet1();
            if (IsCompany)
            {
                rang = workSheet.Range["E11:E35"];
                rqs1.Mark = "公司制";
            }
            else
            {
                rang = workSheet.Range["F11:F35"];
                rqs1.Mark = "非公司制";
            }             
            SetModelValue_Column(rang, rqs1);

            workSheet = workbook.Worksheets[1];
            ReportYearSheet2 rqs2 = new ReportYearSheet2();
            if (IsCompany)
            {
                rang = workSheet.Range["D10:D32"];
                rqs2.Mark = "公司制";
            }
            else
            {
                rang = workSheet.Range["E10:E32"];
                rqs2.Mark = "非公司制";
            }
            SetModelValue_Column(rang, rqs2);

            workSheet = workbook.Worksheets[2];
            ReportYearSheet3 rqs3 = new ReportYearSheet3();
            if (IsCompany)
            {
                rang = workSheet.Range["C10:C27"];
                rqs3.Mark = "公司制";
            }
            else
            {
                rang = workSheet.Range["D10:D27"];
                rqs3.Mark = "非公司制";
            }            
            SetModelValue_Column(rang, rqs3);

            workSheet = workbook.Worksheets[3];
            rang = workSheet.Range["D10:G34"];
            List<ReportYearSheet4> rqs4 = new List<ReportYearSheet4>();
            SetModelValue_Column_Row(rang, rqs4);

            workSheet = workbook.Worksheets[4];
            rang = workSheet.Range["D10:F34"];
            List<ReportYearSheet5> rqs5 = new List<ReportYearSheet5>();
            SetModelValue_Column_Row(rang, rqs5);

            workSheet = workbook.Worksheets[5];
            rang = workSheet.Range["B8:M8"];
            ReportYearSheet6 rqs6 = new ReportYearSheet6();
            SetModelValue(rang, rqs6);

            workSheet = workbook.Worksheets[6];
            rang = workSheet.Range["B7:O7"];
            ReportYearSheet7 rqs7 = new ReportYearSheet7();
            SetModelValue(rang, rqs7);

            Content.Sheet1 = rqs1;
            Content.Sheet2 = rqs2;
            Content.Sheet3 = rqs3;
            Content.Sheet4 = rqs4;
            Content.Sheet5 = rqs5;
            Content.Sheet6 = rqs6;
            Content.Sheet7 = rqs7;

            var query = base.AddItem(Content);
            if (query != null)
            {
                Content = query;
                IsSaved = true;
            }
            

        }

        /// <summary>
        /// 单列赋值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rang"></param>
        /// <param name="sheet"></param>
        private static void SetModelValue<T>(DevExpress.Spreadsheet.Range rang, T sheet)
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

        /// <summary>
        /// 单列多行赋值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rang"></param>
        /// <param name="sheet"></param>
        private static void SetModelValue_Column<T>(DevExpress.Spreadsheet.Range rang, T sheet)
        {
            for (int i = 0; i < rang.ColumnCount; i++)
            {
                string mark = i == 0 ? "A" : i == 1 ? "B" : i == 2 ? "C" : "D";
                System.Reflection.PropertyInfo[] properties = sheet.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
                for (int j = 0; j < rang.RowCount; j++)
                {
                    var query = properties.Where(x => x.Name == $"A{(j + 1).ToString().PadLeft(2, '0')}");
                    if (query == null || rang[j, i].Value.ToString() == "——")
                        continue;
                    foreach (var item in query)
                    {
                        item.SetValue(sheet, rang[j, i].Value.ToString());
                    }
                }
                //properties.Single(x => x.Name == "Mark").SetValue(sheet, mark);
            }
        }

        /// <summary>
        /// 多列多行
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rang"></param>
        /// <param name="sheet"></param>
        private static void SetModelValue_Column_Row<T>(DevExpress.Spreadsheet.Range rang, List<T> sheet) where T: class,new()
        {
            Type type = typeof(T);
            //sheet = new List<T>();
            System.Reflection.PropertyInfo[] properties = type.GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            for (int i = 0; i < rang.ColumnCount; i++)
            {
                var tempSheet = new T();
                string mark = i == 0 ? "A" : i == 1 ? "B" : i == 2 ? "C" : "D";
                for (int j = 0; j < rang.RowCount; j++)
                {
                    var query = properties.Where(x => x.Name == $"A{(j + 1).ToString().PadLeft(2, '0')}");
                    if (query == null || rang[j, i].Value.ToString() == "——")
                        continue;
                    foreach (var item in query)
                    {
                        item.SetValue(tempSheet, rang[j, i].Value.ToString());
                    }
                }
                properties.Single(x => x.Name == "Mark").SetValue(tempSheet, mark);
                sheet.Add(tempSheet);
            }
        }

        protected override void OnParameterChanged(object parameter)
        {
            base.OnParameterChanged(parameter);
            if (parameter != null)
            {
                this.Content = base.ContentBase;
                //SetExcel();
            }
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
                bool IsCompany = false;
                if (this.Content.Sheet1.Mark == "公司制")
                    IsCompany = true;

                if (IsCompany)
                {
                    rang = workSheet.Range["E11:E35"];
                }
                else
                {
                    rang = workSheet.Range["F11:F35"];
                }
                SetCellValue_Column(rang, this.Content.Sheet1);


                workSheet = workbook.Worksheets[1];
                if (IsCompany)
                    rang = workSheet.Range["D10:D32"];
                else
                    rang = workSheet.Range["E10:E32"];
                SetCellValue_Column(rang, this.Content.Sheet2);

                workSheet = workbook.Worksheets[2];
                if (IsCompany)
                    rang = workSheet.Range["C10:C27"];
                else
                    rang = workSheet.Range["D10:D27"];
                SetCellValue_Column(rang, this.Content.Sheet3);

                workSheet = workbook.Worksheets[3];
                rang = workSheet.Range["D10:G34"];
                SetCellValue_Column_Row(rang, this.Content.Sheet4);

                workSheet = workbook.Worksheets[4];
                rang = workSheet.Range["D10:F34"];
                SetCellValue_Column_Row(rang, this.Content.Sheet5);

                workSheet = workbook.Worksheets[5];
                rang = workSheet.Range["B8:M8"];
                SetCellValue(rang, this.Content.Sheet6);

                workSheet = workbook.Worksheets[6];
                rang = workSheet.Range["B7:O7"];
                SetCellValue(rang, this.Content.Sheet7);

                sp.EndUpdate();
            }
            catch (Exception)
            {
                DocumentOwner.Close(this,false);
                throw new Exception("年报表数据不完整。请联系管理员。");
            }
           

            
        }
        
        /// <summary>
        /// 单列赋值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rang"></param>
        /// <param name="sheet"></param>
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
        /// <summary>
        /// 单列多行赋值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rang"></param>
        /// <param name="sheet"></param>
        private static void SetCellValue_Column<T>(DevExpress.Spreadsheet.Range rang, T sheet)
        {
            for (int i = 0; i < rang.ColumnCount; i++)
            {
                string mark = i == 0 ? "A" : i == 1 ? "B" : i == 2 ? "C" : "D";
                System.Reflection.PropertyInfo[] properties = sheet.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
                for (int j = 0; j < rang.RowCount; j++)
                {
                    var query = properties.Where(x => x.Name == $"A{(j + 1).ToString().PadLeft(2, '0')}");
                    if (query == null || rang[j, i].Value.ToString() == "——")
                        continue;
                    foreach (var item in query)
                    {
                        if (item.PropertyType == typeof(string))
                            rang[j, i].Value = (string)item.GetValue(sheet);
                    }
                }
            }
        }

        /// <summary>
        /// 多列多行
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rang"></param>
        /// <param name="sheet"></param>
        private static void SetCellValue_Column_Row<T>(DevExpress.Spreadsheet.Range rang, List<T> ListSheet)where T: new()
        {
            

            Type type = typeof(T);
            System.Reflection.PropertyInfo[] properties = type.GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

            ListSheet.ForEach(s =>
            {
                var markTemp = properties.Single(x => x.Name == "Mark").GetValue(s).ToString();
                var mark = markTemp == "A" ? 0 : markTemp == "B" ? 1 : markTemp == "C" ? 2 : 3;

                for (int j = 0; j < rang.RowCount; j++)
                {
                    var query = properties.Where(x => x.Name == $"A{(j + 1).ToString().PadLeft(2, '0')}");
                    if (query == null || rang[j, mark].Value.ToString() == "——")
                        continue;
                    foreach (var item in query)
                    {
                        if (item.PropertyType == typeof(string))
                            rang[j, mark].Value = (string)item.GetValue(s);
                    }

                }
            });
            
                
            

        }

    }
}