using Kantine.ViewModel;

namespace Kantine;

public partial class Menu : ContentPage
{
    public Menu(MenuViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}