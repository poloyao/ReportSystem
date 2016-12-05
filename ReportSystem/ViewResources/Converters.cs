using ReportSystem.Common.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
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
}
