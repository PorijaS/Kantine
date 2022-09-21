using CommunityToolkit.Mvvm.ComponentModel;
using Kantine.Model;
using Kantine.Services;
using System.ComponentModel;

namespace Kantine.ViewModel;

[QueryProperty(nameof(VM), "VM")]
public partial class VMDetailsViewModel : ViewModelBase
{
    public VMDetailsViewModel()
    {

    }

    [ObservableProperty]
    VM vM;
    
}


