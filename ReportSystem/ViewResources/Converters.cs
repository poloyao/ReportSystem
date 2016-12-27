using ReportSystem.Common.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ReportSystem.ViewResources
{
    public class ColumnIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || !(value is int)) return null;
            int intValue = (int)value;
            return new BitmapImage(new Uri(String.Format(@"pack://application:,,,/DevExpress.ProductsDemo.Wpf;component/Images/Tasks/Status_{0}.png", intValue), UriKind.RelativeOrAbsolute));
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }

    /// <summary>
    /// 类型转换
    /// </summary>
    public class CommonTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Guid.Empty == (Guid)value)
                return null;
            var result = SingleTypeCode.GetInstance().GetCommonCode(value.ToString());
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = ((CommonSer.CommonCodeDataObject)value).ID;
            return result;
        }
    }


    /// <summary>
    /// 用于判断是否显示代偿组件
    /// </summary>
    public class RelieveDisplayConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return false;
            var query = ((CommonSer.CommonCodeDataObject)value).Value;//DataProvider.SingleTypeCode.GetInstance().GetCommonCode(value.ToString()).Value;
            if (query == "3")
                return true;
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 用于控制是否可填写状态
    /// </summary>
    public class RelieveReadOnlyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return false;
            var query = ((CommonSer.CommonCodeDataObject)value).Value;//DataProvider.SingleTypeCode.GetInstance().GetCommonCode(value.ToString()).Value;
            if (query == "1")
                return false;
            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    public class LoanStatusColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //return (value == null || string.IsNullOrEmpty(new Regex(@"^#*").Match(value.ToString()).Value)) ?
            //   Colors.Transparent : (Color)ColorConverter.ConvertFromString(value.ToString());

            if (value == null)
                return Colors.Transparent;
            else
            {
                Color color = new Color();
                switch ((int)value)
                {
                    case 0:
                        color = Colors.Green;//绿色 正常
                        break;
                    case 1:
                        color = Colors.Gray;//灰色 解除
                        break;
                    case 2:
                        color = Colors.Crimson;// 红色 代偿
                        break;
                }
                return color;
            }


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null ? null : value.ToString();
        }
    }


    public class LoanStatusTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return "异常";
            else
            {
                string result = "";
                switch ((int)value)
                {
                    case 0:
                        result = "正常";
                        break;
                    case 1:
                        result = "解除";
                        break;
                    case 2:
                        result = "代偿";
                        break;
                    default:
                        result = "异常";
                        break;
                }
                return result;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null ? null : value.ToString();
        }
    }


    /// <summary>
    /// 转换继续追偿标记
    /// </summary>
    public class GoMarkConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //如果传入此类异常值 则表示默认true状态，继续追偿
            if (value == null || value.ToString() == Guid.Empty.ToString())
                return true;
            var query = SingleTypeCode.GetInstance().GetCommonCode(value.ToString()).Value; //((CommonSer.CommonCodeDataObject)value).Value;
            if (query == "1")
                return true;
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var query = SingleTypeCode.GetInstance().GetList(CommonSer.CommonStatusDataObject.GoMark);
            if ((bool)value)
                return query.Single(x => x.Value == "1").ID;
            return query.Single(x => x.Value == "2").ID;
        }
    }

}
