using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ToDoApp.Converters
{
    public class DisplayMultiConverters : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values != null)
            {
                if (values.Length == 2)
                {
                    bool display = false;
                    if (bool.TryParse(values[0].ToString(), out bool result))
                    {
                        display = result;
                    }

                    var title = values[1].ToString();

                    if (title != "我的一天" && !display)
                    {
                        return string.Empty;
                    }
                    else
                    {
                        string time = string.Format("{0:M}", DateTime.Now);

                        string[] weeks = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };

                        string week = weeks[System.Convert.ToInt32(DateTime.Now.DayOfWeek)];
                        return $"{time},{week}";
                    }
                }
            }
            return string.Empty;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
