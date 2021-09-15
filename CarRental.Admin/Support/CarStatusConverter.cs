using System;
using System.Windows.Data;

namespace CarRental.Admin.Support
{
    /// <summary>
    /// 
    /// </summary>
    public class CarStatusConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool currentlyRented = (bool)value;

            return (currentlyRented ? "Currently Rented" : "Available");
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}