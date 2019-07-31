using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace DataBinding
{
    class Farbkonverter : IValueConverter
    {
        private Color oldValidValue;

        // OneWay-Binding
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string farbe = value as String; // as-Operator: null, wenn kein string drinnen ist

            var colorField = typeof(Color).GetFields().FirstOrDefault(x => x.Name == farbe);
            if(colorField == null)
                return oldValidValue;

            oldValidValue = (Color)colorField.GetValue(typeof(Color));
            return oldValidValue;
        }

        // TwoWay-Binding
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
