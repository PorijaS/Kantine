using System.Globalization;

namespace Kantine.Services
{
    public class CardNumberToImageConverter : BaseCardValidator, IValueConverter
    {
        public ImageSource Visa { get; set; }
        public ImageSource Amex { get; set; }
        public ImageSource MasterCard { get; set; }
        public ImageSource Dinners { get; set; }
        public ImageSource Discover { get; set; }
        public ImageSource JCB { get; set; }
        public ImageSource Unknown { get; set; }

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

