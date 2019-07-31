using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace DataBinding
{
    class Farbkonverter : IValueConverter
    {
        // OneWay-Binding
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string farbe = value as String; // as-Operator: null, wenn kein string drinnen ist
            if(farbe == null)
                return Color.Black;

            if (farbe == "Rot")
                return Color.Red;
            else if (farbe == "Gelb")
                return Color.Yellow;
            else if (farbe == "Grün")
                return Color.Green;
            else
                return Color.White;
        }

        // TwoWay-Binding
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
