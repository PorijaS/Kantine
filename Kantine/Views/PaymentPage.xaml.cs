using Kantine.ViewModel;

namespace Kantine.Views;

public partial class PaymentPage : ContentPage
{
	public PaymentPage()
	{
		InitializeComponent();
		this.BindingContext = new CreditCardPageViewModel();
	}
}
