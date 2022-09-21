using CommunityToolkit.Mvvm.Input;
using Kantine.Model;
using Kantine.Services;
using Kantine.Views;
using System.Collections.ObjectModel;

namespace Kantine.ViewModel
{
    public partial class MenuViewModel : ViewModelBase
    {
        ObservableCollection<Candy> _candies;
        ObservableCollection<VM> _vms;

        public MenuViewModel()
        {
            LoadData();
        }

        public ObservableCollection<Candy> Candies
        {
            get { return _candies; }
            set => SetProperty(ref _candies, value);
        }

        public ObservableCollection<VM> Vms
        {
            get { return _vms; }
            set => SetProperty(ref _vms, value);

        }

        [RelayCommand]
        async Task GoToDetailsVM(VM vm)
        {
            if (vm == null)
                return;

            await Shell.Current.GoToAsync(nameof(PopupPageVM), true,
                new Dictionary<string, object>
                {
                    {"VM", vm }
                });
        }

        [RelayCommand]
        async Task GoToDetailsCandy(Candy candy)
        {
            if (candy == null)
                return;

            await Shell.Current.GoToAsync(nameof(PopupPageCandy), true,
                new Dictionary<string, object>
                {
                    {"Candy", candy }
                });
        }

        void LoadData()
        {
            Candies = new ObservableCollection<Candy>(CandyService.instance.GetCandies());
            Vms = new ObservableCollection<VM>(VMService.instance.GetVMS());
        }
    }
}
