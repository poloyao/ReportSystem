﻿using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using ReportSystem.Models;
using System.Linq;
using System.Collections.Generic;

namespace ReportSystem.ViewModels
{
    [POCOViewModel]
    public class AddQuarterViewModel
    {
        public static AddQuarterViewModel Create()
        {
            return ViewModelSource.Create(() => new AddQuarterViewModel());
        }

        protected AddQuarterViewModel()
        { }



        public ReportQuarterModel Content { get; private set; }

        public void Save(object obj)
        {
            Content = new ReportQuarterModel();
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
            rqs1.Year = "2016";
            rqs1.Quarter = "4";

            workSheet = workbook.Worksheets[1];
            rang = workSheet.Range["B9:P9"];
            //!++ rqs2
            ReportQuarterSheet2 rqs2 = new ReportQuarterSheet2();
            properties = rqs2.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

            for (int i = 0; i < rang.ColumnCount; i++)
            {
                var query = properties.Where(x => x.Name == $"A{(i + 1).ToString().PadLeft(2, '0')}");
                if (query == null)
                    continue;
                foreach (var item in query)
                {
                    item.SetValue(rqs2, rang[i].Value.ToString());
                }
            }
            rqs2.Year = "2016";
            rqs2.Quarter = "4";

            workSheet = workbook.Worksheets[2];
            rang = workSheet.Range["C9:F31"];
            //!++ rqs3
            List<ReportQuarterSheet3> rqs3List = new List<ReportQuarterSheet3>();

            for (int i = 0; i < rang.ColumnCount; i++)
            {
                string mark = "A";
                switch (i)
                {
                    case 0:
                        mark = "A";
                        break;
                    case 1:
                        mark = "B";
                        break;
                    case 2:
                        mark = "C";
                        break;
                    case 3:
                        mark = "D";
                        break;
                    default:
                        break;
                }
                ReportQuarterSheet3 rqs3 = new ReportQuarterSheet3();
                properties = rqs3.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
                for (int j = 0; j < rang.RowCount; j++)
                {
                    var query = properties.Where(x => x.Name == $"A{(j + 1).ToString().PadLeft(2, '0')}");
                    if (query == null || rang[j,i].Value.ToString() == "——")
                        continue;
                    foreach (var item in query)
                    {
                        item.SetValue(rqs3, rang[j,i].Value.ToString());
                    }
                }
                rqs3.Mark = mark;
                rqs3.Year = "2016";
                rqs3.Quarter = "4";
                rqs3List.Add(rqs3);
            }

            Content.sheet1 = rqs1;
            Content.sheet2 = rqs2;
            Content.sheet3 = rqs3List;
        }
    }
}