using System.Globalization;

namespace Kantine.Services
{
    public class CardNumberToColorConverter : BaseCardValidator, IValueConverter
    {
        public Color Visa { get; set; }
        public Color Amex { get; set; }
        public Color MasterCard { get; set; }
        public Color Dinners { get; set; }
        public Color Discover { get; set; }
        public Color JCB { get; set; }
        public Color Unknown { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null)
                return Unknown;

            var number = value.ToString();
            var numberNormalized = number.Replace("-", string.Empty);

            if (visaRegex.IsMatch(numberNormalized))
                return Visa;

            else if (amexRegex.IsMatch(numberNormalized))
                return Amex;

            else if (masterRegex.IsMatch(numberNormalized))
                return MasterCard;

            else if (dinnersRegex.IsMatch(numberNormalized))
                return Dinners;

            else if (discoverRegex.IsMatch(numberNormalized))
                return Discover;

            else if (jcbRegex.IsMatch(numberNormalized))
                return JCB;

            else
                return Unknown;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

