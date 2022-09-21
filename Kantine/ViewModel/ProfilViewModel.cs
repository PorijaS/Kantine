
/* Unmerged change from project 'Kantine (net6.0-maccatalyst)'
Before:
using System;
After:
using Kantine.Model;
*/

/* Unmerged change from project 'Kantine (net6.0-ios)'
Before:
using System;
After:
using Kantine.Model;
*/

/* Unmerged change from project 'Kantine (net6.0-windows10.0.19041.0)'
Before:
using System;
After:
using Kantine.Model;
*/
using Kantine.Services;
using System.Collections.ObjectModel;
using Kantine.Model;

namespace Kantine.ViewModel
{
    public class ProfilViewModel : ViewModelBase
    {
        ObservableCollection<Order> _orders;
        ObservableCollection<User> _users;

        public ProfilViewModel()
        {
            LoadData();
        }

        public ObservableCollection<Order> Orders
        {
            get { return _orders; }
            set => SetProperty(ref _orders, value);
        }

        public ObservableCollection<User> Users
        {
            get { return _users; }
            set => SetProperty(ref _users, value);
        }

        void LoadData()
        {
            Orders = new ObservableCollection<Order>(OrderService.instance.GetOrders());
            Users = new ObservableCollection<User>(UserService.instance.GetUsers());
        }
    }
}

