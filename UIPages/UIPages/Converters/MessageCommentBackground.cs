using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace UIPages.Converters
{
    public class MessageCommentBackground : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string culture)
        { 
            return bool.Parse(value.ToString()) ? new SolidColorBrush(Colors.Yellow) : new SolidColorBrush(Colors.White);

        }

        public object ConvertBack(object value, Type targetType,
            object parameter, string culture)
        {
            throw new NotImplementedException();
        }
    }
}
