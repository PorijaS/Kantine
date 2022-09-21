using Kantine.Views;

namespace Kantine;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(PopupPageVM), typeof(PopupPageVM));
        Routing.RegisterRoute(nameof(PopupPageCandy), typeof(PopupPageCandy));
    }
}
