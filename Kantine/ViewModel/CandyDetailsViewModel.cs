using CommunityToolkit.Mvvm.ComponentModel;
using Kantine.Model;

namespace Kantine.ViewModel;

[QueryProperty(nameof(Candy), "Candy")]
public partial class CandyDetailsViewModel : ViewModelBase
{
    public CandyDetailsViewModel()
    {

    }

    [ObservableProperty]
    Candy candy;
}
