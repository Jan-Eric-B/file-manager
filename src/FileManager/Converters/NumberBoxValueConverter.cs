using System;
using System.Globalization;
using System.Windows.Data;

namespace FileManager.Converters
{
    /// <summary>
    /// Converts a numeric view model property (int, double, ...) to the nullable double used by
    /// WPF UI's NumberBox.Value and back. WPF's default binding conversion does not handle this.
    /// </summary>
    public class NumberBoxValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is null ? null : System.Convert.ToDouble(value, culture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not double number)
            {
                return Binding.DoNothing;
            }

            Type underlyingType = Nullable.GetUnderlyingType(targetType) ?? targetType;

            if (underlyingType == typeof(int) || underlyingType == typeof(long))
            {
                number = Math.Round(number);
            }

            return System.Convert.ChangeType(number, underlyingType, culture);
        }
    }
}
