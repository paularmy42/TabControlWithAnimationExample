using System;
using System.Globalization;
using System.Windows.Data;

namespace TabControlWithAnimationExample
{
    public class NonZeroToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() == typeof(int))
            {
                int intValue = (int)value;
                if (intValue > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public object ConvertBack(object values, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class SelectedTabToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            TabItemView tabView = (TabItemView)value;
            TabItemViewModel tabVM = (TabItemViewModel)tabView.DataContext;
            bool isSelected = tabVM.IsSelected;
            return isSelected;
        }

        public object ConvertBack(object values, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
