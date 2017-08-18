using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace UIPages.Converters
{
    public class CommentBoxProperties : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string culture)
        {
            return bool.Parse(value.ToString()) ? HorizontalAlignment.Right : HorizontalAlignment.Left;

        }

        public object ConvertBack(object value, Type targetType,
            object parameter, string culture)
        {
            throw new NotImplementedException();
        }
    }

}
