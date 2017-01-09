using NLog;
using ReportSystem.Common.Data;
using ReportSystem.Common.Data.Demo;
using ReportSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportSystem.Common
{
    public static class Core
    {
        /// <summary>
        /// NLog日志
        /// </summary>
        public static Logger LOGGER = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// DataProvider分离
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <returns></returns>
        public static IDataProvider<TModel> GetDataProvider<TModel>() where TModel : class
        {
            if (IsDerivedFrom<TModel, ProjectItemModel>())
                return (IDataProvider<TModel>)(new ProjectItemDataProvider());

            //合同
            if (IsDerivedFrom<TModel, ContractItemModel>())
                return (IDataProvider<TModel>)(new ContractItemDataProvider());
            if (IsDerivedFrom<TModel, WarranteeItemModel>())
                return (IDataProvider<TModel>)(new WarranteeItemDataProvider());

            //放款
            if (IsDerivedFrom<TModel, LoanItemModel>())
                return (IDataProvider<TModel>)new LoanItemDataProvider();
            if (IsDerivedFrom<TModel, LoanSingleItemlModel>())
                return (IDataProvider<TModel>)new LoanSingleItemlDataProvider();
            if (IsDerivedFrom<TModel, LoanCreditorItemModel>())
                return (IDataProvider<TModel>)new LoanCreditorItemDataProvider();

            //保费
            if (IsDerivedFrom<TModel, PremiumCollectionItemModel>())
                return (IDataProvider<TModel>)new PremiumCollectionItemDataProvider();
            if (IsDerivedFrom<TModel, PremiumDisplayItemModel>())
                return (IDataProvider<TModel>)new PremiumDisplayItemDataProvider();
            if (IsDerivedFrom<TModel, CompanyDisplayModel>())
                return (IDataProvider<TModel>)new CompanyDisplayDataProvider();
            if (IsDerivedFrom<TModel, PremiumItemModel>())
                return (IDataProvider<TModel>)new PremiumItemDataProvider();

            //不良
            if (IsDerivedFrom<TModel, SupervisionModel>())
                return (IDataProvider<TModel>)new SupervisionDataProvider();
            if (IsDerivedFrom<TModel, SupervisionDetailModel>())
                return (IDataProvider<TModel>)new SupervisionDetailDataProvider();
            if (IsDerivedFrom<TModel, SupervisionRecoveryModel>())
                return (IDataProvider<TModel>)new SupervisionRecoveryDataProvider();

            //机构信息
            if (IsDerivedFrom<TModel, CompanyManagersModel>())
                return (IDataProvider<TModel>)new CompanyManagersDataprovider();
            if (IsDerivedFrom<TModel, CompanyStockholderModel>())
                return (IDataProvider<TModel>)new CompanyStockholderDataprovider();
            if (IsDerivedFrom<TModel, CompanyBranchModel>())
                return (IDataProvider<TModel>)new CompanyBranchDataprovider();
            if (IsDerivedFrom<TModel, CompanyAccountModel>())
                return (IDataProvider<TModel>)new CompanyAccountDataprovider();

            //报表
            if (IsDerivedFrom<TModel, ReportModel>())
                return (IDataProvider<TModel>)new ReportDataProvider();
            if (IsDerivedFrom<TModel, ReportMonthModel>())
                return (IDataProvider<TModel>)new ReportMonthDataProvider();
            if (IsDerivedFrom<TModel, ReportQuarterModel>())
                return (IDataProvider<TModel>)new ReportQuarterDataProvider();
            if (IsDerivedFrom<TModel, ReportHalfYearModel>())
                return (IDataProvider<TModel>)new ReportHalfYearDataProvider();
            if (IsDerivedFrom<TModel, ReportYearModel>())
                return (IDataProvider<TModel>)new ReportYearDataProvider();

            throw new Exception($"未实现{typeof(TModel)}的数据接口");
           // return null;
        }


        public static bool IsDerivedFrom<TBase, Tancestor>()
        {
            Type baseType = typeof(TBase);
            Type ancestorType = typeof(Tancestor);
            return baseType.Equals(ancestorType) || baseType.IsAssignableFrom(ancestorType);
        }

        /// <summary>
        /// 文件类型
        /// </summary>
        public enum FileOutputType
        {
            Project,
            Contract,
            Loan,
            Supervision,
            Premium,
            Report
        }

        /// <summary>
        /// table生成excel xlsx格式
        /// </summary>
        /// <param name="TableView"></param>
        /// <param name="filOutputType">生成的文件名</param>
        /// <param name="FilePath">路径</param>
        /// <param name="IsStart">是否打开文件</param>
        /// <returns></returns>
        public static bool CreateTableViewToXlsx(DevExpress.Xpf.Grid.TableView TableView, FileOutputType filOutputType,string FilePath = null,bool IsStart = true)
        {
            try
            {
                string FileName = GetFileName(filOutputType);
                if (FilePath == null)
                    FilePath = System.Environment.CurrentDirectory + "\\输出文件夹";
                if (!Directory.Exists(FilePath))
                    Directory.CreateDirectory(FilePath);
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Excel文件 (*.xlsx)|*.xlsx";
                dialog.InitialDirectory = FilePath;
                dialog.FileName = FileName;
                dialog.FilterIndex = 1;
                string saveFileName;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    saveFileName = dialog.FileName;
                    FileName = Path.GetFileNameWithoutExtension(saveFileName);
                }
                else
                {
                    return false;
                }
                if (File.Exists(saveFileName))
                {
                    FileStream fs = null;
                    bool inUse = true;
                    try
                    {
                        fs = new FileStream(saveFileName, FileMode.Open, FileAccess.Read, FileShare.None);
                        inUse = false;
                    }
                    catch { }
                    finally
                    {
                        if (fs != null)
                            fs.Close();
                    }
                    if (inUse)
                    {
                        DevExpress.Xpf.Core.DXMessageBox.Show(filOutputType + "正在被使用，请关闭后重新操作。");
                        return false;
                    }
                }
                DevExpress.XtraPrinting.XlsxExportOptionsEx option = new DevExpress.XtraPrinting.XlsxExportOptionsEx()
                {
                    ExportType = DevExpress.Export.ExportType.WYSIWYG,
                    TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text,
                    ShowGridLines = true,

                };
                TableView.ExportToXlsx(saveFileName, option);
                LOGGER.Info($"生成文件{filOutputType}成功");
                if (IsStart)
                {
                    //保存多个会打开多个文件夹，应让用户自主选择保存位置
                    //System.Diagnostics.Process.Start("Explorer.exe", filePath);
                    System.Diagnostics.Process.Start(saveFileName);
                }
                return true;
            }
            catch (Exception)
            {
                LOGGER.Error($"生成{filOutputType}文件失败");
                //throw new Exception($"生成{FileName}文件失败");
                return false;
            }
        }

        /// <summary>
        /// 获取文件类型默认名称
        /// </summary>
        /// <param name="filOutputType"></param>
        /// <returns></returns>
        public static string GetFileName(FileOutputType filOutputType)
        {
            string FileName = "";
            switch (filOutputType)
            {
                case FileOutputType.Project:
                    FileName = "项目清单";
                    break;
                case FileOutputType.Contract:
                    FileName = "合同清单";
                    break;
                case FileOutputType.Loan:
                    FileName = "放款清单";
                    break;
                case FileOutputType.Supervision:
                    FileName = "代偿清单";
                    break;
                case FileOutputType.Premium:
                    FileName = "保费清单";
                    break;
                case FileOutputType.Report:
                    FileName = "报表清单";
                    break;
            }

            return FileName;
        }

        /// <summary>
        /// table生成文档打印
        /// </summary>
        /// <param name="TableView"></param>
        /// <returns></returns>
        public static DevExpress.Xpf.Printing.PrintableControlLink GetPrintableLink(DevExpress.Xpf.Grid.TableView TableView)
        {
            var link = new DevExpress.Xpf.Printing.PrintableControlLink(TableView)
            {
                Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50),
                PaperKind = System.Drawing.Printing.PaperKind.A4                
            };
            link.CreateDocument(true);
            return link;
        }
    }
}
