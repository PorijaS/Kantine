
/* Unmerged change from project 'Kantine (net6.0-maccatalyst)'
Before:
using Kantine.Views;
using Kantine.Services;
After:
using Kantine.Services;
using Kantine.Views;
*/

/* Unmerged change from project 'Kantine (net6.0-ios)'
Before:
using Kantine.Views;
using Kantine.Services;
After:
using Kantine.Services;
using Kantine.Views;
*/

/* Unmerged change from project 'Kantine (net6.0-windows10.0.19041.0)'
Before:
using Kantine.Views;
using Kantine.Services;
After:
using Kantine.Services;
using Kantine.Views;
*/
namespace Kantine.ViewModel
{
    public class CreditCardPageViewModel : ViewModelBase
    {
        private string _cardCvv;
        private string _cardExpirationDate;
        private string _cardNumber;

        public string CardCvv
        {
            get => _cardCvv;
            set => SetProperty(ref _cardCvv, value);
        }

        public string CardExpirationDate
        {
            get => _cardExpirationDate;
            set => SetProperty(ref _cardExpirationDate, value);
        }

        public string CardNumber
        {
            get => _cardNumber;
            set => SetProperty(ref _cardNumber, value);
        }
    }
}

