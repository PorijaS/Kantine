using Kantine.Controls;
using Kantine.ViewModel;

namespace Kantine.Views;

public partial class PopupPageCandy : BasePopupPage
{
    int count = 1;
    public PopupPageCandy(CandyDetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;

        Counterlabel.Text = $"{count}";
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }

    private async void TapGestureRecognizer_Tapped_NavigateToPaymentPage(object sender, EventArgs e)
    {
        await App.Current.MainPage.Navigation.PushAsync(new PaymentPage());
    }

    public void OnCounterClickedPlus(object sender, EventArgs e)
    {
        if (count >= 1)
        {
            count++;
            Counterlabel.Text = $"{count}";
        }
        else
            Counterlabel.Text = $"{count}";

        SemanticScreenReader.Announce(Counterlabel.Text);
    }

    private void OnCounterClickedMinus(object sender, EventArgs e)
    {

        if (count > 1)
        {
            count--;
            Counterlabel.Text = $"{count}";
        }
        else
            Counterlabel.Text = $"{count}";

        SemanticScreenReader.Announce(Counterlabel.Text);
    }
}