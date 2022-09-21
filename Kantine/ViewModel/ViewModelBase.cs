using CommunityToolkit.Mvvm.ComponentModel;

namespace Kantine.ViewModel
{
    public partial class ViewModelBase : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;

        [ObservableProperty]
        string titles;

        public bool IsNotBusy => !IsBusy;
    }
}
