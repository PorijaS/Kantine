using Kantine.Controls;

namespace Kantine.Views;

public partial class PopupPageVM : BasePopupPage
{
    int count = 1;

    public PopupPageVM()
	{
		InitializeComponent();

        Counterlabel.Text = $"{count}";
    }

	private async void TapGestureRecognizer_Tapped_NavigateToPopupPageVM(object sender, EventArgs e)
	{
		await App.Current.MainPage.Navigation.PushModalAsync(new PopupPageCandy());
	}

	private async void TapGestureRecognizer_Tapped_NavigateToNormalPage(object sender, EventArgs e)
	{
		await App.Current.MainPage.Navigation.PopModalAsync();
		await App.Current.MainPage.Navigation.PushAsync(new PaymentPage());
	}

    public void OnCounterClickedPlus(object sender, EventArgs e)
    {
        if (count >= 1)
        {
            Counterlabel.Text = $"{count}";
            count++;
        }
        else
            Counterlabel.Text = $"{count}";

        SemanticScreenReader.Announce(Counterlabel.Text);
    }

    private void OnCounterClickedMinus(object sender, EventArgs e)
    {

        if (count > 1)
        {
            Counterlabel.Text = $"{count}";
            count--;
        }
        else
            Counterlabel.Text = $"{count}";

        SemanticScreenReader.Announce(Counterlabel.Text);
    }
}