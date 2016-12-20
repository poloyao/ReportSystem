using ReportSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReportSystem.Views
{
    /// <summary>
    /// Interaction logic for ReportQuarterView.xaml
    /// </summary>
    public partial class ReportQuarterView : UserControl
    {
        public ReportQuarterView()
        {
            InitializeComponent();


            //ReportQuarterCollection model = new ReportQuarterCollection()
            //{                
            //    sheet1 = new List<ReportQuarterSheet1>()
            //    {
            //        new ReportQuarterSheet1() {A09 = "a09",Year = "2016",Quarter = "1" },
            //        new ReportQuarterSheet1() {A09 = "a19",Year = "2016",Quarter = "2" }
            //    },
            //    sheet2 = new List<ReportQuarterSheet2>()
            //    {
            //         new ReportQuarterSheet2() {A09 = "a09",Year = "2016",Quarter = "1" },
            //        new ReportQuarterSheet2() {A09 = "a19",Year = "2016",Quarter = "2" }
            //    },
                
            //    sheet3 = new List<ReportQuarterSheet3>()
            //    {
            //        new ReportQuarterSheet3() {A09 = "a09",Mark = "A",Year = "2016",Quarter = "1" },
            //        new ReportQuarterSheet3() { A20 = "a20",Mark = "B",Year = "2016",Quarter = "1" },
            //        new ReportQuarterSheet3() { A13 = "a13",Mark ="C",Year = "2016",Quarter = "1"},
            //        new ReportQuarterSheet3() { A05 = "a05",Mark = "D",Year = "2016",Quarter = "1" }
            //    }
            //};

            //List<ReportQuarterModel> lll = new List<ReportQuarterModel>();
            //lll.Add(new ReportQuarterModel()
            //{
            //    sheet1 = new ReportQuarterSheet1() { A09 = "a09", Year = "2016", Quarter = "1" },
            //    sheet2 = new ReportQuarterSheet2() { A09 = "a09", Year = "2016", Quarter = "1" },
            //    sheet3 = new List<ReportQuarterSheet3>()
            //    {
            //        new ReportQuarterSheet3() {A09 = "a09",Mark = "A",Year = "2016",Quarter = "1" },
            //        new ReportQuarterSheet3() { A20 = "a20",Mark = "B",Year = "2016",Quarter = "1" },
            //        new ReportQuarterSheet3() { A13 = "a13",Mark ="C",Year = "2016",Quarter = "1"},
            //        new ReportQuarterSheet3() { A05 = "a05",Mark = "D",Year = "2016",Quarter = "1" }
            //    }

            //});

            //var asd = lll.Select(x => x.sheet1).ToList();
            //var sddd = lll.Select(x => x.sheet2).ToList();
            //var asd3 = lll.Select(x => x.sheet3).ToList();


            //this.DataContext = model;

        }
    }
}
