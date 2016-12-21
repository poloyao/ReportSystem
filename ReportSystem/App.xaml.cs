using DevExpress.Xpf.Core;
using ReportSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ReportSystem
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            ExceptionHelper.Initialize();
            DevExpress.Images.ImagesAssemblyLoader.Load();
            ThemeManager.ApplicationThemeName = Theme.Office2013Name;
        }

        private void OnAppStartup_UpdateThemeName(object sender, StartupEventArgs e)
        {

            var win = new Views.LoginWindow();
            win.Show();

            DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName();

            var singleCommon = Common.Data.SingleTypeCode.GetInstance();
            //证件类型
            System.Windows.Application.Current.Resources.Add("AllCodeType", singleCommon.GetList(CommonSer.CommonStatusDataObject.CodeType));
            //缴费类别
            System.Windows.Application.Current.Resources.Add("AllPayType", singleCommon.GetList(CommonSer.CommonStatusDataObject.PayType));
            //保费缴纳状态
            System.Windows.Application.Current.Resources.Add("AllPayStatus", singleCommon.GetList(CommonSer.CommonStatusDataObject.PayStatus));
            //保费缴纳方式
            System.Windows.Application.Current.Resources.Add("AllPayOption", singleCommon.GetList(CommonSer.CommonStatusDataObject.PayOption));
            //保费缴纳频率
            System.Windows.Application.Current.Resources.Add("AllPayFre", singleCommon.GetList(CommonSer.CommonStatusDataObject.PayFre));
            //担保业务种类
            System.Windows.Application.Current.Resources.Add("AllBusinessType", singleCommon.GetList(CommonSer.CommonStatusDataObject.BusinessType));
            //担保方式
            System.Windows.Application.Current.Resources.Add("AllGuaranteeType", singleCommon.GetList(CommonSer.CommonStatusDataObject.GuaranteeType));
            //状态位
            System.Windows.Application.Current.Resources.Add("AllStatus", singleCommon.GetList(CommonSer.CommonStatusDataObject.Status));
            //债权人类型
            System.Windows.Application.Current.Resources.Add("AllCreditorType", singleCommon.GetList(CommonSer.CommonStatusDataObject.CreditorType));
            //被担保人类型
            System.Windows.Application.Current.Resources.Add("AllWarranteeType", singleCommon.GetList(CommonSer.CommonStatusDataObject.WarranteeType));
            //反担保人类型
            System.Windows.Application.Current.Resources.Add("AllCGManType", singleCommon.GetList(CommonSer.CommonStatusDataObject.CGManType));
            //反担保方式
            System.Windows.Application.Current.Resources.Add("AllCGType", singleCommon.GetList(CommonSer.CommonStatusDataObject.CGType));
            //担保合同状态
            System.Windows.Application.Current.Resources.Add("AllContractStatus", singleCommon.GetList(CommonSer.CommonStatusDataObject.ContractStatus));
            //继续追偿标志
            System.Windows.Application.Current.Resources.Add("AllGoMark", singleCommon.GetList(CommonSer.CommonStatusDataObject.GoMark));
            //本期保费缴纳状态
            System.Windows.Application.Current.Resources.Add("AllBQStatus", singleCommon.GetList(CommonSer.CommonStatusDataObject.BQStatus));
            //解除状态 （新增枚举类型,选择全部解除时触发All标记 1 ）
            System.Windows.Application.Current.Resources.Add("AllRelieveStatus", singleCommon.GetList("15"));
        }
    }
}
