using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace ReportSystem.ViewResources
{
    public class ColumnIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null || !(value is int)) return null;
            int intValue = (int)value;
            return new BitmapImage(new Uri(String.Format(@"pack://application:,,,/DevExpress.ProductsDemo.Wpf;component/Images/Tasks/Status_{0}.png", intValue), UriKind.RelativeOrAbsolute));
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
